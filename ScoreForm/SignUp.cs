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
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {
        // DB 연결
        string _server = "155.230.235.248";
        int _port = 34056;
        string _database = "swdb366";
        string _id = "2017116366";
        string _pw = "5514";
        string _connectionAddress = "";

        string kindTable = "student";
        bool id_check = false;
        bool num_check = false;

        public SignUp()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            combo_dept.SelectedIndex = 0;
        }

        private void radioBtn_student_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_student.Checked)
            {
                label_num.Text = "학번";
                kindTable = "student";
            }
        }

        private void radioBtn_professor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_professor.Checked)
            {
                label_num.Text = "교번";
                kindTable = "professor";
            }
        }

        private void Btn_checkNum_Click(object sender, EventArgs e)
        {   // 학번, 교번 중복 검사
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                string m_query = string.Format("SELECT num FROM {0};", kindTable);
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(m_query, conn);
                    command.ExecuteNonQuery();
                    MySqlDataReader myReader = command.ExecuteReader();
                    if (myReader.HasRows)
                    {
                        int count = 0;
                        while (myReader.Read())
                        {
                            if (txt_num.Text.Equals(myReader.GetString(0)))
                            {
                                count = 1;
                                break;
                            }
                        }
                        string m_str1 = label_num.Text;
                        if (count == 0)
                        {
                            num_check = true;
                            string m_msg = string.Format("사용가능한 {0}입니다.", m_str1);
                            MessageBox.Show(m_msg);
                        }
                        else
                        {
                            string m_msg = string.Format("이미 사용중인 {0}입니다.", m_str1);
                            MessageBox.Show(m_msg);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void Btn_checkID_Click(object sender, EventArgs e)
        {   // 아이디 중복 검사
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                string m_query = string.Format("SELECT id FROM {0};", kindTable);
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(m_query, conn);
                    command.ExecuteNonQuery();
                    MySqlDataReader myReader = command.ExecuteReader();
                    if (myReader.HasRows)
                    {
                        int count = 0;
                        while (myReader.Read())
                        {
                            if (txt_id.Text.Equals(myReader.GetString(0)))
                            {
                                count = 1;
                                break;
                            }
                        }
                        if (count == 0)
                        {
                            id_check = true;
                            MessageBox.Show("사용 가능한 아이디입니다.");
                        }
                        else
                        {
                            MessageBox.Show("이미 사용중인 아이디입니다.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (!On_checkContent())
            {
                return;
            }

            if (num_check == false)
            {
                MessageBox.Show("학번 중복검사를 해주세요.");
                return;
            }
            else if (id_check == false)
            {
                MessageBox.Show("아이디 중복검사를 해주세요.");
                return;
            }

            using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
            {
                string insertQuery = string.Format("INSERT INTO {0} (num, dept, name, id, pw) VALUES ('{1}', '{2}', '{3}', '{4}', '{5}');", kindTable, txt_num.Text, combo_dept.Text, txt_name.Text, txt_id.Text, txt_pw.Text);
                try
                {
                    mysql.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                mysql.Close();
            }

            string m_msg = string.Format("{0} 님 회원가입을 환영합니다.", txt_name.Text);
            MessageBox.Show(m_msg);

            this.Close();
        }

        private bool On_checkContent()
        {
            if (txt_name.Text.Equals("") || txt_name.Text.Length > 10)
            {
                MessageBox.Show("이름을 10자 이내로 입력해주세요.");
                txt_name.Focus();
                return false;
            }
            else if (txt_num.Text.Equals("") || txt_num.Text.Length > 10)
            {
                MessageBox.Show(label_num.Text + "을 10자 이내로 입력해주세요.");
                txt_num.Focus();
                return false;
            }
            else if (txt_id.Text.Equals("") || txt_id.Text.Length > 10)
            {
                MessageBox.Show("아이디를 10자 이내로 입력해주세요.");
                txt_id.Focus();
                return false;
            }
            else if (txt_pw.Text.Equals("") || txt_pw.Text.Length > 10)
            {
                MessageBox.Show("비밀번호를 10자 이내로 입력해주세요.");
                txt_pw.Focus();
                return false;
            }
            else if (txt_pw2.Text.Equals("") || txt_pw2.Text.Length > 10)
            {
                MessageBox.Show("비밀번호 재확인을 10자 이내로 입력해주세요.");
                txt_pw2.Focus();
                return false;
            }
            else if (!txt_pw.Text.Equals(txt_pw2.Text))
            {
                MessageBox.Show("입력한 두 비밀번호가 일치하지 않습니다.");
                txt_pw.Focus();
                return false;
            }
            return true;
        }

        private void checkBox_pw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pw.Checked)
            {
                txt_pw.PasswordChar = default;
                txt_pw2.PasswordChar = default;
            }
            else
            {
                txt_pw.PasswordChar = '●';
                txt_pw2.PasswordChar = '●';
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            id_check = false;
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {
            num_check = false;
        }
    }
}

