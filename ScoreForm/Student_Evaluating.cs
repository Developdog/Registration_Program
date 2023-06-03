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
    public partial class Student_Evaluating : MetroFramework.Forms.MetroForm
    {
        string mysql = ConfigurationManager.ConnectionStrings["Mydb"].ConnectionString;
        string Student_ID, Code, professor, Course_name;
        MySqlConnection conn;
        Student_CheckScore temp;
        

        public Student_Evaluating(string num, string C, string P, string N, Student_CheckScore temp1)
        {
            InitializeComponent();
            Student_ID = num;
            Code = C;
            professor = P;
            Course_name = N;
            temp = temp1;
            Student_comboBox.SelectedIndex = 0;
            conn = new MySqlConnection(mysql);

            label_name.Text = Course_name;
            label_professor.Text = professor;
        }

        //강의 평가를 입력하는 부분 제대로 입력되지 않았을 경우 갱신되지 않음
        private void Finish_Click(object sender, EventArgs e)
        {
            if((Text_Course.Text.Trim() == "") || (Text_Course.Text == null))
            {
                MessageBox.Show("강의 평가를 제대로 입력해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                conn.Open();

                string sql = "UPDATE " + Code +" set evaluation = " + "\"" + Text_Course.Text + "\", star = \"" + Student_comboBox.Text + "\" where num = " + Student_ID;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader table = cmd.ExecuteReader();

                try
                {
                    while (table.Read())
                    {

                    }
                }

                catch
                {
                    MessageBox.Show("강의 평가를 갱신하던 중 오류가 발생했습니다.");
                    return;
                }
                conn.Close();
                // 종료 전 부모 폼을 갱신 후 종료
                temp.Courseview.Clear();
                temp.pop_up();

                this.Close();
            }
        }

    }
}
