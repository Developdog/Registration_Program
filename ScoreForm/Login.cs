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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        // DB 연결
        string _server = "155.230.235.248";
        int _port = 34056;
        string _database = "swdb366";
        string _id = "2017116366";
        string _pw = "5514";
        string _connectionAddress = "";

        // 로그인 정보 (학/교번, 학과, 이름)
        int m_Num;
        string m_Dept, m_Name;

        public Login()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void Btn_findPW_Click(object sender, EventArgs e)
        {
            FindPW findPW = new FindPW();
            findPW.ShowDialog();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if ((txt_id.Text) == "")
            {
                MessageBox.Show("아이디를 입력하지 않았습니다");
                txt_id.Focus();
                return;
            }
            else if ((txt_pw.Text) == "")
            {
                MessageBox.Show("비밀번호를 입력하지 않았습니다");
                txt_pw.Focus();
                return;
            }

            string kindTable = "student";
            if (radioBtn_professor.Checked == true)
            {
                kindTable = "professor";
            }
            else if (radioBtn_student.Checked == true)
            {
                kindTable = "student";
            }

            MySqlConnection myConn = new MySqlConnection(_connectionAddress);
            try
            {
                MySqlCommand SelectCommand = new MySqlCommand("Select num, dept, name From " + kindTable + " where id = '" + this.txt_id.Text + "' and pw = '" + this.txt_pw.Text + "';", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    m_Num = int.Parse(myReader.GetString(0));
                    m_Dept = myReader.GetString(1);
                    m_Name = myReader.GetString(2);

                    count = count + 1;
                }
                if (count == 1)
                {
                    if (kindTable.Equals("student"))
                    {
                        Student_Main student = new Student_Main(m_Num.ToString());
                        student.Show();
                    }
                    else if (kindTable.Equals("professor"))
                    {
                        Professor_Main professor = new Professor_Main(this);
                        professor.Show();
                    }
                }
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 잘못 입력 되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void Btn_findID_Click(object sender, EventArgs e)
        {
            FindID findID = new FindID();
            findID.ShowDialog();
        }

        private void Btn_signUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }

        public int On_getNum()
        {
            return m_Num;
        }

        public string On_getDept()
        {
            return m_Dept;
        }

        public string On_getName()
        {
            return m_Name;
        }
    }
}
