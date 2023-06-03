
namespace ScoreForm
{
    partial class Professor_LookupStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professor_LookupStudent));
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.Label = new System.Windows.Forms.Label();
            this.ListView_course = new MetroFramework.Controls.MetroListView();
            this.학번 = new System.Windows.Forms.ColumnHeader();
            this.학과 = new System.Windows.Forms.ColumnHeader();
            this.이름 = new System.Windows.Forms.ColumnHeader();
            this.중간 = new System.Windows.Forms.ColumnHeader();
            this.기말 = new System.Windows.Forms.ColumnHeader();
            this.과제 = new System.Windows.Forms.ColumnHeader();
            this.결석 = new System.Windows.Forms.ColumnHeader();
            this.지각 = new System.Windows.Forms.ColumnHeader();
            this.comboBox_semester = new System.Windows.Forms.ComboBox();
            this.Btn_update = new System.Windows.Forms.Button();
            this.Btn_evaluation = new System.Windows.Forms.Button();
            this.groupBox_insert = new System.Windows.Forms.GroupBox();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.txt_tardiness = new System.Windows.Forms.TextBox();
            this.txt_absence = new System.Windows.Forms.TextBox();
            this.txt_assignment = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.txt_midterm = new System.Windows.Forms.TextBox();
            this.label_tardiness = new System.Windows.Forms.Label();
            this.label_absence = new System.Windows.Forms.Label();
            this.label_assignment = new System.Windows.Forms.Label();
            this.label_final = new System.Windows.Forms.Label();
            this.label_midterm = new System.Windows.Forms.Label();
            this.ReNew = new System.Windows.Forms.PictureBox();
            this.groupBox_insert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReNew)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(131, 100);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(200, 23);
            this.comboBox_course.TabIndex = 0;
            this.comboBox_course.TextChanged += new System.EventHandler(this.comboBox_course_TextChanged);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(25, 70);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(305, 20);
            this.Label.TabIndex = 3;
            this.Label.Text = "- 정보열람을 원하시는 강의을 선택해주세요";
            // 
            // ListView_course
            // 
            this.ListView_course.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView_course.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.학번,
            this.학과,
            this.이름,
            this.중간,
            this.기말,
            this.과제,
            this.결석,
            this.지각});
            this.ListView_course.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListView_course.FullRowSelect = true;
            this.ListView_course.GridLines = true;
            this.ListView_course.Location = new System.Drawing.Point(25, 135);
            this.ListView_course.Name = "ListView_course";
            this.ListView_course.OwnerDraw = true;
            this.ListView_course.Size = new System.Drawing.Size(590, 360);
            this.ListView_course.TabIndex = 4;
            this.ListView_course.UseCompatibleStateImageBehavior = false;
            this.ListView_course.UseSelectable = true;
            this.ListView_course.View = System.Windows.Forms.View.Details;
            this.ListView_course.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_course_ItemSelectionChanged);
            // 
            // 학번
            // 
            this.학번.Text = "학번";
            this.학번.Width = 80;
            // 
            // 학과
            // 
            this.학과.Text = "학과";
            this.학과.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.학과.Width = 80;
            // 
            // 이름
            // 
            this.이름.Text = "이름";
            this.이름.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.이름.Width = 80;
            // 
            // 중간
            // 
            this.중간.Text = "중간";
            this.중간.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.중간.Width = 70;
            // 
            // 기말
            // 
            this.기말.Text = "기말";
            this.기말.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.기말.Width = 70;
            // 
            // 과제
            // 
            this.과제.Text = "과제";
            this.과제.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.과제.Width = 70;
            // 
            // 결석
            // 
            this.결석.Text = "결석";
            this.결석.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.결석.Width = 70;
            // 
            // 지각
            // 
            this.지각.Text = "지각";
            this.지각.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.지각.Width = 70;
            // 
            // comboBox_semester
            // 
            this.comboBox_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_semester.FormattingEnabled = true;
            this.comboBox_semester.Items.AddRange(new object[] {
            "2021년 2학기",
            "2021년 1학기",
            "2020년 2학기",
            "2020년 1학기",
            "2019년 2학기",
            "2019년 1학기",
            "2018년 2학기",
            "2018년 1학기",
            "2017년 2학기",
            "2017년 1학기"});
            this.comboBox_semester.Location = new System.Drawing.Point(25, 100);
            this.comboBox_semester.Name = "comboBox_semester";
            this.comboBox_semester.Size = new System.Drawing.Size(100, 23);
            this.comboBox_semester.TabIndex = 5;
            this.comboBox_semester.TextChanged += new System.EventHandler(this.comboBox_semester_TextChanged);
            // 
            // Btn_update
            // 
            this.Btn_update.BackColor = System.Drawing.Color.Red;
            this.Btn_update.FlatAppearance.BorderSize = 0;
            this.Btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_update.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_update.ForeColor = System.Drawing.Color.White;
            this.Btn_update.Location = new System.Drawing.Point(459, 93);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(75, 30);
            this.Btn_update.TabIndex = 6;
            this.Btn_update.Text = "점수 입력";
            this.Btn_update.UseVisualStyleBackColor = false;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Btn_evaluation
            // 
            this.Btn_evaluation.BackColor = System.Drawing.Color.Red;
            this.Btn_evaluation.FlatAppearance.BorderSize = 0;
            this.Btn_evaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_evaluation.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_evaluation.ForeColor = System.Drawing.Color.White;
            this.Btn_evaluation.Location = new System.Drawing.Point(540, 93);
            this.Btn_evaluation.Name = "Btn_evaluation";
            this.Btn_evaluation.Size = new System.Drawing.Size(75, 30);
            this.Btn_evaluation.TabIndex = 7;
            this.Btn_evaluation.Text = "성적 평가";
            this.Btn_evaluation.UseVisualStyleBackColor = false;
            this.Btn_evaluation.Click += new System.EventHandler(this.Btn_evaluation_Click);
            // 
            // groupBox_insert
            // 
            this.groupBox_insert.Controls.Add(this.Btn_cancel);
            this.groupBox_insert.Controls.Add(this.Btn_ok);
            this.groupBox_insert.Controls.Add(this.txt_tardiness);
            this.groupBox_insert.Controls.Add(this.txt_absence);
            this.groupBox_insert.Controls.Add(this.txt_assignment);
            this.groupBox_insert.Controls.Add(this.txt_final);
            this.groupBox_insert.Controls.Add(this.txt_midterm);
            this.groupBox_insert.Controls.Add(this.label_tardiness);
            this.groupBox_insert.Controls.Add(this.label_absence);
            this.groupBox_insert.Controls.Add(this.label_assignment);
            this.groupBox_insert.Controls.Add(this.label_final);
            this.groupBox_insert.Controls.Add(this.label_midterm);
            this.groupBox_insert.Location = new System.Drawing.Point(25, 408);
            this.groupBox_insert.Name = "groupBox_insert";
            this.groupBox_insert.Size = new System.Drawing.Size(590, 87);
            this.groupBox_insert.TabIndex = 8;
            this.groupBox_insert.TabStop = false;
            this.groupBox_insert.Visible = false;
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackColor = System.Drawing.Color.Red;
            this.Btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_cancel.Location = new System.Drawing.Point(500, 50);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(75, 25);
            this.Btn_cancel.TabIndex = 29;
            this.Btn_cancel.Text = "취소";
            this.Btn_cancel.UseVisualStyleBackColor = false;
            this.Btn_cancel.Visible = false;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Btn_ok
            // 
            this.Btn_ok.BackColor = System.Drawing.Color.Red;
            this.Btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ok.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ok.ForeColor = System.Drawing.Color.White;
            this.Btn_ok.Location = new System.Drawing.Point(500, 20);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(75, 25);
            this.Btn_ok.TabIndex = 28;
            this.Btn_ok.Text = "확인";
            this.Btn_ok.UseVisualStyleBackColor = false;
            this.Btn_ok.Visible = false;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // txt_tardiness
            // 
            this.txt_tardiness.Location = new System.Drawing.Point(401, 45);
            this.txt_tardiness.Name = "txt_tardiness";
            this.txt_tardiness.Size = new System.Drawing.Size(70, 23);
            this.txt_tardiness.TabIndex = 27;
            this.txt_tardiness.Visible = false;
            // 
            // txt_absence
            // 
            this.txt_absence.Location = new System.Drawing.Point(307, 45);
            this.txt_absence.Name = "txt_absence";
            this.txt_absence.Size = new System.Drawing.Size(70, 23);
            this.txt_absence.TabIndex = 26;
            this.txt_absence.Visible = false;
            // 
            // txt_assignment
            // 
            this.txt_assignment.Location = new System.Drawing.Point(213, 45);
            this.txt_assignment.Name = "txt_assignment";
            this.txt_assignment.Size = new System.Drawing.Size(70, 23);
            this.txt_assignment.TabIndex = 25;
            this.txt_assignment.Visible = false;
            // 
            // txt_final
            // 
            this.txt_final.Location = new System.Drawing.Point(119, 45);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(70, 23);
            this.txt_final.TabIndex = 24;
            this.txt_final.Visible = false;
            // 
            // txt_midterm
            // 
            this.txt_midterm.Location = new System.Drawing.Point(25, 45);
            this.txt_midterm.Name = "txt_midterm";
            this.txt_midterm.Size = new System.Drawing.Size(70, 23);
            this.txt_midterm.TabIndex = 9;
            this.txt_midterm.Visible = false;
            // 
            // label_tardiness
            // 
            this.label_tardiness.AutoSize = true;
            this.label_tardiness.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_tardiness.Location = new System.Drawing.Point(401, 20);
            this.label_tardiness.Name = "label_tardiness";
            this.label_tardiness.Size = new System.Drawing.Size(74, 20);
            this.label_tardiness.TabIndex = 23;
            this.label_tardiness.Text = "지각 횟수";
            this.label_tardiness.Visible = false;
            // 
            // label_absence
            // 
            this.label_absence.AutoSize = true;
            this.label_absence.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_absence.Location = new System.Drawing.Point(307, 20);
            this.label_absence.Name = "label_absence";
            this.label_absence.Size = new System.Drawing.Size(74, 20);
            this.label_absence.TabIndex = 22;
            this.label_absence.Text = "결석 횟수";
            this.label_absence.Visible = false;
            // 
            // label_assignment
            // 
            this.label_assignment.AutoSize = true;
            this.label_assignment.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_assignment.Location = new System.Drawing.Point(213, 20);
            this.label_assignment.Name = "label_assignment";
            this.label_assignment.Size = new System.Drawing.Size(74, 20);
            this.label_assignment.TabIndex = 21;
            this.label_assignment.Text = "과제 점수";
            this.label_assignment.Visible = false;
            // 
            // label_final
            // 
            this.label_final.AutoSize = true;
            this.label_final.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_final.Location = new System.Drawing.Point(119, 20);
            this.label_final.Name = "label_final";
            this.label_final.Size = new System.Drawing.Size(69, 20);
            this.label_final.TabIndex = 20;
            this.label_final.Text = "기말고사";
            this.label_final.Visible = false;
            // 
            // label_midterm
            // 
            this.label_midterm.AutoSize = true;
            this.label_midterm.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_midterm.Location = new System.Drawing.Point(25, 20);
            this.label_midterm.Name = "label_midterm";
            this.label_midterm.Size = new System.Drawing.Size(69, 20);
            this.label_midterm.TabIndex = 19;
            this.label_midterm.Text = "중간고사";
            this.label_midterm.Visible = false;
            // 
            // ReNew
            // 
            this.ReNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReNew.Image = ((System.Drawing.Image)(resources.GetObject("ReNew.Image")));
            this.ReNew.Location = new System.Drawing.Point(585, 57);
            this.ReNew.Name = "ReNew";
            this.ReNew.Size = new System.Drawing.Size(30, 30);
            this.ReNew.TabIndex = 28;
            this.ReNew.TabStop = false;
            this.ReNew.Click += new System.EventHandler(this.ReNew_Click);
            // 
            // Professor_LookupStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 520);
            this.Controls.Add(this.ReNew);
            this.Controls.Add(this.groupBox_insert);
            this.Controls.Add(this.Btn_evaluation);
            this.Controls.Add(this.Btn_update);
            this.Controls.Add(this.comboBox_semester);
            this.Controls.Add(this.ListView_course);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.comboBox_course);
            this.Name = "Professor_LookupStudent";
            this.Text = "정보 확인";
            this.Load += new System.EventHandler(this.Professor_LookupStudent_Load);
            this.groupBox_insert.ResumeLayout(false);
            this.groupBox_insert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.Label Label;
        private MetroFramework.Controls.MetroListView ListView_course;
        private System.Windows.Forms.ColumnHeader 학번;
        private System.Windows.Forms.ColumnHeader 이름;
        private System.Windows.Forms.ColumnHeader 중간;
        private System.Windows.Forms.ColumnHeader 기말;
        private System.Windows.Forms.ColumnHeader 과제;
        private System.Windows.Forms.ColumnHeader 결석;
        private System.Windows.Forms.ColumnHeader 지각;
        private System.Windows.Forms.ColumnHeader 학과;
        private System.Windows.Forms.ComboBox comboBox_semester;
        private System.Windows.Forms.Button Btn_update;
        private System.Windows.Forms.Button Btn_evaluation;
        private System.Windows.Forms.GroupBox groupBox_insert;
        private System.Windows.Forms.Label label_tardiness;
        private System.Windows.Forms.Label label_absence;
        private System.Windows.Forms.Label label_assignment;
        private System.Windows.Forms.Label label_final;
        private System.Windows.Forms.Label label_midterm;
        private System.Windows.Forms.TextBox txt_tardiness;
        private System.Windows.Forms.TextBox txt_absence;
        private System.Windows.Forms.TextBox txt_assignment;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.TextBox txt_midterm;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.PictureBox ReNew;
    }
}