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
    public partial class Student_Schedule : MetroFramework.Forms.MetroForm
    {
        string mysql = ConfigurationManager.ConnectionStrings["Mydb"].ConnectionString;
        string Student_ID;
        int title_n = 0, Day_n = 1, Start_n = 2, End_n = 3;
        MySqlConnection conn;

        //시간표 높이 조절
        private void SetHeight(ListView Lv, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            Lv.SmallImageList = imgList;
        }

        public Student_Schedule(string N)
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Exlabel.Text = "검색하실 학기를 입력해주세요.\n ex)2021년 2학기이면 20212"; //"First line" + Environment.NewLine + "Second line";
            Semester.Text = "20212";
            Student_ID = N;
            conn = new MySqlConnection(mysql);
            pop_up();
        }



        private void Student_CheckScore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Courseview_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth =  Courseview.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void pop_up()
        {

            Courseview.View = View.Details;
            Courseview.GridLines = true;
            //610 360

            Courseview.Columns.Add("시간", 60, HorizontalAlignment.Center);
            Courseview.Columns.Add("월", 109, HorizontalAlignment.Center);
            Courseview.Columns.Add("화", 109, HorizontalAlignment.Center);
            Courseview.Columns.Add("수", 109, HorizontalAlignment.Center);
            Courseview.Columns.Add("목", 109, HorizontalAlignment.Center);
            Courseview.Columns.Add("금", 108, HorizontalAlignment.Center);
            SetHeight(Courseview, 31);

            for (int i = 9; i <= 18; i++)
            {
                ListViewItem lvt = new ListViewItem();
                string alpha = i.ToString() + "시";
                lvt.Text = alpha;
                lvt.SubItems.Add("");
                lvt.SubItems.Add("");
                lvt.SubItems.Add("");
                lvt.SubItems.Add("");
                lvt.SubItems.Add("");
                lvt.UseItemStyleForSubItems = false;

                Courseview.Items.Add(lvt);

                Courseview.Items[i-9].SubItems[0].BackColor = Color.YellowGreen;
            }

            List<string> Course_code = new List<string>();
            int Max_Course = 6;

            string Day, title;
            int Start, End, Day_num = 0;

            conn.Open();

            string sql = "Select course1, course2, course3, course4, course5, course6 From Student where num = " + Student_ID + " and semester = " + Semester.Text.ToString();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {
                    for (int i = 0; i < Max_Course; i++)
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
                MessageBox.Show("오류발생");
            }
            conn.Close();

            for (int i = 0; i < Course_code.Count(); i++)
            {

                conn.Open();
                sql = "select title, day, start_time, end_time from course where code = " + "\"" + Course_code[i] + "\" and semester =" + Semester.Text.ToString();

                cmd = new MySqlCommand(sql, conn);
                table = cmd.ExecuteReader();

                try
                {
                    while (table.Read())
                    {
                        title = table.GetString(title_n);
                        Day = table.GetString(Day_n);
                        Start = table.GetInt32(Start_n);
                        End = table.GetInt32(End_n);

                        switch (Day)
                        {
                            case "월":
                                Day_num = 1;
                                break;
                            case "화":
                                Day_num = 2;
                                break;
                            case "수":
                                Day_num = 3;
                                break;
                            case "목":
                                Day_num = 4;
                                break;
                            case "금":
                                Day_num = 5;
                                break;
                        }

                        for (int j = Start - 9; j <= End - 9; j++)
                        {
                            switch (i)
                            {
                                case 0:
                                    Courseview.Items[j].SubItems[Day_num].BackColor = Color.LightSkyBlue;
                                    break;
                                case 1:
                                    Courseview.Items[j].SubItems[Day_num].BackColor = Color.Tomato;
                                    break;
                                case 2:
                                    Courseview.Items[j].SubItems[Day_num].BackColor = Color.SandyBrown;
                                    break;
                                case 3:
                                    Courseview.Items[j].SubItems[Day_num].BackColor = Color.CornflowerBlue;
                                    break;
                                case 4:
                                    Courseview.Items[j].SubItems[Day_num].BackColor = Color.IndianRed;
                                    break;
                                case 5:
                                    Courseview.Items[j].SubItems[Day_num].BackColor = Color.DarkSeaGreen;
                                    break;
                            }
                            Courseview.Items[j].SubItems[Day_num].Text = title + "(" + Course_code[i] + ")";

                        }
                    }
                }

                catch
                {
                    MessageBox.Show("오류 발생");
                }

                conn.Close();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Courseview.Clear();
            pop_up();
        }
    }
}
