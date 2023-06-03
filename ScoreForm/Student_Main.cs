using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ScoreForm
{
    public partial class Student_Main: MetroFramework.Forms.MetroForm
    {
        string mysql = ConfigurationManager.ConnectionStrings["Mydb"].ConnectionString;
        string Student_ID;
        string Student_name;
        MySqlConnection conn;

        public Student_Main(string N)
        {
            InitializeComponent();
            Student_ID = N;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(mysql);
            conn.Open();
            string sql = "Select name From Student where num = " + Student_ID;
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {
                    Student_name = table.GetString(0);
                }
            }
            catch
            {
            }

            conn.Close();



            HomeName.Text = Student_name + "님 환영합니다!";
            
        }

        private void Student_Schedule_b_Click(object sender, EventArgs e)
        {

            foreach (Form openForm in Application.OpenForms)
            {
                
                if (openForm.Name == "Student_Schedule") // 열린 폼의 이름 검사
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {  // 폼을 최소화시켜 하단에 내려놓았는지 검사
                        openForm.WindowState = FormWindowState.Normal;
                        openForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    }
                    openForm.Activate();
                    return;
                    // 만약 폼이 활성화되어있을 경우 해당 폼을 띄워준다.
                }
            }

            Student_Schedule profess = new Student_Schedule(Student_ID);
            profess.Show();

        }

        private void Student_Select_b_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {

                if (openForm.Name == "Student_Select")
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {  
                        openForm.WindowState = FormWindowState.Normal;
                        openForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    }
                    openForm.Activate();
                    return;
                }
            }

            Student_Select profess = new Student_Select(Student_ID);
            profess.Show();
        }

        private void Student_CheckScore_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {

                if (openForm.Name == "Student_CheckScore")
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {  
                        openForm.WindowState = FormWindowState.Normal;
                        openForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                    }
                    openForm.Activate();
                    return;
                }
            }

            Student_CheckScore profess = new Student_CheckScore(Student_ID);
            profess.Show();
        }
    }
}
