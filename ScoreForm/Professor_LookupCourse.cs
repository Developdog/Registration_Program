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
    public partial class Professor_LookupCourse : MetroFramework.Forms.MetroForm
    {
        // DB 연결
        string _server = "155.230.235.248";
        int _port = 34056;
        string _database = "swdb366";
        string _id = "2017116366";
        string _pw = "5514";
        string _connectionAddress = "";

        Professor_Main Main_form;

        // 교수 로그인 정보 (교번)
        int num_Professor;

        public Professor_LookupCourse(Professor_Main form)
        {
            InitializeComponent();
            Main_form = form;
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}",
                _server, _port, _database, _id, _pw);
        }

        private void Professor_LookupCourse_Load(object sender, EventArgs e)
        {
            num_Professor = Main_form.On_getNum();
            On_initComboBox_semester();
        }

        private void On_initComboBox_semester()
        {   // Default Value: 2021년 2학기
            comboBox_semester.SelectedIndex = 0;
        }

        private void On_InitListView()
        {   // ListView 초기화
            ListView_Schedule.Items.Clear();
            for (int i = 9; i <= 18; i++)
            {
                ListViewItem lvt = new ListViewItem();
                string alpha = i.ToString() + "시";
                lvt.Text = alpha;
                lvt.SubItems.Add("0");
                lvt.SubItems.Add("0");
                lvt.SubItems.Add("0");
                lvt.SubItems.Add("0");
                lvt.SubItems.Add("0");
                ListView_Schedule.Items.Add(lvt);
                lvt.UseItemStyleForSubItems = false;
            }
        }

        private void On_setListView()
        {
            foreach (ListViewItem itemRow in ListView_Schedule.Items)
            {
                for (int i = 0; i < itemRow.SubItems.Count; i++)
                {
                    // 배경색 초기화
                    if (i == 0)
                        itemRow.SubItems[i].BackColor = Color.Khaki;
                    // 글자색 초기화
                    if (itemRow.SubItems[i].Text == "0")
                    {
                        itemRow.SubItems[i].ForeColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void On_getTableData()
        {
            // DB table (course)에서 데이터 불러오기
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                int m_intSemester = On_getSemester();
                string m_query = string.Format("SELECT title, code, day, start_time, end_time FROM course WHERE num = {0} AND deadline = {1} AND semester = {2};", num_Professor, 1, m_intSemester);
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(m_query, conn);
                    command.ExecuteNonQuery();
                    MySqlDataReader myReader = command.ExecuteReader();
                    List<Color[]> colors = new List<Color[]>()
                    {
                        new Color[] { Color.LightSkyBlue, Color.Tomato, Color.SandyBrown, Color.CornflowerBlue, Color.IndianRed, Color.DarkSeaGreen, Color.MediumSlateBlue, Color.Green }
                    };

                    if (myReader.HasRows)
                    {
                        int colorNum = 0;
                        int m_Start, m_End, m_Day;
                        while (myReader.Read())
                        {   
                            m_Day = On_getDayToInt(myReader.GetString(2));  // 1: 월, 2: 화
                            m_Start = int.Parse(myReader.GetString(3)) - 9;
                            m_End = int.Parse(myReader.GetString(4)) - 9;
                            // 강의명(과목코드) 입력
                            string m_str = string.Format("{0}({1})", myReader.GetString(0), myReader.GetString(1));
                            ListView_Schedule.Items[m_Start].SubItems[m_Day].Text = m_str;
                            // 시작 시간 ~ 종료 시간 배경 색 변경
                            for(int i=0; i<m_End-m_Start; i++)
                            {
                                ListView_Schedule.Items[m_Start + i].SubItems[m_Day].ForeColor = Color.Black;
                                ListView_Schedule.Items[m_Start + i].SubItems[m_Day].BackColor = colors[0][colorNum%5];
                                if (i != 0)
                                    ListView_Schedule.Items[m_Start + i].SubItems[m_Day].Text = "";
                            }
                            colorNum++;
                        }
                    }
                    else
                    {
                        string m_str = string.Format("'{0}'에 개설된 강의가 없습니다.", comboBox_semester.Text);
                        MessageBox.Show(m_str);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }   // end On_getTableData()

        private int On_getDayToInt(string str)
        {
            int result = -1;
            if (str.Equals("월"))
                result = 1;
            else if (str.Equals("화"))
                result = 2;
            else if (str.Equals("수"))
                result = 3;
            else if (str.Equals("목"))
                result = 4;
            else if (str.Equals("금"))
                result = 5;

            return result;
        }

        private int On_getSemester()
        {   // comboBox_semester 에서 선택된 내용을 int형으로 반환
            int m_reuslt = -1;

            if (comboBox_semester.SelectedIndex == 0)
            {
                m_reuslt = 20212;   // 21년 2학기
            }
            else if (comboBox_semester.SelectedIndex == 1)
            {
                m_reuslt = 20211;   // 21년 1학기
            }
            else if (comboBox_semester.SelectedIndex == 3)
            {
                m_reuslt = 20202;   // 20년 2학기
            }
            else if (comboBox_semester.SelectedIndex == 4)
            {
                m_reuslt = 20201;   // 20년 1학기
            }
            else if (comboBox_semester.SelectedIndex == 3)
            {
                m_reuslt = 20192;   // 19년 2학기
            }
            else if (comboBox_semester.SelectedIndex == 4)
            {
                m_reuslt = 20191;   // 19년 1학기
            }
            else if (comboBox_semester.SelectedIndex == 3)
            {
                m_reuslt = 20182;   // 18년 2학기
            }
            else if (comboBox_semester.SelectedIndex == 4)
            {
                m_reuslt = 20181;   // 18년 1학기
            }
            else if (comboBox_semester.SelectedIndex == 3)
            {
                m_reuslt = 20172;   // 17년 2학기
            }
            else if (comboBox_semester.SelectedIndex == 4)
            {
                m_reuslt = 20171;   // 17년 1학기
            }
            return m_reuslt;
        }

        private void ListView_Schedule_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e)
        {   // ListView item 클릭 X
            if (e.IsSelected) e.Item.Selected = false;
        }

        private void ListView_Schedule_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {   // ListView column 넓이 변경 X
            e.NewWidth = ListView_Schedule.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void ReNew_Click(object sender, EventArgs e)
        {
            On_InitListView();
            On_setListView();
            On_getTableData();
        }

        private void comboBox_semester_TextChanged(object sender, EventArgs e)
        {   // 해당 학기에 개설된 강의 목록
            On_InitListView();
            On_setListView();
            On_getTableData();
        }
    }
}
