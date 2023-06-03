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
    public partial class SetPW : MetroFramework.Forms.MetroForm
    {
        // DB 연결
        string _server = "155.230.235.248";
        int _port = 34056;
        string _database = "swdb366";
        string _id = "2017116366";
        string _pw = "5514";
        string _connectionAddress = "";

        // textBox PlaceHolder
        TextBox[] txtList;
        const string pwPlaceholder = "새 비밀번호";
        const string pw2Placeholder = "새 비밀번호 확인";

        FindPW f1;
        
        public SetPW(FindPW form)
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            f1 = form;
        }

        private void SetPW_Load(object sender, EventArgs e)
        {
            txt_id.Text = f1.txt_id.Text;

            //ID, Password TextBox Placeholder 설정
            txtList = new TextBox[] { txt_pw, txt_pw2 };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == txt_pw) txt.Text = pwPlaceholder;
                else if (txt == txt_pw2) txt.Text = pw2Placeholder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
            if (txt.Text == pwPlaceholder)
            {   
                txt.ForeColor = Color.Black;    
                txt.Text = string.Empty;
                txt_pw.PasswordChar = '●';
            }
            if (txt.Text == pw2Placeholder)
            {   
                txt.ForeColor = Color.Black;
                txt.Text = string.Empty;
                txt_pw2.PasswordChar = '●';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {   //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray;
                if (txt == txt_pw)
                {
                    txt.Text = pwPlaceholder;
                    txt_pw.PasswordChar = default;
                }
                else if (txt == txt_pw2)
                {
                    txt.Text = pw2Placeholder;
                    txt_pw2.PasswordChar = default;
                }
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_pw.Text.Equals("") || txt_pw.Text.Length > 10)
            {
                MessageBox.Show("비밀번호를 10자 이내로 입력해주세요.");
                txt_pw.Focus();
                return;
            }
            else if (txt_pw2.Text.Equals("") || txt_pw2.Text.Length > 10)
            {
                MessageBox.Show("비밀번호 확인을 10자 이내로 입력해주세요.");
                txt_pw2.Focus();
                return;
            }
            else if (!txt_pw.Text.Equals(txt_pw2.Text))
            {
                MessageBox.Show("입력한 두 비밀번호가 일치하지 않습니다.");
                txt_pw.Focus();
                return;
            }

            string kindTable = f1.On_getKindRadioBtn();
            MySqlConnection myConn = new MySqlConnection(_connectionAddress);
            try
            {
                string m_query = string.Format("Update {0} Set pw = '{1}' where num = '{2}';", kindTable, txt_pw.Text, f1.txt_num.Text);
                myConn.Open();
                MySqlCommand SelectCommand = new MySqlCommand(m_query, myConn);
                SelectCommand.ExecuteNonQuery();

                MessageBox.Show("비밀번호를 바꿨습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
            this.Close();
            f1.Close();
        }
    }
}
