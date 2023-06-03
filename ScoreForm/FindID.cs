using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScoreForm
{
    public partial class FindID : MetroFramework.Forms.MetroForm
    {
        // DB 연결
        string _server = "155.230.235.248";
        int _port = 34056;
        string _database = "swdb366";
        string _id = "2017116366";
        string _pw = "5514";
        string _connectionAddress = "";

        public FindID()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void FindID_Load(object sender, EventArgs e)
        {
            combo_dept.SelectedIndex = 0;
        }

        private void radioBtn_student_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_student.Checked)
            {
                label_num.Text = "학번";
            }
        }

        private void radioBtn_professor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_professor.Checked)
            {
                label_num.Text = "교번";
            }
        }

        private void Btn_findID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("이름을 입력하지 않았습니다");
                txt_name.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(combo_dept.Text))
            {
                MessageBox.Show("학과를 입력하지 않았습니다");
                combo_dept.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txt_num.Text))
            {
                MessageBox.Show(label_num.Text + "을 입력하지 않았습니다");
                txt_num.Focus();
                return;
            }
            string kindTable = "student";
            if (radioBtn_professor.Checked)
            {
                kindTable = "professor";
            }
            else if (radioBtn_student.Checked)
            {
                kindTable = "student";
            }

            string m_findID = "";
            MySqlConnection myConn1 = new MySqlConnection(_connectionAddress);
            try
            {
                myConn1.Open();
                string m_query = string.Format("Select id From {0} where num = {1} AND name = '{2}' AND dept = '{3}';", kindTable, int.Parse(txt_num.Text), txt_name.Text, combo_dept.Text);
                MySqlCommand SelectCommand1 = new MySqlCommand(m_query, myConn1);
                SelectCommand1.ExecuteNonQuery();
                MySqlDataReader myReader = SelectCommand1.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        m_findID = myReader.GetString(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn1.Close();

            if (m_findID.Equals(""))
            {
                MessageBox.Show("아이디가 존재하지 않거나, 정보를 잘못 입력하였습니다.\n다시 입력해주세요.");
                return;
            }
            else
            {
                MessageBox.Show("회원님의 아이디는 " + m_findID + "입니다.");
                this.Close();
            }
        }
    }
}
