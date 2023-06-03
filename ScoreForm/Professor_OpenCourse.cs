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
using System.Configuration;

namespace ScoreForm
{
    public partial class Professor_OpenCourse : MetroFramework.Forms.MetroForm
    {
        // DB 연결
        string _server = "155.230.235.248";
        int _port = 34056;
        string _database = "swdb366";
        string _id = "2017116366";
        string _pw = "5514";
        string _connectionAddress = "";

        Professor_Main Main_form;

        // 교수 로그인 정보 (교번, 학과, 이름)
        int num_Professor;             
        string dept_Professor;
        string name_Professor; 

        int kind_Course = 0;                // 1: 강의 개설, 2: 강의 수정
        bool do_Update = false;           // 강의 수정 중: true, 수정 종료: false

        public Professor_OpenCourse(Professor_Main form)
        {
            InitializeComponent();
            Main_form = form;
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", 
                _server, _port, _database, _id, _pw);
        }

        private void Professor_OpenCourse_Load(object sender, EventArgs e)
        {
            num_Professor = Main_form.On_getNum();
            dept_Professor = Main_form.On_getDept();
            name_Professor = Main_form.On_getName();
            // ListView 값 저장
            On_getTableCourseData();
        }

        private void Pro_MakeCourse_Click(object sender, EventArgs e)
        {   // 강의 개설 Btn
            kind_Course = 1;
            On_showContent();
        }

        private void Pro_ChangeCourse_Click(object sender, EventArgs e)
        {   // 강의 수정 Btn
            kind_Course = 2;
            On_showContent();
            On_getSelectData();
            do_Update = true;
        }

        private void Pro_CourseConfirmed_Click(object sender, EventArgs e)
        {   // 강의 개설 확정 Btn
            int m_index = ListView_Course.FocusedItem.Index;
            if ((MessageBox.Show("선택한 강의를 개설 확정하시겠습니까?", "강의 개설 확정", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                // 확정된 강의인지 판단
                if (ListView_Course.Items[m_index].SubItems[8].Text.Equals("true"))
                {
                    MessageBox.Show("이미 확정된 강의입니다.");
                    return;
                }

                // DB table(course) 수정
                string m_Code = ListView_Course.Items[m_index].SubItems[1].Text;
                using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                {
                    string m_query = string.Format("UPDATE course SET deadline = {0} WHERE code = '{1}';", 1, m_Code);
                    try
                    {
                        conn.Open();
                        MySqlCommand command = new MySqlCommand(m_query, conn);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.Close();
                }

                // 해당 강의를 듣는 학생의 학번, 학과, 이름 불러오기.
                List<string> List_num = new List<string>();     // 학번
                List<string> List_dept = new List<string>();     // 학과
                List<string> List_name = new List<string>();    // 이름
                using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                {
                    string m_query = string.Format("SELECT num, dept, name FROM student WHERE course1 = '{0}' OR course2 = '{0}' OR course3 = '{0}' OR course4 = '{0}' OR course5 = '{0}' OR course6 = '{0}';", m_Code);
                    try
                    {
                        conn.Open();
                        MySqlCommand command = new MySqlCommand(m_query, conn);
                        command.ExecuteNonQuery();
                        MySqlDataReader myReader = command.ExecuteReader();
                        if (myReader.HasRows)
                        {
                            while (myReader.Read())
                            {
                                List_num.Add(myReader.GetString(0));
                                List_dept.Add(myReader.GetString(1));
                                List_name.Add(myReader.GetString(2));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.Close();
                }

                // DB table(courseCode: 과목코드)에 학생의 학번, 학과, 이름 추가
                using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                {   
                    try
                    {
                        conn.Open();
                        string m_query;
                        MySqlCommand command;
                        for (int i = 0; i < List_num.Count; i++)
                        {
                            m_query = string.Format("INSERT INTO {0} (num, dept, name) VALUES ({1}, '{2}', '{3}');", m_Code, List_num[i], List_dept[i], List_name[i]);
                            command = new MySqlCommand(m_query, conn);
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.Close();
                }

                // ListView 수정
                ListView_Course.Items[m_index].SubItems[8].Text = "true";

                // MessageBox 출력
                string m_Msg = string.Format("{0} 강의 개설이 확정 되었습니다.", ListView_Course.Items[m_index].SubItems[0].Text);
                MessageBox.Show(m_Msg);
            }
            else
            {
                return;
            }
        }

        private void Pro_DeleteCourse_Click(object sender, EventArgs e)
        {   // 강의 삭제 Btn
            if ((MessageBox.Show("정말 강의를 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                if (ListView_Course.SelectedItems.Count > 0)
                {
                    int m_index = ListView_Course.FocusedItem.Index;
                    string m_title = ListView_Course.Items[m_index].SubItems[0].Text;
                    string m_Code = ListView_Course.Items[m_index].SubItems[1].Text;
                    
                    // DB table(course)에서 강의 삭제
                    using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                    {
                        string m_query = string.Format("DELETE FROM course WHERE code = '{0}';", m_Code);
                        try
                        {
                            conn.Open();
                            MySqlCommand command = new MySqlCommand(m_query, conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        conn.Close();
                    }

                    // DB table (과목코드) 삭제
                    using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                    {
                        string m_query = string.Format("DROP TABLE {0};", m_Code);
                        try
                        {
                            conn.Open();
                            MySqlCommand command = new MySqlCommand(m_query, conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        conn.Close();
                    }

                    // DB table (student) 에서 해당 과목코드 삭제
                    using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                    {
                        try
                        {
                            conn.Open();
                            string m_query;
                            MySqlCommand command;
                            for (int i = 1; i <= 6; i++)
                            {   
                                m_query = string.Format("UPDATE student SET {0} = '{1}' WHERE {0} = '{2}';", "course" + i.ToString(), "", m_Code);
                                command = new MySqlCommand(m_query, conn);
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        conn.Close();
                    }

                    // ListView에서 강의 제거
                    ListView_Course.Items.RemoveAt(m_index);

                    // MessageBox 출력
                    string m_Msg = string.Format("{0} 강의가 삭제 되었습니다.", m_title);
                    MessageBox.Show(m_Msg);
                }
                else
                {
                    MessageBox.Show("삭제할 강의를 선택해주세요.");
                }
            }
            else
            {
                return;
            }
        }

        private void ReNew_Click(object sender, EventArgs e)
        {   // 새로고침 Btn
            On_getTableCourseData();
        }

        private void OK_Click(object sender, EventArgs e)
        {   // 강의 개설 및 수정 - OK Btn
            // Course 내용 입력란 확인
            if (!On_checkContent())
            {
                return;
            }

            // 강의 개설
            if (kind_Course == 1)         
            {
                // 과목 코드 중복 확인
                if (!On_checkCourseCode(CourseCode.Text))
                {
                    MessageBox.Show("다른 학과 코드를 입력해주세요.", "이미 존재하는 학과코드입니다.");
                    CourseCode.Focus();
                    return;
                }

                // 강의 시간 중복 확인
                if (!On_checkCourseTime())
                {
                    MessageBox.Show("날짜와 시간을 다시 입력해주세요.", "겹치는 강의가 있습니다.");
                    CourseDay.Focus();
                    return;
                }

                // DB table (course)에 자료 추가
                using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                {
                    string m_query = string.Format("INSERT INTO course(title, code, num, dept, professor, max_num, credit, day, start_time, end_time) values('{0}', '{1}', {2}, '{3}', '{4}', {5}, {6}, '{7}', {8}, {9})",
                        CourseTitle.Text, CourseCode.Text, num_Professor, dept_Professor, name_Professor, int.Parse(CourseMaxNum.Text),
                    int.Parse(CourseCredit.Text), CourseDay.Text, int.Parse(CourseStart.Text), int.Parse(CourseEnd.Text));
                    try
                    {
                        conn.Open();
                        MySqlCommand command = new MySqlCommand(m_query, conn);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.Close();
                }

                // DB table(courseCode) 만들기
                using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                {
                    string m_query = string.Format("CREATE TABLE {0} (`num` int NOT NULL,  `dept` varchar(10) NOT NULL,  `name` varchar(10) NOT NULL,  `midterm` int NOT NULL DEFAULT '0',  `final` int NOT NULL DEFAULT '0',  `assignment` int NOT NULL DEFAULT '0',  `absence` int NOT NULL DEFAULT '0',  `tardiness` int NOT NULL DEFAULT '0', `score` int NOT NULL DEFAULT '0', `ranking` int NOT NULL DEFAULT '0',  `grade` varchar(5) DEFAULT NULL,  `star` varchar(10) DEFAULT NULL,  `evaluation` varchar(500) DEFAULT NULL,  PRIMARY KEY (`num`),  UNIQUE KEY `num_UNIQUE` (`num`));", CourseCode.Text);
                    try
                    {
                        conn.Open();
                        MySqlCommand command = new MySqlCommand(m_query, conn);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.Close();
                }

                // ListView 자료 추가
                string[] row = { CourseTitle.Text, CourseCode.Text, "0", CourseMaxNum.Text, CourseCredit.Text, 
                    CourseDay.Text, CourseStart.Text, CourseEnd.Text, "false" };
                var listViewItem = new ListViewItem(row);
                ListView_Course.Items.Add(listViewItem);

                // MessageBox 출력
                string m_Msg = string.Format("{0} 강의가 개설 되었습니다.", CourseTitle.Text);
                MessageBox.Show(m_Msg);

                On_showList();
                On_resetContent();
            }
            // 강의 수정
            else if (kind_Course == 2)   
            {
                if (ListView_Course.SelectedItems.Count > 0)
                {
                    int m_index = ListView_Course.FocusedItem.Index;
                    string m_ListCode = ListView_Course.Items[m_index].SubItems[1].Text;

                    // 선택한 강의가 수정 가능한지 확인
                    if (ListView_Course.Items[m_index].SubItems[8].Text == "true")
                    {
                        MessageBox.Show("개설이 확정된 강의는 수정이 불가능합니다.", "Error");
                        return;
                    }

                    // 과목 코드 중복 확인
                    // ListView에서 선택한 강의를 수정할 때, 과목 코드가 변경되지 않는다면
                    if (m_ListCode == CourseCode.Text)
                    {
                        ;
                    }
                    else
                    {
                        if (!On_checkCourseCode(CourseCode.Text))
                        {
                            MessageBox.Show("다른 학과 코드를 입력해주세요.", "동일한 학과코드가 존재합니다.");
                            CourseCode.Focus();
                            return;
                        }
                    }

                    // 강의 시간 중복 확인
                    // ListView에서 선택한 강의를 수정할 때, 기존 강의 시간의 범위 내에서  강의 시간이 변경 될 때
                    int m_ListStart = int.Parse(ListView_Course.Items[m_index].SubItems[6].Text);
                    int m_ListEnd = int.Parse(ListView_Course.Items[m_index].SubItems[7].Text);
                    if (int.Parse(CourseStart.Text) >= m_ListStart || int.Parse(CourseStart.Text) < m_ListEnd)
                    {
                        ;
                    }
                    else if (int.Parse(CourseEnd.Text) > m_ListStart || int.Parse(CourseEnd.Text) <= m_ListEnd)
                    {
                        ;
                    }
                    else
                    {
                        if (!On_checkCourseTime())
                        {
                            MessageBox.Show("날짜와 시간을 다시 입력해주세요.", "겹치는 강의가 있습니다.");
                            CourseDay.Focus();
                            return;
                        }
                    }

                    // DB table (course)에 자료 수정
                    using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                    {
                        string m_query = string.Format("UPDATE course SET title = '{0}', code = '{1}', max_num = {2}, credit = {3}, day = '{4}', start_time = {5}, end_time = {6} WHERE code = '{7}';",
                            CourseTitle.Text, CourseCode.Text, int.Parse(CourseMaxNum.Text),
                        int.Parse(CourseCredit.Text), CourseDay.Text, int.Parse(CourseStart.Text), int.Parse(CourseEnd.Text),
                        ListView_Course.Items[m_index].SubItems[1].Text);
                        try
                        {
                            conn.Open();
                            MySqlCommand command = new MySqlCommand(m_query, conn);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        conn.Close();
                    }

                    // 과목 코드가 변경 됐을 시
                    if (!CourseCode.Text.Equals(m_ListCode))
                    {
                        // (1) DB table(CourseCode) 이름 수정
                        using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                        {
                            string m_query = string.Format("ALTER TABLE {0} RENAME TO {1};", m_ListCode, CourseCode.Text);
                            try
                            {
                                conn.Open();
                                MySqlCommand command = new MySqlCommand(m_query, conn);
                                command.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            conn.Close();
                        }
                        // (2) DB table(student) 의 column(course1~6) 과목코드 수정
                        using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
                        {
                            try
                            {
                                conn.Open();
                                string m_query;
                                MySqlCommand command;
                                for (int i = 1; i <= 6; i++)
                                {   
                                    m_query = string.Format("UPDATE student SET {0} = '{1}' WHERE {0} = '{2}';", "course"+i.ToString(), CourseCode.Text, m_ListCode);
                                    command = new MySqlCommand(m_query, conn);
                                    command.ExecuteNonQuery();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            conn.Close();
                        }
                    }

                    // ListView 자료 수정
                    ListView_Course.Items[m_index].SubItems[0].Text = CourseTitle.Text;
                    ListView_Course.Items[m_index].SubItems[1].Text = CourseCode.Text;
                    ListView_Course.Items[m_index].SubItems[3].Text = CourseMaxNum.Text;
                    ListView_Course.Items[m_index].SubItems[4].Text = CourseCredit.Text;
                    ListView_Course.Items[m_index].SubItems[5].Text = CourseDay.Text;
                    ListView_Course.Items[m_index].SubItems[6].Text = CourseStart.Text;
                    ListView_Course.Items[m_index].SubItems[7].Text = CourseEnd.Text;

                    // MessageBox 출력
                    string m_Msg = string.Format("{0} 강의가 수정 되었습니다.", CourseTitle.Text);
                    MessageBox.Show(m_Msg);

                    On_resetContent();
                    On_showList();
                }
                else
                {
                    MessageBox.Show("수정할 강의를 선택해주세요.");
                }
                do_Update = false;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {   // 강의 개설 및 수정 - Cancel Btn
            On_resetContent();
            On_showList();
            do_Update = false;
        }

        private void On_showContent()
        {   // button 비활성화, label 및 textbox 활성화
            Pro_MakeCourse.Visible = false;
            Pro_ChangeCourse.Visible = false;
            Pro_CourseConfirmed.Visible = false;
            Pro_DeleteCourse.Visible = false;

            label_title.Visible = true;
            label_code.Visible = true;
            label_maxNum.Visible = true;
            label_credit.Visible = true;
            label_day.Visible = true;
            label_start.Visible = true;
            label_end.Visible = true;

            CourseTitle.Visible = true;
            CourseCode.Visible = true;
            CourseMaxNum.Visible = true;
            CourseCredit.Visible = true;
            CourseDay.Visible = true;
            CourseStart.Visible = true;
            CourseEnd.Visible = true;

            OK.Visible = true;
            Cancel.Visible = true;
            CourseTitle.Focus();
        }

        private void On_showList()
        {   // button 활성화, label 및 textbox 비활성화
            Pro_MakeCourse.Visible = true;
            Pro_ChangeCourse.Visible = true;
            Pro_CourseConfirmed.Visible = true;
            Pro_DeleteCourse.Visible = true;

            label_title.Visible = false;
            label_code.Visible = false;
            label_maxNum.Visible = false;
            label_credit.Visible = false;
            label_day.Visible = false;
            label_start.Visible = false;
            label_end.Visible = false;

            CourseTitle.Visible = false;
            CourseCode.Visible = false;
            CourseMaxNum.Visible = false;
            CourseCredit.Visible = false;
            CourseDay.Visible = false;
            CourseStart.Visible = false;
            CourseEnd.Visible = false;

            OK.Visible = false;
            Cancel.Visible = false;
        }

        private void On_getSelectData()
        {   // ListView의 item을 textBox에 저장 
            if (ListView_Course.SelectedItems.Count > 0)
            {
                // 선택한 행의 인덱스 값 가져오기
                int m_index = ListView_Course.FocusedItem.Index;
                CourseTitle.Text = ListView_Course.Items[m_index].SubItems[0].Text;
                CourseCode.Text = ListView_Course.Items[m_index].SubItems[1].Text;
                CourseMaxNum.Text = ListView_Course.Items[m_index].SubItems[3].Text;
                CourseCredit.Text = ListView_Course.Items[m_index].SubItems[4].Text;
                CourseDay.Text = ListView_Course.Items[m_index].SubItems[5].Text;
                CourseStart.Text = ListView_Course.Items[m_index].SubItems[6].Text;
                CourseEnd.Text = ListView_Course.Items[m_index].SubItems[7].Text;
            }
        }

        private void On_getTableCourseData()
        {
            // DB table(course: 강의목록)의 자료를 ListView에 저장
            ListView_Course.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                string m_query = string.Format("SELECT title, code, current_num, max_num, credit, day, start_time, end_time, deadline FROM course WHERE num = {0};", num_Professor);
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(m_query, conn);
                    command.ExecuteNonQuery();
                    MySqlDataReader myReader = command.ExecuteReader();
                    if (myReader.HasRows)
                    {
                        string m_bool = "error";
                        while (myReader.Read())
                        {
                            // column(deadline)의 값을 치환
                            if (int.Parse(myReader.GetString(8)) == 0) 
                                m_bool = "false";
                            else if (int.Parse(myReader.GetString(8)) == 1) 
                                m_bool = "true";
                            string[] row = { myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), 
                                myReader.GetString(4), myReader.GetString(5), myReader.GetString(6), myReader.GetString(7), m_bool};
                            var listViewItem = new ListViewItem(row);
                            ListView_Course.Items.Add(listViewItem);
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

        private bool On_checkContent()
        {
            // 과목코드 첫 글자 받기
            char[] ch = CourseCode.Text.Substring(0, 1).ToCharArray();
            char ch2 = ch[0];
            // Course 내용 입력란 확인
            if (CourseTitle.Text.Equals("") || CourseTitle.Text.Length > 10)
            {
                MessageBox.Show("강의명을 10자 이내로 입력해주세요.");
                CourseTitle.Focus();
                return false;
            }
            else if (CourseCode.Text.Equals("") || CourseCode.Text.Length > 8)
            {
                MessageBox.Show("과목코드를 8자 이내로 입력해주세요.");
                CourseCode.Focus();
                return false;
            }
            else if (ch2 < 97 || ch2 > 122)
            {
                MessageBox.Show("과목코드는 알파벳 소문자로 시작해야 합니다.");
                CourseCode.Focus();
                return false;
            }
            else if (CourseMaxNum.Text.Equals("") || int.Parse(CourseMaxNum.Text) <10 || int.Parse(CourseMaxNum.Text) > 100)
            {
                MessageBox.Show("수강 정원을 10~100명 이내로 입력해주세요.");
                CourseMaxNum.Focus();
                return false;
            }
            else if (CourseCredit.Text.Equals("") || int.Parse(CourseCredit.Text) > 4)
            {
                MessageBox.Show("학점을 4학점 이내로 입력해주세요.");
                CourseCredit.Focus();
                return false;
            }
            else if (int.Parse(CourseStart.Text) < 9 || int.Parse(CourseStart.Text) > 18)
            {
                MessageBox.Show("강의 시작 시간을 9~18시 이내로 입력해주세요.");
                CourseStart.Focus();
                return false;
            }
            else if (int.Parse(CourseEnd.Text) < 10 || int.Parse(CourseEnd.Text) > 19)
            {
                MessageBox.Show("강의 종료 시간을 10~19시 이내로 입력해주세요.");
                CourseEnd.Focus();
                return false;
            }
            else if (int.Parse(CourseEnd.Text) - int.Parse(CourseStart.Text) < 1 || int.Parse(CourseEnd.Text) - int.Parse(CourseStart.Text) > 4)
            {
                MessageBox.Show("강의 시간을 1~4시간 이내로 입력해주세요.");
                CourseStart.Focus();
                return false;
            }
            return true;
        }

        private bool On_checkCourseCode(string m_Code)
        {
            // 학과 코드 중복 확인
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                string m_query = string.Format("SELECT code FROM course");
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(m_query, conn);
                    command.ExecuteNonQuery();
                    MySqlDataReader myReader = command.ExecuteReader();
                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            if(myReader.GetString(0) == m_Code)
                            {
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            return true;
        }

        private bool On_checkCourseTime()
        {
            // 강의 시간 중복 확인
            using (MySqlConnection conn = new MySqlConnection(_connectionAddress))
            {
                int m_Start, m_End;     // (수정전) 강의 시작 시간, 종료 시간
                int m_newStart = int.Parse(CourseStart.Text);
                int m_newEnd = int.Parse(CourseEnd.Text);
                string m_query = string.Format("SELECT start_time, end_time FROM course WHERE num = '{0}' AND day = '{1}';", num_Professor, CourseDay.Text);
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(m_query, conn);
                    command.ExecuteNonQuery();
                    MySqlDataReader myReader = command.ExecuteReader();
                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            m_Start = int.Parse(myReader.GetString(0));
                            m_End = int.Parse(myReader.GetString(1)) - 1;
                            for (int i = 0; i <= m_End - m_Start; i++)
                            {
                                for (int j=0; j<= m_newEnd- m_newStart; j++)
                                {
                                    if ((m_Start+i) == (m_newStart+j))
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            return true;
        }

        private void On_resetContent()
        {   // Content 초기화
            CourseTitle.Text = "";
            CourseCode.Text = "";
            CourseMaxNum.Text = "";
            CourseCredit.Text = "";
            CourseDay.SelectedIndex = 0;
            CourseStart.SelectedIndex = 0;
            CourseEnd.SelectedIndex = 0;
        }

        private void ListView_Course_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {   // 강의 수정 중일 때, ListView의 선택 행이 바뀔 때마다
            if (do_Update == true)
            {
                On_getSelectData();
            }
        }

        private void ListView_Course_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {   // ListView column 넓이 변경 X
            e.NewWidth = ListView_Course.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
