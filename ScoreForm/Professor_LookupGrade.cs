using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScoreForm
{
    public partial class Professor_LookupGrade : MetroFramework.Forms.MetroForm
    {
        // DB 연결
        string _server = "155.230.235.248";
        int _port = 34056;
        string _database = "swdb366";
        string _id = "2017116366";
        string _pw = "5514";
        string _connectionAddress = "";

        Professor_LookupStudent student_Form;

        public Professor_LookupGrade(Professor_LookupStudent studentForm)
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}",
                _server, _port, _database, _id, _pw);
            student_Form = studentForm;
        }

        private void Professor_LookupGrade_Load(object sender, EventArgs e)
        {
            On_checkGradeRecord();
            // 숫자만 입력 가능
            txt_midterm.KeyPress += txt_midterm_KeyPress;
            txt_final.KeyPress += txt_final_KeyPress;
            txt_assignment.KeyPress += txt_assignment_KeyPress;
            txt_absence.KeyPress += txt_absence_KeyPress;
        }

        private void Btn_reEvaluation_Click(object sender, EventArgs e)
        {
            On_hideListView();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_midterm.Text.Equals(""))
            {
                MessageBox.Show("중간고사 성적 비율을 입력해주세요.");
                txt_midterm.Focus();
                return;
            }
            else if (txt_final.Text.Equals(""))
            {
                MessageBox.Show("기말고사 성적 비율을 입력해주세요.");
                txt_final.Focus();
                return;
            }
            else if (txt_assignment.Text.Equals(""))
            {
                MessageBox.Show("과제 성적 비율을 입력해주세요.");
                txt_assignment.Focus();
                return;
            }
            else if (txt_absence.Text.Equals(""))
            {
                MessageBox.Show("출석 성적 비율을 입력해주세요.");
                txt_absence.Focus();
                return;
            }

            double m_perMid = double.Parse(txt_midterm.Text);
            double m_perFin = double.Parse(txt_final.Text);
            double m_perAss = double.Parse(txt_assignment.Text);
            double m_perAbs = double.Parse(txt_absence.Text);
            double m_Sum = m_perMid + m_perFin + m_perAss + m_perAbs;
            if (m_Sum != 100)
            {
                MessageBox.Show("배점 비율의 합을 100으로 맞춰주세요.", "배점 비율 입력 실패");
                return;
            }
            m_perMid /= 100;
            m_perFin /= 100;
            m_perAss /= 100;
            m_perAbs /= 100;

            // (1) score 계산 및 Listview 추가
            ListView_grade.Items.Clear();
            string m_Code = student_Form.On_getSelectCode();
            double scoreMid, scoreFin, scoreAss, scoreAbs, countTard, sumScore;
            List<int> List_score = new List<int>();
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                string m_query = string.Format("SELECT num, dept, name, midterm, final, assignment, absence, tardiness FROM {0};", m_Code);
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(m_query, conn);
                    command.ExecuteNonQuery();
                    MySqlDataReader myReader = command.ExecuteReader();
                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            // 성적 계산
                            // 중간, 기말, 과제
                            scoreMid = m_perMid * int.Parse(myReader.GetString(3));     // 중간
                            scoreFin = m_perFin * int.Parse(myReader.GetString(4));         // 기말
                            scoreAss = m_perAss * int.Parse(myReader.GetString(5));         // 과제
                            // 출석, 지각 :: 지각 2회 = 결석 1회, 결석 5회이상: F등급
                            countTard = double.Parse(myReader.GetString(7));   // 지각 횟수
                            scoreAbs = 10 - int.Parse(myReader.GetString(6)) - Math.Truncate(countTard / 2);
                            if (scoreAbs <= 5)
                            {
                                scoreAbs = 0;
                            }
                            else
                            {
                                scoreAbs *= m_perAbs;
                            }
                            sumScore = scoreMid + scoreFin + scoreAss + scoreAbs;
                            sumScore = Math.Round(sumScore);
                            
                            if (scoreAbs == 0)
                            {
                                string[] row = { myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), sumScore.ToString(), "0", "F" };
                                var listViewItem = new ListViewItem(row);
                                ListView_grade.Items.Add(listViewItem);
                            }
                            else
                            {
                                List_score.Add((int)sumScore);
                                string[] row = { myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), sumScore.ToString(), "-1", "-1" };
                                var listViewItem = new ListViewItem(row);
                                ListView_grade.Items.Add(listViewItem);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }

            // (2) 순위 계산
            List_score.Sort();
            List_score.Reverse();
            int m_score, m_count;
            for(int i=0; i<List_score.Count; i++)
            {
                m_count = 0;
                for (int j=0; j< ListView_grade.Items.Count; j++)
                {   // 순위0 = 등급F, 순위제외
                    if(ListView_grade.Items[j].SubItems[4].Text == "0")
                    {
                        continue;
                    }
                    m_score = int.Parse(ListView_grade.Items[j].SubItems[3].Text);
                    if (m_score == List_score[i])
                    {
                        ListView_grade.Items[j].SubItems[4].Text = (i + 1).ToString();
                        m_count++;
                    }
                }
                // 동일 점수가 두 개 이상이라면
                if (m_count > 1)
                {
                    i += (m_count - 1);
                }
            }

            // (3) 등급 평가: A(30%), B(40%), C(30%), F(정원 제외)
            int m_gradeA = (int)Math.Truncate(List_score.Count * 0.3);
            int m_gradeB = (int)Math.Truncate(List_score.Count * 0.7);
            int m_gradeC = List_score.Count;
            int m_rank;
            for (int i = 0; i < ListView_grade.Items.Count; i++)
            {
                m_rank = int.Parse(ListView_grade.Items[i].SubItems[4].Text);
                if (m_rank == 0)
                {
                    continue;
                }
                else if (m_rank<= m_gradeA)
                {
                    ListView_grade.Items[i].SubItems[5].Text = "A";
                }
                else if (m_rank > m_gradeA && m_rank <= m_gradeB)
                {
                    ListView_grade.Items[i].SubItems[5].Text = "B";
                }
                else if (m_rank > m_gradeB && m_rank <= m_gradeC)
                {
                    ListView_grade.Items[i].SubItems[5].Text = "C";
                }
            }

            // DB table (code) 자료 수정 (score, ranking, grade)
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                for(int i=0; i<ListView_grade.Items.Count; i++)
                {
                    string m_query = string.Format("Update {0} SET score = {1}, ranking = {2}, grade = '{3}' WHERE num = {4};",
                    m_Code, int.Parse(ListView_grade.Items[i].SubItems[3].Text), int.Parse(ListView_grade.Items[i].SubItems[4].Text),
                    ListView_grade.Items[i].SubItems[5].Text, int.Parse(ListView_grade.Items[i].SubItems[0].Text));
                    try
                    {
                        conn.Open();
                        MySqlCommand command = new MySqlCommand(m_query, conn);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.Close();
                }
            }
            On_showListView();
        }

        private void On_checkGradeRecord()
        {   // 성적 평가 기록이 있는지 확인
            string m_Code = student_Form.On_getSelectCode();
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                string m_query = string.Format("SELECT grade FROM {0};", m_Code);
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(m_query, conn);
                    command.ExecuteNonQuery();
                    MySqlDataReader myReader = command.ExecuteReader();
                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            // 해당 강의의 성적 평가가 처음이라면
                            if (DBNull.Value.Equals(myReader["grade"]))
                            {
                                On_hideListView();
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // 해당 강의의 성적 평가가 처음이 아니라면, ListView에 성적 정보를 추가
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                string m_query = string.Format("SELECT num, dept, name, score, ranking, grade FROM {0};", m_Code);
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(m_query, conn);
                    command.ExecuteNonQuery();
                    MySqlDataReader myReader = command.ExecuteReader();
                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            string[] row = { myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4), myReader.GetString(5) };
                            var listViewItem = new ListViewItem(row);
                            ListView_grade.Items.Add(listViewItem);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            On_showListView();
        }

        private void On_hideListView()
        {   // Form size 조절, ListView_grade 비활성화 및 group 활성화 
            this.Size = new Size(550, 170);

            ListView_grade.Visible = false;

            label_text.Visible = true;
            groupBox_insert.Visible = true;

            label_midterm.Visible = true;
            label_final.Visible = true;
            label_assignment.Visible = true;
            label_absence.Visible = true;

            txt_midterm.Visible = true;
            txt_final.Visible = true;
            txt_assignment.Visible = true;
            txt_absence.Visible = true;

            Btn_ok.Visible = true;
            Btn_reEvaluation.Visible = false;
        }

        private void On_showListView()
        {   // Form size 조절, ListView_grade 활성화 및 group 비활성화
            this.Size = new Size(500, 450);
            this.Text = "성적 확인";

            ListView_grade.Visible = true;

            label_text.Visible = false;
            groupBox_insert.Visible = false;

            label_midterm.Visible = false;
            label_final.Visible = false;
            label_assignment.Visible = false;
            label_absence.Visible = false;

            txt_midterm.Visible = false;
            txt_final.Visible = false;
            txt_assignment.Visible = false;
            txt_absence.Visible = false;

            Btn_ok.Visible = false;
            Btn_reEvaluation.Visible = true;
        }

        private void txt_midterm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_final_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_assignment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_absence_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
