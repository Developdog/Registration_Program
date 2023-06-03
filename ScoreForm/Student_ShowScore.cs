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
    public partial class Student_ShowScore : MetroFramework.Forms.MetroForm
    {
        string mysql = ConfigurationManager.ConnectionStrings["Mydb"].ConnectionString;
        string Student_ID;
        MySqlConnection conn;

        //리스트뷰 높이 조절
        private void SetHeight(ListView Lv, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            Lv.SmallImageList = imgList;
        }

        public Student_ShowScore(string N)
        {
            List<String> Course_code = new List<string>();

            InitializeComponent();
            Student_ID = N;

            Scoreview.View = View.Details;
            Scoreview.GridLines = true;

            Scoreview.Columns.Add("강의코드", 80, HorizontalAlignment.Center);
            Scoreview.Columns.Add("강의명", 130, HorizontalAlignment.Center);
            Scoreview.Columns.Add("담당교수", 80, HorizontalAlignment.Center);
            Scoreview.Columns.Add("학점", -2, HorizontalAlignment.Center);
            SetHeight(Scoreview, 35);

            conn = new MySqlConnection(mysql);
            conn.Open();

            string sql = "select course1, course2, course3, course4, course5, course6 from student where num = \"" + Student_ID + "\"";
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
                    }
                }
            }
            catch
            {
                MessageBox.Show("강의 코드 리스트 생성 중 오류발생");
                return;
            }

            conn.Close();


            //리스트 뷰 만들기
            for (int i = 0; i < Course_code.Count; i++)
            {

                conn.Open();

                sql = "select title, professor from course where code = " + "\"" + Course_code[i] + "\"";
                cmd = new MySqlCommand(sql, conn);
                table = cmd.ExecuteReader();

                try
                {
                    while (table.Read())
                    {

                        ListViewItem lvt = new ListViewItem();
                        lvt.Text = Course_code[i];
                        lvt.SubItems.Add(table.GetString(0));
                        lvt.SubItems.Add(table.GetString(1));
                        lvt.SubItems.Add("");
                        lvt.UseItemStyleForSubItems = false;
                        Scoreview.Items.Add(lvt);
                    }
                }
                catch
                {
                    MessageBox.Show("강의 리스트뷰 생성 중 오류 발생");
                    return;
                }

                conn.Close();

            }


            //학점 입력받기
            for (int i = 0; i < Course_code.Count; i++)
            {

                conn.Open();

                sql = "select grade from " + Course_code[i] + " where num = " + Student_ID;
                cmd = new MySqlCommand(sql, conn);
                table = cmd.ExecuteReader();

                try
                {
                    while (table.Read())
                    {
                            if (!table.IsDBNull(0))
                            {
                                Scoreview.Items[i].SubItems[3].Text = table.GetString(0);
                            }
                            else
                            {
                                Scoreview.Items[i].SubItems[3].Text = "미입력";
                            }
                    }
                }
                catch
                {
                    MessageBox.Show("등급 값 갱신 중 오류발생");
                    return;
                }

                conn.Close();

            }

        }

        private void FormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Scoreview_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = Scoreview.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
