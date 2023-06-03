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
    public partial class Professor_evaluation : MetroFramework.Forms.MetroForm
    {
        string mysql = ConfigurationManager.ConnectionStrings["Mydb"].ConnectionString;
        string Professor_ID;
        MySqlConnection conn;
        Professor_Main Main_form;


        //int InCourse_Index = InCourse.SelectedItems[0].Index;
        //string next = InCourse.Items[InCourse_Index].SubItems[1].Text;
        public Professor_evaluation(Professor_Main form)
        {
            InitializeComponent();
            conn = new MySqlConnection(mysql);
            Main_form = form;
            Professor_ID = Main_form.On_getNum().ToString();
            pop_up();
        }

        private void SetHeight(ListView Lv, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            Lv.SmallImageList = imgList;
        }


        private void pop_up()
        {
            Courseview.View = View.Details;
            Courseview.GridLines = true;
            Courseview.FullRowSelect = true;

            Courseview.Columns.Add("강의코드", 76, HorizontalAlignment.Center);
            Courseview.Columns.Add("강의명", 160, HorizontalAlignment.Center);
            Courseview.Columns.Add("개설학과", 100, HorizontalAlignment.Center);
            Courseview.Columns.Add("현재인원", 60, HorizontalAlignment.Center);
            Courseview.Columns.Add("최대인원", 60, HorizontalAlignment.Center);
            SetHeight(Courseview, 21);

            conn.Open();

            string code = "", dept = "", title = "";
            int max_num = 0, current_num = 0;

            string sql = "select title, code, dept, max_num, current_num from course where num =" + Professor_ID + " and semester = 20212";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {
                    title = table.GetString(0);
                    code = table.GetString(1);
                    dept = table.GetString(2);
                    max_num = table.GetInt32(3);
                    current_num = table.GetInt32(4);

                    ListViewItem lvt = new ListViewItem();
                    lvt.Text = code;
                    lvt.SubItems.Add(title);
                    lvt.SubItems.Add(dept);
                    lvt.SubItems.Add(max_num.ToString());
                    lvt.SubItems.Add(current_num.ToString());
                    lvt.UseItemStyleForSubItems = false;
                    Courseview.Items.Add(lvt);

                }
            }
            catch
            {
                MessageBox.Show("Courseview 오류발생");
            }

            conn.Close();
        }

        private void Courseview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Courseview.SelectedItems.Count <= 0) return;
            ReviewText.Clear();

            int Course_Index = Courseview.SelectedItems[0].Index;
            string next = Courseview.Items[Course_Index].SubItems[0].Text;

            Course.Text = Courseview.Items[Course_Index].SubItems[1].Text;

            conn.Open();

            string sql = "select star, evaluation from " + next;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader table = cmd.ExecuteReader();
            
            try
            {
                while (table.Read())
                {
                        if (table.IsDBNull(0) || table.IsDBNull(1))
                        {
                            ReviewText.Text = ReviewText.Text + "---- 미 평가 인원 ----";
                            ReviewText.Text += Environment.NewLine;
                            ReviewText.Text += Environment.NewLine;
                        }
                        else
                        {
                            ReviewText.Text = ReviewText.Text + table.GetString(0);
                            ReviewText.Text += Environment.NewLine;
                            ReviewText.Text = ReviewText.Text + table.GetString(1);
                            ReviewText.Text += Environment.NewLine;
                            ReviewText.Text += Environment.NewLine;
                        }

                        ReviewText.Text = ReviewText.Text + "--------------------------------------";
                        ReviewText.Text += Environment.NewLine;
                        ReviewText.Text += Environment.NewLine;
                }
            }
            catch
            {
                MessageBox.Show("ReviewText 기입 중 오류발생");
            }

            conn.Close();
        }
    }
}
