using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreForm
{
    public partial class Professor_Main : MetroFramework.Forms.MetroForm
    {
        Login Login_form;

        // 로그인 정보 (학/교번, 학과, 이름)
        int num_Professor = -1;
        string dept_Professor = "", name_Professor = "";

        public Professor_Main(Login form)
        {
            InitializeComponent();
            Login_form = form;
        }

        private void Professor_Main_Load(object sender, EventArgs e)
        {
            num_Professor = Login_form.On_getNum();
            dept_Professor = Login_form.On_getDept();
            name_Professor = Login_form.On_getName();

            HomeName.Text = name_Professor + " 교수님, 환영합니다.";
        }

        private void Professor_OpenCourse_b_Click(object sender, EventArgs e)
        {   // 수업 개설
            Professor_OpenCourse profess = new Professor_OpenCourse(this);
            profess.Show();
        }

        private void Professor_LookupCourse_b_Click(object sender, EventArgs e)
        {   // 담당 수업 조회
            Professor_LookupCourse profess = new Professor_LookupCourse(this);
            profess.Show();
        }

        private void Professor_LookupStudent_b_Click(object sender, EventArgs e)
        {   // 수업별 정보 조회
            Professor_LookupStudent profess = new Professor_LookupStudent(this);
            profess.Show();
        }

        private void Professor_evaluation_b_Click(object sender, EventArgs e)
        {   // 강의 평가 확인
            Professor_evaluation profess = new Professor_evaluation(this);
            profess.Show();
        }

        public int On_getNum()
        {
            return num_Professor;
        }

        public string On_getDept()
        {
            return dept_Professor;
        }

        public string On_getName()
        {
            return name_Professor;
        }
    }
}
