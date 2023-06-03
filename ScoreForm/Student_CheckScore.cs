using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ScoreForm
{
    public partial class Student_CheckScore : MetroFramework.Forms.MetroForm
    {
        string mysql = ConfigurationManager.ConnectionStrings["Mydb"].ConnectionString;
        string Student_ID;
        MySqlConnection conn;

        public Student_CheckScore(string N)
        {
            InitializeComponent();
            conn = new MySqlConnection(mysql);
            Student_ID = N;
            pop_up();
        }

        //리스트뷰 높이 조절
        private void SetHeight(ListView Lv, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            Lv.SmallImageList = imgList;
        }

        //호출 박스
        public void pop_up()
        {
            List<string> Course_code = new List<string>();


            Courseview.View = View.Details;
            Courseview.GridLines = true;
            //580 330

            Courseview.Columns.Add("강의코드", 100, HorizontalAlignment.Center);
            Courseview.Columns.Add("강의명", 200, HorizontalAlignment.Center);
            Courseview.Columns.Add("학점", 80, HorizontalAlignment.Center);
            Courseview.Columns.Add("담당교수", 100, HorizontalAlignment.Center);
            Courseview.Columns.Add("평가여부", -2, HorizontalAlignment.Center);
            SetHeight(Courseview, 31);

            // 학번을 받아온다.
            // 학번을 통해 현재 수강중인 과목코드를 받아온다.
            // 과목코드를 통해 현재 강의의 강의명 학점 담당교수를 받아온다.
            // 과목코드와 학번을 통해 평가여부를 확인하고, 평가여부를 받아온다.
            // 만약 평가가 되었을 경우 경우 해당 행을 칠해준다.

            //학번을 통해 현재 수강중인 과목코드를 받아온다.
            conn.Open();

            string sql = "select course1, course2, course3, course4, course5, course6 from student where num= \"" + Student_ID + "\"";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (!table.IsDBNull(i))
                        {
                            Course_code.Add(table.GetString(i));
                        }
                        else
                        {
                            Course_code.Add("");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("강의 리스트 생성 중 오류발생");
                return;
            }

            conn.Close();

            //과목코드를 통해 현재 강의의 강의명 학점 담당교수를 받아온다.

            for (int i = 0; i < Course_code.Count; i++ ) {
                if (Course_code[i] != "")
                {

                    conn.Open();

                    sql = "select title, professor, credit from course where code = \"" + Course_code[i] + "\"";
                    cmd = new MySqlCommand(sql, conn);
                    table = cmd.ExecuteReader();

                    try
                    {
                        while (table.Read())
                        {

                            ListViewItem lvt = new ListViewItem();
                            lvt.Text = Course_code[i];
                            lvt.SubItems.Add(table.GetString(0));
                            lvt.SubItems.Add(table.GetInt32(2).ToString());
                            lvt.SubItems.Add(table.GetString(1));
                            lvt.SubItems.Add("");
                            lvt.UseItemStyleForSubItems = false;
                            Courseview.Items.Add(lvt);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("강의 값 가져오는 중 오류 발생");
                        return;
                    }

                    conn.Close();
                }

            }

            // 과목코드와 학번을 통해 평가여부를 확인하고, 평가여부를 받아온다.

            for (int i = 0; i < Course_code.Count; i++)
            {
                if (Course_code[i] != "")
                {
                    conn.Open();

                    sql = "select evaluation from " + Course_code[i] + " where num = " + Student_ID;
                    cmd = new MySqlCommand(sql, conn);
                    table = cmd.ExecuteReader();

                    try
                    {
                        while (table.Read())
                        {
                            if(table.IsDBNull(0))
                            {
                                Courseview.Items[i].SubItems[4].Text = "미 실시";
                            }
                            else if(table.GetString(0).Trim() == "")
                            {
                                Courseview.Items[i].SubItems[4].Text = "미 실시";
                            }
                            else
                            {
                                Courseview.Items[i].SubItems[4].Text = "완료";

                                
                                Courseview.Items[i].SubItems[0].BackColor = Color.YellowGreen;
                                Courseview.Items[i].SubItems[1].BackColor = Color.YellowGreen;
                                Courseview.Items[i].SubItems[2].BackColor = Color.YellowGreen;
                                Courseview.Items[i].SubItems[3].BackColor = Color.YellowGreen;
                                Courseview.Items[i].SubItems[4].BackColor = Color.YellowGreen;
                            }
                        }
                    }

                    catch
                    {
                        MessageBox.Show("강의 평가 값을 불러오던 중 오류가 발생했습니다.");
                        return;
                    }


                    conn.Close();

                }
            }


        }


        //과목을 더블클릭해서 선택했을 경우
        //만약 해당 강의가 평가되었다면 return하고
        //강의 평가가 되지 않았다면 해당 과목 평가창을 연다.
        private void Courseview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Courseview.SelectedItems.Count <= 0) return;
            int SelectRow = Courseview.SelectedItems[0].Index;
            string Code, professor, Course_name;

            if (Courseview.Items[SelectRow].SubItems[4].Text == "완료")
            {
                MessageBox.Show("이미 완료된 강의 평가입니다!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            foreach (Form openForm in Application.OpenForms)
            {

                if (openForm.Name == "Student_Evaluating") // 열린 폼의 이름 검사
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {  // 폼을 최소화시켜 하단에 내려놓았는지 검사
                        openForm.WindowState = FormWindowState.Normal;
                        openForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    }
                    openForm.Activate();
                    MessageBox.Show("이미 강의평가 창이 열려 있습니다!.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    // 만약 폼이 활성화되어있을 경우 해당 폼을 띄워준다.
                }
            }

            Code = Courseview.Items[SelectRow].SubItems[0].Text;
            Course_name = Courseview.Items[SelectRow].SubItems[1].Text;
            professor = Courseview.Items[SelectRow].SubItems[3].Text;

            Student_Evaluating profess = new Student_Evaluating(Student_ID, Code, professor, Course_name, this);
            profess.Show();

        }

        private void Student__Click(object sender, EventArgs e)
        {
            string num = Student_ID;

            //성적을 보기 위해서는 강의 평가 리스트가 전부 "완료" 로 되어있어야한다.
            for (int i = 0; i < Courseview.Items.Count; i++)
            {
                if(Courseview.Items[i].SubItems[4].Text != "완료")
                {
                    MessageBox.Show("강의 평가를 전부 완료해주시기 바랍니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            foreach (Form openForm in Application.OpenForms)
            {

                if (openForm.Name == "Student_ShowScore")
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    { 
                        openForm.WindowState = FormWindowState.Normal;
                        openForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    }
                    openForm.Activate();
                    MessageBox.Show("이미 성적 확인 창이 열려 있습니다!.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    // 만약 폼이 활성화되어있을 경우 해당 폼을 띄워준다.
                }
            }

            Student_ShowScore profess = new Student_ShowScore(Student_ID);
            profess.Show();
            //강의 평가 열람 조건을 만족했을 시 성적 폼 뜨게 하기

        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Courseview_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = Courseview.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
