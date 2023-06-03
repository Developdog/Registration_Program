
namespace ScoreForm
{
    partial class Professor_OpenCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professor_OpenCourse));
            this.CourseTitle = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.Pro_MakeCourse = new System.Windows.Forms.Button();
            this.Pro_ChangeCourse = new System.Windows.Forms.Button();
            this.Pro_DeleteCourse = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.CourseMaxNum = new System.Windows.Forms.TextBox();
            this.label_maxNum = new System.Windows.Forms.Label();
            this.label_day = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label_end = new System.Windows.Forms.Label();
            this.CourseStart = new System.Windows.Forms.ComboBox();
            this.CourseEnd = new System.Windows.Forms.ComboBox();
            this.강의명 = new System.Windows.Forms.ColumnHeader();
            this.과목코드 = new System.Windows.Forms.ColumnHeader();
            this.최대정원 = new System.Windows.Forms.ColumnHeader();
            this.요일 = new System.Windows.Forms.ColumnHeader();
            this.시작시간 = new System.Windows.Forms.ColumnHeader();
            this.종료시간 = new System.Windows.Forms.ColumnHeader();
            this.학점 = new System.Windows.Forms.ColumnHeader();
            this.ListView_Course = new MetroFramework.Controls.MetroListView();
            this.현재정원 = new System.Windows.Forms.ColumnHeader();
            this.확정 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pro_CourseConfirmed = new System.Windows.Forms.Button();
            this.CourseDay = new System.Windows.Forms.ComboBox();
            this.CourseCredit = new System.Windows.Forms.TextBox();
            this.label_credit = new System.Windows.Forms.Label();
            this.CourseCode = new System.Windows.Forms.TextBox();
            this.label_code = new System.Windows.Forms.Label();
            this.ReNew = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReNew)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseTitle
            // 
            this.CourseTitle.Location = new System.Drawing.Point(17, 40);
            this.CourseTitle.Name = "CourseTitle";
            this.CourseTitle.Size = new System.Drawing.Size(215, 23);
            this.CourseTitle.TabIndex = 0;
            this.CourseTitle.Visible = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(17, 17);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(65, 20);
            this.label_title.TabIndex = 18;
            this.label_title.Text = "- 강의명";
            this.label_title.Visible = false;
            // 
            // Pro_MakeCourse
            // 
            this.Pro_MakeCourse.BackColor = System.Drawing.Color.Red;
            this.Pro_MakeCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pro_MakeCourse.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pro_MakeCourse.ForeColor = System.Drawing.Color.White;
            this.Pro_MakeCourse.Location = new System.Drawing.Point(50, 50);
            this.Pro_MakeCourse.Name = "Pro_MakeCourse";
            this.Pro_MakeCourse.Size = new System.Drawing.Size(150, 50);
            this.Pro_MakeCourse.TabIndex = 19;
            this.Pro_MakeCourse.Text = "강의 개설";
            this.Pro_MakeCourse.UseVisualStyleBackColor = false;
            this.Pro_MakeCourse.Click += new System.EventHandler(this.Pro_MakeCourse_Click);
            // 
            // Pro_ChangeCourse
            // 
            this.Pro_ChangeCourse.BackColor = System.Drawing.Color.Red;
            this.Pro_ChangeCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pro_ChangeCourse.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pro_ChangeCourse.ForeColor = System.Drawing.Color.White;
            this.Pro_ChangeCourse.Location = new System.Drawing.Point(50, 122);
            this.Pro_ChangeCourse.Name = "Pro_ChangeCourse";
            this.Pro_ChangeCourse.Size = new System.Drawing.Size(150, 50);
            this.Pro_ChangeCourse.TabIndex = 20;
            this.Pro_ChangeCourse.Text = "강의 수정";
            this.Pro_ChangeCourse.UseVisualStyleBackColor = false;
            this.Pro_ChangeCourse.Click += new System.EventHandler(this.Pro_ChangeCourse_Click);
            // 
            // Pro_DeleteCourse
            // 
            this.Pro_DeleteCourse.BackColor = System.Drawing.Color.Red;
            this.Pro_DeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pro_DeleteCourse.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pro_DeleteCourse.ForeColor = System.Drawing.Color.White;
            this.Pro_DeleteCourse.Location = new System.Drawing.Point(50, 266);
            this.Pro_DeleteCourse.Name = "Pro_DeleteCourse";
            this.Pro_DeleteCourse.Size = new System.Drawing.Size(150, 50);
            this.Pro_DeleteCourse.TabIndex = 21;
            this.Pro_DeleteCourse.Text = "강의 삭제";
            this.Pro_DeleteCourse.UseVisualStyleBackColor = false;
            this.Pro_DeleteCourse.Click += new System.EventHandler(this.Pro_DeleteCourse_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Red;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(134, 324);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 36);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Red;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(37, 324);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 36);
            this.OK.TabIndex = 8;
            this.OK.Text = "확인";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Visible = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CourseMaxNum
            // 
            this.CourseMaxNum.Location = new System.Drawing.Point(17, 142);
            this.CourseMaxNum.Name = "CourseMaxNum";
            this.CourseMaxNum.Size = new System.Drawing.Size(100, 23);
            this.CourseMaxNum.TabIndex = 3;
            this.CourseMaxNum.Visible = false;
            // 
            // label_maxNum
            // 
            this.label_maxNum.AutoSize = true;
            this.label_maxNum.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_maxNum.Location = new System.Drawing.Point(17, 119);
            this.label_maxNum.Name = "label_maxNum";
            this.label_maxNum.Size = new System.Drawing.Size(50, 20);
            this.label_maxNum.TabIndex = 18;
            this.label_maxNum.Text = "- 정원";
            this.label_maxNum.Visible = false;
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_day.Location = new System.Drawing.Point(17, 221);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(50, 20);
            this.label_day.TabIndex = 18;
            this.label_day.Text = "- 요일";
            this.label_day.Visible = false;
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_start.Location = new System.Drawing.Point(17, 272);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(85, 20);
            this.label_start.TabIndex = 18;
            this.label_start.Text = "- 시작 시간";
            this.label_start.Visible = false;
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_end.Location = new System.Drawing.Point(134, 272);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(85, 20);
            this.label_end.TabIndex = 22;
            this.label_end.Text = "- 종료 시간";
            this.label_end.Visible = false;
            // 
            // CourseStart
            // 
            this.CourseStart.FormattingEnabled = true;
            this.CourseStart.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.CourseStart.Location = new System.Drawing.Point(17, 295);
            this.CourseStart.Name = "CourseStart";
            this.CourseStart.Size = new System.Drawing.Size(100, 23);
            this.CourseStart.TabIndex = 6;
            this.CourseStart.Text = "9";
            this.CourseStart.Visible = false;
            // 
            // CourseEnd
            // 
            this.CourseEnd.FormattingEnabled = true;
            this.CourseEnd.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.CourseEnd.Location = new System.Drawing.Point(134, 295);
            this.CourseEnd.Name = "CourseEnd";
            this.CourseEnd.Size = new System.Drawing.Size(100, 23);
            this.CourseEnd.TabIndex = 7;
            this.CourseEnd.Text = "10";
            this.CourseEnd.Visible = false;
            // 
            // 강의명
            // 
            this.강의명.Text = "강의명";
            // 
            // 과목코드
            // 
            this.과목코드.Text = "과목코드";
            this.과목코드.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 최대정원
            // 
            this.최대정원.Text = "최대정원";
            this.최대정원.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 요일
            // 
            this.요일.Text = "요일";
            this.요일.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.요일.Width = 40;
            // 
            // 시작시간
            // 
            this.시작시간.Text = "시작시간";
            this.시작시간.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.시작시간.Width = 50;
            // 
            // 종료시간
            // 
            this.종료시간.Text = "종료시간";
            this.종료시간.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.종료시간.Width = 50;
            // 
            // 학점
            // 
            this.학점.Text = "학점";
            this.학점.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.학점.Width = 40;
            // 
            // ListView_Course
            // 
            this.ListView_Course.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView_Course.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.강의명,
            this.과목코드,
            this.현재정원,
            this.최대정원,
            this.학점,
            this.요일,
            this.시작시간,
            this.종료시간,
            this.확정});
            this.ListView_Course.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListView_Course.FullRowSelect = true;
            this.ListView_Course.GridLines = true;
            this.ListView_Course.Location = new System.Drawing.Point(25, 65);
            this.ListView_Course.MultiSelect = false;
            this.ListView_Course.Name = "ListView_Course";
            this.ListView_Course.OwnerDraw = true;
            this.ListView_Course.Size = new System.Drawing.Size(470, 360);
            this.ListView_Course.TabIndex = 1;
            this.ListView_Course.UseCompatibleStateImageBehavior = false;
            this.ListView_Course.UseSelectable = true;
            this.ListView_Course.View = System.Windows.Forms.View.Details;
            this.ListView_Course.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_Course_ColumnWidthChanging);
            this.ListView_Course.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_Course_ItemSelectionChanged);
            // 
            // 현재정원
            // 
            this.현재정원.Text = "현재정원";
            this.현재정원.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 확정
            // 
            this.확정.Text = "확정";
            this.확정.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.확정.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pro_CourseConfirmed);
            this.groupBox1.Controls.Add(this.Pro_DeleteCourse);
            this.groupBox1.Controls.Add(this.Pro_ChangeCourse);
            this.groupBox1.Controls.Add(this.Pro_MakeCourse);
            this.groupBox1.Controls.Add(this.CourseDay);
            this.groupBox1.Controls.Add(this.CourseEnd);
            this.groupBox1.Controls.Add(this.CourseCredit);
            this.groupBox1.Controls.Add(this.CourseStart);
            this.groupBox1.Controls.Add(this.label_maxNum);
            this.groupBox1.Controls.Add(this.label_credit);
            this.groupBox1.Controls.Add(this.CourseMaxNum);
            this.groupBox1.Controls.Add(this.label_end);
            this.groupBox1.Controls.Add(this.CourseCode);
            this.groupBox1.Controls.Add(this.label_code);
            this.groupBox1.Controls.Add(this.label_title);
            this.groupBox1.Controls.Add(this.OK);
            this.groupBox1.Controls.Add(this.label_start);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.label_day);
            this.groupBox1.Controls.Add(this.CourseTitle);
            this.groupBox1.Location = new System.Drawing.Point(505, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 370);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // Pro_CourseConfirmed
            // 
            this.Pro_CourseConfirmed.BackColor = System.Drawing.Color.Red;
            this.Pro_CourseConfirmed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pro_CourseConfirmed.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pro_CourseConfirmed.ForeColor = System.Drawing.Color.White;
            this.Pro_CourseConfirmed.Location = new System.Drawing.Point(50, 194);
            this.Pro_CourseConfirmed.Name = "Pro_CourseConfirmed";
            this.Pro_CourseConfirmed.Size = new System.Drawing.Size(150, 50);
            this.Pro_CourseConfirmed.TabIndex = 26;
            this.Pro_CourseConfirmed.Text = "강의 개설 확정";
            this.Pro_CourseConfirmed.UseVisualStyleBackColor = false;
            this.Pro_CourseConfirmed.Click += new System.EventHandler(this.Pro_CourseConfirmed_Click);
            // 
            // CourseDay
            // 
            this.CourseDay.FormattingEnabled = true;
            this.CourseDay.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금"});
            this.CourseDay.Location = new System.Drawing.Point(17, 244);
            this.CourseDay.Name = "CourseDay";
            this.CourseDay.Size = new System.Drawing.Size(100, 23);
            this.CourseDay.TabIndex = 5;
            this.CourseDay.Text = "월";
            this.CourseDay.Visible = false;
            // 
            // CourseCredit
            // 
            this.CourseCredit.Location = new System.Drawing.Point(17, 192);
            this.CourseCredit.Name = "CourseCredit";
            this.CourseCredit.Size = new System.Drawing.Size(100, 23);
            this.CourseCredit.TabIndex = 4;
            this.CourseCredit.Visible = false;
            // 
            // label_credit
            // 
            this.label_credit.AutoSize = true;
            this.label_credit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_credit.Location = new System.Drawing.Point(17, 170);
            this.label_credit.Name = "label_credit";
            this.label_credit.Size = new System.Drawing.Size(50, 20);
            this.label_credit.TabIndex = 25;
            this.label_credit.Text = "- 학점";
            this.label_credit.Visible = false;
            // 
            // CourseCode
            // 
            this.CourseCode.Location = new System.Drawing.Point(17, 91);
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.Size = new System.Drawing.Size(215, 23);
            this.CourseCode.TabIndex = 1;
            this.CourseCode.Visible = false;
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_code.Location = new System.Drawing.Point(17, 68);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(80, 20);
            this.label_code.TabIndex = 19;
            this.label_code.Text = "- 과목코드";
            this.label_code.Visible = false;
            // 
            // ReNew
            // 
            this.ReNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReNew.Image = ((System.Drawing.Image)(resources.GetObject("ReNew.Image")));
            this.ReNew.Location = new System.Drawing.Point(725, 29);
            this.ReNew.Name = "ReNew";
            this.ReNew.Size = new System.Drawing.Size(30, 30);
            this.ReNew.TabIndex = 27;
            this.ReNew.TabStop = false;
            this.ReNew.Click += new System.EventHandler(this.ReNew_Click);
            // 
            // Professor_OpenCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.ReNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListView_Course);
            this.Name = "Professor_OpenCourse";
            this.Text = "강의 생성, 수정, 삭제";
            this.Load += new System.EventHandler(this.Professor_OpenCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CourseTitle;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button Pro_MakeCourse;
        private System.Windows.Forms.Button Pro_ChangeCourse;
        private System.Windows.Forms.Button Pro_DeleteCourse;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox CourseMaxNum;
        private System.Windows.Forms.Label label_maxNum;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.ComboBox CourseStart;
        private System.Windows.Forms.ComboBox CourseEnd;
        private System.Windows.Forms.ColumnHeader 강의명;
        private System.Windows.Forms.ColumnHeader 과목코드;
        private System.Windows.Forms.ColumnHeader 최대정원;
        private System.Windows.Forms.ColumnHeader 요일;
        private System.Windows.Forms.ColumnHeader 시작시간;
        private System.Windows.Forms.ColumnHeader 종료시간;
        private System.Windows.Forms.ColumnHeader 학점;
        private MetroFramework.Controls.MetroListView ListView_Course;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CourseCredit;
        private System.Windows.Forms.Label label_credit;
        private System.Windows.Forms.TextBox CourseCode;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.ComboBox CourseDay;
        private System.Windows.Forms.PictureBox ReNew;
        private System.Windows.Forms.Button Pro_CourseConfirmed;
        private System.Windows.Forms.ColumnHeader 확정;
        private System.Windows.Forms.ColumnHeader 현재정원;
    }
}