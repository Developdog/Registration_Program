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
    public partial class Professor_LookupStudent : MetroFramework.Forms.MetroForm
    {
        // DB 연결
        string _server = "155.230.235.248";
        int _port = 34056;
        string _database = "swdb366";
        string _id = "2017116366";
        string _pw = "5514";
        string _connectionAddress = "";

        Professor_Main Main_form;

        // 교수 로그인 정보 (교번)
        int num_Professor;

        List<string> List_title = new List<string>();       // 강의명 list
        List<string> List_code = new List<string>();     // 과목코드 list

        bool do_Update = false;     // 성적 입력 중: true, 입력 종료: false

        public Professor_LookupStudent(Professor_Main form)
        {
            InitializeComponent();
            Main_form = form;
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}",
                _server, _port, _database, _id, _pw);
        }

        private void Professor_LookupStudent_Load(object sender, EventArgs e)
        {
            num_Professor = Main_form.On_getNum();
            On_initComboBox_semester();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {   // 점수 입력 Btn
            On_showContent();
            On_getSelectData();
            do_Update = true;
        }

        private void Btn_evaluation_Click(object sender, EventArgs e)
        {   // 성적 평가 Btn
            Professor_LookupGrade openProfessor_LookupGrade = new Professor_LookupGrade(this);
            openProfessor_LookupGrade.ShowDialog();
        }

        private void ReNew_Click(object sender, EventArgs e)
        {   // 새로고침
            On_addListData();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {   // 점수 입력 Btn - OK Btn
            if (ListView_course.SelectedItems.Count > 0)
            {
                // DB table (List_code)에 자료 수정
                int m_index = ListView_course.FocusedItem.Index;
                using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                {
                    string m_query = string.Format("UPDATE {0} SET midterm = {1}, final = {2}, assignment = {3}, absence = {4}, tardiness = {5} WHERE num = {6};",
                        List_code[comboBox_course.SelectedIndex], int.Parse(txt_midterm.Text), int.Parse(txt_final.Text), int.Parse(txt_assignment.Text),
                        int.Parse(txt_absence.Text), int.Parse(txt_tardiness.Text), int.Parse(ListView_course.Items[m_index].SubItems[0].Text));
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
                }

                // ListView 자료 수정
                ListView_course.Items[m_index].SubItems[3].Text = txt_midterm.Text;
                ListView_course.Items[m_index].SubItems[4].Text = txt_final.Text;
                ListView_course.Items[m_index].SubItems[5].Text = txt_assignment.Text;
                ListView_course.Items[m_index].SubItems[6].Text = txt_absence.Text;
                ListView_course.Items[m_index].SubItems[7].Text = txt_tardiness.Text;

                // MessageBox 출력
                string m_Msg = string.Format("{0} '{1}'의 점수가 입력 되었습니다.", ListView_course.Items[m_index].SubItems[1].Text, ListView_course.Items[m_index].SubItems[2].Text);
                MessageBox.Show(m_Msg, "점수 입력 성공");
                On_hideContent();
                do_Update = false;
            }
            else
            {
                MessageBox.Show("학생을 선택해주세요", "점수 입력 실패");
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {   // 점수 입력 Btn - Cancel Btn
            On_hideContent();
            do_Update = false;
        }

        private void On_initComboBox_semester()
        {   // Default Value: 2021년 2학기
            comboBox_semester.SelectedIndex = 0;
        }

        private void comboBox_semester_TextChanged(object sender, EventArgs e)
        {   // 해당 학기에 개설된 강의명(강의코드)를 comboBox_course 에 추가
            On_addListData();
        }

        private void On_addListData()
        {
            // (1) 해당 학기에 개설된 강의의 이름과 과목코드를 List<> 에 저장
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                int m_intSemester = On_getSemester();
                string m_query = string.Format("SELECT title, code FROM course WHERE num = '{0}' AND deadline = {1} AND semester = {2};", num_Professor, 1, m_intSemester);
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(m_query, conn);
                    command.ExecuteNonQuery();
                    MySqlDataReader myReader = command.ExecuteReader();
                    List_title.Clear();
                    List_code.Clear();
                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            List_title.Add(myReader.GetString(0));
                            List_code.Add(myReader.GetString(1));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // (2) comboBox_course 추가
            // 개설된 강의가 하나 이상일 때
            string m_str;
            if (List_title.Count > 0)
            {
                // comboBox에 강의명 추가
                comboBox_course.Items.Clear();
                for (int i = 0; i < List_title.Count; i++)
                {
                    m_str = string.Format("{0}({1})", List_title[i], List_code[i]);
                    comboBox_course.Items.Add(m_str);
                }

                // comboBox의 text를 첫 번째 인덱스로 설정
                comboBox_course.SelectedIndex = 0;
            }
            else
            {
                comboBox_course.Items.Clear();
                comboBox_course.Text = "";
                m_str = string.Format("'{0}'에 개설된 강의가 없습니다.", comboBox_semester.Text);
                MessageBox.Show(m_str);
            }
        }

        private int On_getSemester()
        {   // comboBox_semester 에서 선택된 내용을 int형으로 반환
            int m_reuslt = -1;

            if (comboBox_semester.SelectedIndex == 0)
            {
                m_reuslt = 20212;   // 21년 2학기
            }
            else if (comboBox_semester.SelectedIndex == 1)
            {
                m_reuslt = 20211;   // 21년 1학기
            }
            else if (comboBox_semester.SelectedIndex == 3)
            {
                m_reuslt = 20202;   // 20년 2학기
            }
            else if (comboBox_semester.SelectedIndex == 4)
            {
                m_reuslt = 20201;   // 20년 1학기
            }
            else if (comboBox_semester.SelectedIndex == 3)
            {
                m_reuslt = 20192;   // 19년 2학기
            }
            else if (comboBox_semester.SelectedIndex == 4)
            {
                m_reuslt = 20191;   // 19년 1학기
            }
            else if (comboBox_semester.SelectedIndex == 3)
            {
                m_reuslt = 20182;   // 18년 2학기
            }
            else if (comboBox_semester.SelectedIndex == 4)
            {
                m_reuslt = 20181;   // 18년 1학기
            }
            else if (comboBox_semester.SelectedIndex == 3)
            {
                m_reuslt = 20172;   // 17년 2학기
            }
            else if (comboBox_semester.SelectedIndex == 4)
            {
                m_reuslt = 20171;   // 17년 1학기
            }
            return m_reuslt;
        }

        private void comboBox_course_TextChanged(object sender, EventArgs e)
        {
            ListView_course.Items.Clear();
            txt_midterm.Text = "";
            txt_final.Text = "";
            txt_assignment.Text = "";
            txt_absence.Text = "";
            txt_tardiness.Text = "";

            // 해당 학기에 개설된 강의가 없다면 종료
            if (comboBox_course.Items.Count == 0)
            {
                return;
            }

            // 해당 과목 정보 조회
            string m_selectCode = List_code[comboBox_course.SelectedIndex];
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                string m_query = string.Format("SELECT num, dept, name, midterm, final, assignment, absence, tardiness FROM {0};", m_selectCode);
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
                            string[] row = { myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3),
                                myReader.GetString(4), myReader.GetString(5), myReader.GetString(6), myReader.GetString(7)};
                            var listViewItem = new ListViewItem(row);
                            ListView_course.Items.Add(listViewItem);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void On_showContent()
        {   // ListView_course size 조절 및 label, textbox, button 활성화
            
            ListView_course.Height = 268;
            
            groupBox_insert.Visible = true;

            label_midterm.Visible = true;
            label_final.Visible = true;
            label_assignment.Visible = true;
            label_absence.Visible = true;
            label_tardiness.Visible = true;

            txt_midterm.Visible = true;
            txt_final.Visible = true;
            txt_assignment.Visible = true;
            txt_absence.Visible = true;
            txt_tardiness.Visible = true;

            Btn_ok.Visible = true;
            Btn_cancel.Visible = true;
        }

        private void On_hideContent()
        {   // ListView_course size 조절 및 label, textbox, button 비활성화

            ListView_course.Height = 360;

            groupBox_insert.Visible = false;

            label_midterm.Visible = false;
            label_final.Visible = false;
            label_assignment.Visible = false;
            label_absence.Visible = false;
            label_tardiness.Visible = false;

            txt_midterm.Visible = false;
            txt_final.Visible = false;
            txt_assignment.Visible = false;
            txt_absence.Visible = false;
            txt_tardiness.Visible = false;

            Btn_ok.Visible = false;
            Btn_cancel.Visible = false;
        }

        private void On_getSelectData()
        {   // ListView의 item을 textBox에 저장
            if (ListView_course.SelectedItems.Count > 0)
            {
                int m_index = ListView_course.FocusedItem.Index;
                txt_midterm.Text = ListView_course.Items[m_index].SubItems[3].Text;
                txt_final.Text = ListView_course.Items[m_index].SubItems[4].Text;
                txt_assignment.Text = ListView_course.Items[m_index].SubItems[5].Text;
                txt_absence.Text = ListView_course.Items[m_index].SubItems[6].Text;
                txt_tardiness.Text = ListView_course.Items[m_index].SubItems[7].Text;
            }
        }

        private void ListView_course_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {   // 성적 입력 중일 때, ListView의 선택 행이 바뀔 때마다
            if (do_Update == true)
            {
                On_getSelectData();
            }
        }

        public string On_getSelectCode()
        {
            return List_code[comboBox_course.SelectedIndex];
        }
    }
}

