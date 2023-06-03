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
    public partial class Student_Select : MetroFramework.Forms.MetroForm
    {
        string mysql = ConfigurationManager.ConnectionStrings["Mydb"].ConnectionString;
        string Student_ID;

        // Mysql Course 자릿수마다 int형을 넣기
        //
        MySqlConnection conn;

        //시간표 높이 조절
        private void SetHeight(ListView Lv, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            Lv.SmallImageList = imgList;
        }

        public Student_Select(string N)
        {
            InitializeComponent();
            Student_ID = N;
            pop_up();
            

        }

        //강의 추가
        private void Student_application_Click(object sender, EventArgs e)
        {
            //기본 리스트 값 받기
            List<string> Course_code = new List<string>();
            List<string> Days = new List<string>();
            List<int> Course_time_Start = new List<int>();
            List<int> Course_time_End = new List<int>();
            string dept = "", name = "";

            conn = new MySqlConnection(mysql);
            conn.Open();

            string sql = "select course1, course2, course3, course4, course5, course6 from student where num= \"" + Student_ID + "\"";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (!table.IsDBNull(i))
                        {
                            Course_code.Add(table.GetString(i));
                        }
                        else
                        {
                            Course_code.Add("");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("리스트 오류발생");
            }

            conn.Close();

            //시간 받기

            for (int i = 0; i < 6; i++)
            {

                if (Course_code[i] == "") continue;

                sql = "select start_time, end_time, day from course where code = \"" + Course_code[i] +"\"";

                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                table = cmd.ExecuteReader();

                try
                {
                    while (table.Read())
                    {
                        //만약 실행되지 않을 시에는 IsDataNull사용

                        Course_time_Start.Add(table.GetInt32(0));
                        Course_time_End.Add(table.GetInt32(1));
                        Days.Add(table.GetString(2));
                    }
                }
                catch
                {
                    MessageBox.Show("시간 리스트 체크");
                }

                conn.Close();
            }

            //강의 신청 하기 전 강의 있는지 확인하기

            if (InCourse.SelectedIndices.Count == 0)
            {
                MessageBox.Show("신청할 강의을 선택해 주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pop_up();
                return;
            }

            conn.Open();

            int InCourse_Index = InCourse.SelectedItems[0].Index;
            string next = InCourse.Items[InCourse_Index].SubItems[1].Text;
            string Days_N;
            int time_start, time_end, null_num = 0;
            bool Check_Null = false;


            sql = "select start_time, end_time, day from course where code = \"" + next + "\"";
            cmd = new MySqlCommand(sql, conn);
            table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {
                    time_start = table.GetInt32(0);
                    time_end = table.GetInt32(1);
                    Days_N = table.GetString(2);

                    bool Check = false;
                    for (int i = 0; i < Days.Count(); i++)
                    {
                        if (Days[i] == Days_N)
                        {
                            if((time_start <= Course_time_Start[i] && time_end >= Course_time_Start[i]) 
                                || (time_start <= Course_time_End[i] && time_end >= Course_time_End[i]))
                            {
                                Check = true;
                            }
                        }
                    }

                    if (Check == true)
                    {
                        MessageBox.Show("시간이 겹치는 강의이 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        for(int i = 0; i < 6; i++)
                        {
                            if (Course_code[i] == "")
                            {
                                null_num = i+1;
                                Check_Null = true;
                                break;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("강의 신청에 문제가 생겼습니다.");
                return;
            }

            conn.Close();


            //현재 인원 체크해서 정원 이상인지 확인하기
            conn.Open();

            int current_num = 0, max_num = 0;

            sql = "Select current_num, max_num from course where code = " + "\"" + next + "\"";
            cmd = new MySqlCommand(sql, conn);
            table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {
                    current_num = table.GetInt32(0);
                    max_num = table.GetInt32(1);

                    if(current_num >= max_num)
                    {
                        MessageBox.Show("정원이 다 찼습니다!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch
            {

            }

            conn.Close();


            // 수강 신청

            if (Check_Null == true)
            {
                conn.Open();

                sql = "UPDATE student set course" + null_num.ToString() + " = " + "\"" + next + "\"" + " where num = \"" + Student_ID + "\"";
                cmd = new MySqlCommand(sql, conn);
                table = cmd.ExecuteReader();

                try
                {
                    while(table.Read())
                    {
                        
                    }
                }
                catch
                {
                    MessageBox.Show("기입에 문제가 생겼습니다.");
                    return;
                }

                conn.Close();

                //현재 인원 업데이트

                conn.Open();

                sql = "UPDATE course set current_num = " + (current_num + 1) + " where code = \"" + next + "\"";
                cmd = new MySqlCommand(sql, conn);
                table = cmd.ExecuteReader();

                try
                {
                    while(table.Read())
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("인원 업데이트에 문제가 생겼습니다.");
                    return;
                }

                conn.Close();

                //추가할 학생 학번 학과 이름 받아오기
                conn.Open();

                sql = "select dept, name from student where num = " + Student_ID;
                cmd = new MySqlCommand(sql, conn);
                table = cmd.ExecuteReader();

                try
                {
                    while (table.Read())
                    {
                        dept = table.GetString(0);
                        name = table.GetString(1);
                    }
                }
                catch
                {
                    MessageBox.Show("학과, 이름을 받아오는데 문제가 생겼습니다.");
                    return;
                }

                conn.Close();

                /*
                //강의 테이블에 인원 추가
                conn.Open();

                sql = "insert into " + next + " (num, dept, name) value (" + Student_ID + "," + "\"" + dept + "\"" + "," + "\"" + name + "\"" + ")";
                cmd = new MySqlCommand(sql, conn);
                table = cmd.ExecuteReader();

                try
                {
                    while (table.Read())
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("강의 테이블에 학생을 추가하는데 문제가 생겼습니다.");
                    return;
                }

                conn.Close();
                */

                //수강 신청 후 추가로 진행될 내용 적어주세요.
            }
            else
            {
                MessageBox.Show("수강 강의이 전부 찼습니다!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            pop_up();
            
        }

        //강의 철회
        private void Student_Withdraw_Click(object sender, EventArgs e)
        {
            if (OutCourse.SelectedIndices.Count == 0)
            {
                MessageBox.Show("철회할 강의을 선택해 주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pop_up();
                return;
            }

            List<string> Course_num = new List<string>();
            int OutCourse_Index = OutCourse.SelectedItems[0].Index;
            string next = OutCourse.Items[OutCourse_Index].SubItems[1].Text;
            int Check_num = 0, current_num = 0;

            conn = new MySqlConnection(mysql);
            conn.Open();

            string sql = "select course1, course2, course3, course4, course5, course6 from student where num = \"" + Student_ID + "\"";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader table = cmd.ExecuteReader();

            try
            {
                while (table.Read()) 
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (!table.IsDBNull(i))
                        {
                            Course_num.Add(table.GetString(i));
                            if (next == Course_num[i])
                            {
                                Check_num = i + 1;
                            }
                        }
                        else
                        {
                            Course_num.Add("");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("값을 가져오는 중 문제가 발생했습니다.");
                return;
            }

            conn.Close();

            //만약 강의가 확정되었을 경우에는 강의 제거를 할 수 없게 만들기

            conn.Open();

            sql = "select deadline from course where code = " + "\"" + next + "\"";
            cmd = new MySqlCommand(sql, conn);
            table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {
                    int deadline = 0;
                    deadline = table.GetInt32(0);

                    if(deadline == 1)
                    {
                        MessageBox.Show("이미 확정되어 철회할 수 없는 강의입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("강의 확정 값을 불러와 체크하던 도중 문제가 생겼습니다.");
                return;
            }

            conn.Close();

            //학생 테이블에서 철회할 강의값 제거

            conn.Open();

            sql = "UPDATE student set course" + Check_num.ToString() + " = " + "\"" + "\"" + " where num = \"" + Student_ID + "\"";
            cmd = new MySqlCommand(sql, conn);
            table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {
                    
                }
            }
            catch
            {
                MessageBox.Show("학생 테이블에서 강의 값을 비우던 중 문제가 발생했습니다.");
                return;
            }

            conn.Close();

            //해당 강의 테이블에서 현재 수강한 인원 값 받아오기

            conn.Open();

            sql = "select current_num from course where code = \"" + next + "\"";
            cmd = new MySqlCommand(sql, conn);
            table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {
                    current_num = table.GetInt32(0);
                }
            }
            catch
            {
                MessageBox.Show("현재 수강 인원 값을 받아오던 중 문제가 발생했습니다.");
                return;
            }

            conn.Close();

            //

            conn.Open();

            sql = "UPDATE course set current_num = " + (current_num - 1) + " where code = \"" + next + "\"";
            cmd = new MySqlCommand(sql, conn);
            table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {

                }
            }
            catch
            {
                MessageBox.Show("현재 수강인원 값을 감소해 다시 테이블에 넣던 중 문제가 발생했습니다.");
                return;
            }

            conn.Close();

            
            //강의 테이블에 학생 값 지우기

            /*
            conn.Open();

            sql = "delete from " + next + " where num = " + Student_ID;
            cmd = new MySqlCommand(sql, conn);
            table = cmd.ExecuteReader();

            try
            {
                while (table.Read())
                {

                }
            }
            catch
            {
                MessageBox.Show("강의 테이블에 학생을 삭제하는데 문제가 발생했습니다.");
                return;
            }

            conn.Close();
            */
            
            //강의 철회 시 추가적으로 코드 필요하면 받아오기

            pop_up();

        }


        //Listview 목록 표 조절 금지
        private void InCourse_ColumnWidthChanging_1(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = InCourse.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void OutCourse_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = InCourse.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }


        //표 값 불러오는 기본 함수
        private void pop_up()
        {
            InCourse.Clear();
            OutCourse.Clear();

            List<string> Course_code = new List<string>();

            conn = new MySqlConnection(mysql);
            conn.Open();

            string sql = "select course1, course2, course3, course4, course5, course6 from student where num= \"" + Student_ID + "\"";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader table = cmd.ExecuteReader();

            try
            {
                while(table.Read())
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (!table.IsDBNull(i))
                        {
                            Course_code.Add(table.GetString(i));
                        }
                        else
                        {
                            Course_code.Add("");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("초기 리스트 오류발생");
            }

            conn.Close();



            //690 180
            //InCourse 구문 넣기
            InCourse.View = View.Details;
            InCourse.GridLines = true;
            InCourse.FullRowSelect = true; 

            InCourse.Columns.Add("강의", 158, HorizontalAlignment.Center);
            InCourse.Columns.Add("강의코드", 62, HorizontalAlignment.Center);
            InCourse.Columns.Add("개설학과", 82, HorizontalAlignment.Center);
            InCourse.Columns.Add("교수", 52, HorizontalAlignment.Center);
            InCourse.Columns.Add("신청인원", 62, HorizontalAlignment.Center);
            InCourse.Columns.Add("최대인원", 62, HorizontalAlignment.Center);
            InCourse.Columns.Add("학점", 42, HorizontalAlignment.Center);
            InCourse.Columns.Add("요일", 42, HorizontalAlignment.Center);
            InCourse.Columns.Add("시작시간", 62, HorizontalAlignment.Center);
            InCourse.Columns.Add("종료시간", 62, HorizontalAlignment.Center);
            SetHeight(InCourse, 21);

            conn = new MySqlConnection(mysql);
            conn.Open();

            sql = "Select * From course";
            cmd = new MySqlCommand(sql, conn);
            table = cmd.ExecuteReader();

            try
            {
                string title, code, dept, professor, day;
                int current_num, max_num, credit, start_time, end_time;

                while (table.Read())
                {

                    int deadline = table.GetInt32(11);
                    if (deadline == 0)
                    {
                        bool Check = false;
                        code = table.GetString(1);
                        for (int i = 0; i < Course_code.Count; i++)
                        {
                            if (code == Course_code[i]) Check = true;
                        }
                        if (Check == true) {  }
                        else
                        {

                            title = table.GetString(0);
                            dept = table.GetString(3);
                            professor = table.GetString(4);
                            current_num = table.GetInt32(5);
                            max_num = table.GetInt32(6);
                            credit = table.GetInt32(7);
                            day = table.GetString(8);
                            start_time = table.GetInt32(9);
                            end_time = table.GetInt32(10);


                            ListViewItem lvt = new ListViewItem();

                            lvt.Text = title;
                            lvt.SubItems.Add(code);
                            lvt.SubItems.Add(dept);
                            lvt.SubItems.Add(professor);
                            lvt.SubItems.Add(current_num.ToString());
                            lvt.SubItems.Add(max_num.ToString());
                            lvt.SubItems.Add(credit.ToString());
                            lvt.SubItems.Add(day);
                            lvt.SubItems.Add(start_time.ToString());
                            lvt.SubItems.Add(end_time.ToString());
                            lvt.UseItemStyleForSubItems = false;
                            InCourse.Items.Add(lvt);

                        }
                        
                    }
                    else { }
                }
            }
            catch
            {
                MessageBox.Show("InCourse 오류발생");
            }

            conn.Close();



            //OutCourse 구문 넣기 --
            //690 180
            OutCourse.View = View.Details;
            OutCourse.GridLines = true;
            OutCourse.FullRowSelect = true;

            OutCourse.Columns.Add("강의", 158, HorizontalAlignment.Center);
            OutCourse.Columns.Add("강의코드", 62, HorizontalAlignment.Center);
            OutCourse.Columns.Add("개설학과", 82, HorizontalAlignment.Center);
            OutCourse.Columns.Add("교수", 52, HorizontalAlignment.Center);
            OutCourse.Columns.Add("신청인원", 62, HorizontalAlignment.Center);
            OutCourse.Columns.Add("최대인원", 62, HorizontalAlignment.Center);
            OutCourse.Columns.Add("학점", 42, HorizontalAlignment.Center);
            OutCourse.Columns.Add("요일", 42, HorizontalAlignment.Center);
            OutCourse.Columns.Add("시작시간", 62, HorizontalAlignment.Center);
            OutCourse.Columns.Add("종료시간", 62, HorizontalAlignment.Center);
            SetHeight(InCourse, 21);

            conn = new MySqlConnection(mysql);
            conn.Open();

            sql = "Select * From course";
            cmd = new MySqlCommand(sql, conn);
            table = cmd.ExecuteReader();

            try
            {
                string title, code, dept, professor, day;
                int current_num, max_num, credit, start_time, end_time;

                while (table.Read())
                {
                    bool Check = false;
                    code = table.GetString(1);

                    for (int i = 0; i < Course_code.Count; i++)
                    {
                        if (code == Course_code[i]) Check = true;
                    }
                    if (Check == false) { }
                    else
                    {

                        title = table.GetString(0);
                        dept = table.GetString(3);
                        professor = table.GetString(4);
                        current_num = table.GetInt32(5);
                        max_num = table.GetInt32(6);
                        credit = table.GetInt32(7);
                        day = table.GetString(8);
                        start_time = table.GetInt32(9);
                        end_time = table.GetInt32(10);


                        ListViewItem lvt = new ListViewItem();

                        lvt.Text = title;
                        lvt.SubItems.Add(code);
                        lvt.SubItems.Add(dept);
                        lvt.SubItems.Add(professor);
                        lvt.SubItems.Add(current_num.ToString());
                        lvt.SubItems.Add(max_num.ToString());
                        lvt.SubItems.Add(credit.ToString());
                        lvt.SubItems.Add(day);
                        lvt.SubItems.Add(start_time.ToString());
                        lvt.SubItems.Add(end_time.ToString());
                        lvt.UseItemStyleForSubItems = false;
                        OutCourse.Items.Add(lvt);

                    }
                }
            }
            catch
            {
                MessageBox.Show("OutCourse 오류발생");
            }

            conn.Close();

        }

        private void EndButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReNew_Click(object sender, EventArgs e)
        {
            pop_up();
        }
    }
}
