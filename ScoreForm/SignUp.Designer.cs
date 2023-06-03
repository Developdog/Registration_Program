
namespace ScoreForm
{
    partial class SignUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.radioBtn_professor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label_num = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.combo_dept = new System.Windows.Forms.ComboBox();
            this.label_dept = new System.Windows.Forms.Label();
            this.radioBtn_student = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_checkID = new System.Windows.Forms.Button();
            this.checkBox_pw = new System.Windows.Forms.CheckBox();
            this.label_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label_pw = new System.Windows.Forms.Label();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label_pw2 = new System.Windows.Forms.Label();
            this.txt_pw2 = new System.Windows.Forms.TextBox();
            this.Btn_checkNum = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_OK);
            this.groupBox1.Controls.Add(this.radioBtn_professor);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioBtn_student);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(8, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 477);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Btn_OK
            // 
            this.Btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_OK.Location = new System.Drawing.Point(23, 427);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(280, 38);
            this.Btn_OK.TabIndex = 7;
            this.Btn_OK.Text = "가입하기";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // radioBtn_professor
            // 
            this.radioBtn_professor.AutoSize = true;
            this.radioBtn_professor.Location = new System.Drawing.Point(89, 21);
            this.radioBtn_professor.Name = "radioBtn_professor";
            this.radioBtn_professor.Size = new System.Drawing.Size(49, 19);
            this.radioBtn_professor.TabIndex = 15;
            this.radioBtn_professor.Text = "교수";
            this.radioBtn_professor.UseVisualStyleBackColor = true;
            this.radioBtn_professor.CheckedChanged += new System.EventHandler(this.radioBtn_professor_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_checkNum);
            this.groupBox2.Controls.Add(this.label_name);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.label_num);
            this.groupBox2.Controls.Add(this.txt_num);
            this.groupBox2.Controls.Add(this.combo_dept);
            this.groupBox2.Controls.Add(this.label_dept);
            this.groupBox2.Location = new System.Drawing.Point(23, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 185);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(12, 19);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(37, 19);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "이름";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Location = new System.Drawing.Point(15, 40);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(250, 23);
            this.txt_name.TabIndex = 1;
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_num.Location = new System.Drawing.Point(12, 70);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(37, 19);
            this.label_num.TabIndex = 7;
            this.label_num.Text = "학번";
            this.label_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_num
            // 
            this.txt_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_num.Location = new System.Drawing.Point(15, 91);
            this.txt_num.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(250, 23);
            this.txt_num.TabIndex = 2;
            this.txt_num.TextChanged += new System.EventHandler(this.txt_num_TextChanged);
            // 
            // combo_dept
            // 
            this.combo_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_dept.FormattingEnabled = true;
            this.combo_dept.Items.AddRange(new object[] {
            "소프트웨어학과",
            "컴퓨터공학과",
            "글로벌소프트웨어학과"});
            this.combo_dept.Location = new System.Drawing.Point(15, 141);
            this.combo_dept.Name = "combo_dept";
            this.combo_dept.Size = new System.Drawing.Size(250, 23);
            this.combo_dept.TabIndex = 3;
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_dept.Location = new System.Drawing.Point(16, 118);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(37, 19);
            this.label_dept.TabIndex = 10;
            this.label_dept.Text = "학과";
            this.label_dept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioBtn_student
            // 
            this.radioBtn_student.AutoSize = true;
            this.radioBtn_student.Checked = true;
            this.radioBtn_student.Location = new System.Drawing.Point(26, 21);
            this.radioBtn_student.Name = "radioBtn_student";
            this.radioBtn_student.Size = new System.Drawing.Size(49, 19);
            this.radioBtn_student.TabIndex = 14;
            this.radioBtn_student.TabStop = true;
            this.radioBtn_student.Text = "학생";
            this.radioBtn_student.UseVisualStyleBackColor = true;
            this.radioBtn_student.CheckedChanged += new System.EventHandler(this.radioBtn_student_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_checkID);
            this.groupBox3.Controls.Add(this.checkBox_pw);
            this.groupBox3.Controls.Add(this.label_id);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.label_pw);
            this.groupBox3.Controls.Add(this.txt_pw);
            this.groupBox3.Controls.Add(this.label_pw2);
            this.groupBox3.Controls.Add(this.txt_pw2);
            this.groupBox3.Location = new System.Drawing.Point(23, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 195);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // Btn_checkID
            // 
            this.Btn_checkID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_checkID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_checkID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_checkID.FlatAppearance.BorderSize = 0;
            this.Btn_checkID.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_checkID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_checkID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_checkID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_checkID.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_checkID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_checkID.Location = new System.Drawing.Point(201, 18);
            this.Btn_checkID.Name = "Btn_checkID";
            this.Btn_checkID.Size = new System.Drawing.Size(65, 20);
            this.Btn_checkID.TabIndex = 14;
            this.Btn_checkID.Text = "중복확인";
            this.Btn_checkID.UseVisualStyleBackColor = false;
            this.Btn_checkID.Click += new System.EventHandler(this.Btn_checkID_Click);
            // 
            // checkBox_pw
            // 
            this.checkBox_pw.AutoSize = true;
            this.checkBox_pw.Location = new System.Drawing.Point(164, 171);
            this.checkBox_pw.Name = "checkBox_pw";
            this.checkBox_pw.Size = new System.Drawing.Size(102, 19);
            this.checkBox_pw.TabIndex = 13;
            this.checkBox_pw.Text = "비밀번호 확인";
            this.checkBox_pw.UseVisualStyleBackColor = true;
            this.checkBox_pw.CheckedChanged += new System.EventHandler(this.checkBox_pw_CheckedChanged);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_id.Location = new System.Drawing.Point(16, 20);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(51, 19);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "아이디";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Location = new System.Drawing.Point(15, 41);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(250, 23);
            this.txt_id.TabIndex = 4;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label_pw
            // 
            this.label_pw.AutoSize = true;
            this.label_pw.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_pw.Location = new System.Drawing.Point(12, 69);
            this.label_pw.Name = "label_pw";
            this.label_pw.Size = new System.Drawing.Size(65, 19);
            this.label_pw.TabIndex = 4;
            this.label_pw.Text = "비밀번호";
            // 
            // txt_pw
            // 
            this.txt_pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pw.Location = new System.Drawing.Point(15, 90);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '●';
            this.txt_pw.Size = new System.Drawing.Size(250, 23);
            this.txt_pw.TabIndex = 5;
            // 
            // label_pw2
            // 
            this.label_pw2.AutoSize = true;
            this.label_pw2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pw2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_pw2.Location = new System.Drawing.Point(16, 118);
            this.label_pw2.Name = "label_pw2";
            this.label_pw2.Size = new System.Drawing.Size(112, 19);
            this.label_pw2.TabIndex = 7;
            this.label_pw2.Text = "비밀번호 재확인";
            // 
            // txt_pw2
            // 
            this.txt_pw2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pw2.Location = new System.Drawing.Point(15, 141);
            this.txt_pw2.Name = "txt_pw2";
            this.txt_pw2.PasswordChar = '●';
            this.txt_pw2.Size = new System.Drawing.Size(250, 23);
            this.txt_pw2.TabIndex = 6;
            // 
            // Btn_checkNum
            // 
            this.Btn_checkNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_checkNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_checkNum.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_checkNum.FlatAppearance.BorderSize = 0;
            this.Btn_checkNum.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_checkNum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_checkNum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_checkNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_checkNum.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_checkNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_checkNum.Location = new System.Drawing.Point(200, 68);
            this.Btn_checkNum.Name = "Btn_checkNum";
            this.Btn_checkNum.Size = new System.Drawing.Size(65, 20);
            this.Btn_checkNum.TabIndex = 15;
            this.Btn_checkNum.Text = "중복확인";
            this.Btn_checkNum.UseVisualStyleBackColor = false;
            this.Btn_checkNum.Click += new System.EventHandler(this.Btn_checkNum_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 530);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.Padding = new System.Windows.Forms.Padding(16, 60, 16, 15);
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.RadioButton radioBtn_professor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.ComboBox combo_dept;
        private System.Windows.Forms.Label label_dept;
        private System.Windows.Forms.RadioButton radioBtn_student;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_pw;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label_pw;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label label_pw2;
        private System.Windows.Forms.TextBox txt_pw2;
        private System.Windows.Forms.Button Btn_checkID;
        private System.Windows.Forms.Button Btn_checkNum;
    }
}