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
    public partial class FindPW : MetroFramework.Forms.MetroForm
    {
        // DB 연결
        string _server = "155.230.235.248";
        int _port = 34056;
        string _database = "swdb366";
        string _id = "2017116366";
        string _pw = "5514";
        string _connectionAddress = "";

        string kind_radioBtn = "student";

        public FindPW()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void FindPW_Load(object sender, EventArgs e)
        {
            combo_dept.SelectedIndex = 0;
        }

        private void radioBtn_student_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_student.Checked)
            {
                label_num.Text = "학번";
            }
            kind_radioBtn = "student";
        }

        private void radioBtn_professor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_professor.Checked)
            {
                label_num.Text = "교번";
            }
            kind_radioBtn = "professor";
        }

        private void Btn_setPW_Click(object sender, EventArgs e)
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
                MessageBox.Show("학번/교번을 입력하지 않았습니다");
                txt_num.Focus();
                return;
            }
            string kindTable = "student";
            if (radioBtn_professor.Checked == true)
            {
                kindTable = "professor";
            }
            else if (radioBtn_student.Checked)
            {
                kindTable = "student";
            }
            MySqlConnection myConn1 = new MySqlConnection(_connectionAddress);
            try
            {
                MySqlCommand SelectCommand1 = new MySqlCommand("Select * From "+ kindTable + " where id = '" + txt_id.Text + "'and name = '" + txt_name.Text + "'and dept = '" + combo_dept.Text + "'and num = '" + txt_num.Text + "';", myConn1);
                MySqlDataReader myReader1;
                myConn1.Open();
                myReader1 = SelectCommand1.ExecuteReader();
                int count = 0;
                while (myReader1.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("해당 정보를 바탕으로 계정을 찾았습니다. 비밀번호를 재설정하세요.");
                    SetPW setPW = new SetPW(this);
                    setPW.ShowDialog();
                }
                else
                {
                    MessageBox.Show("계정을 찾지 못했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn1.Close();
        }

        public string On_getKindRadioBtn()
        {
            return kind_radioBtn;
        }
    }
}

