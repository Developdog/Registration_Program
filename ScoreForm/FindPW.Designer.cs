
namespace ScoreForm
{
    partial class FindPW
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
            this.Btn_setPW = new System.Windows.Forms.Button();
            this.radioBtn_professor = new System.Windows.Forms.RadioButton();
            this.radioBtn_student = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_dept = new System.Windows.Forms.ComboBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_dept = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_setPW);
            this.groupBox1.Controls.Add(this.radioBtn_professor);
            this.groupBox1.Controls.Add(this.radioBtn_student);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(19, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 340);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Btn_setPW
            // 
            this.Btn_setPW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_setPW.Location = new System.Drawing.Point(15, 291);
            this.Btn_setPW.Name = "Btn_setPW";
            this.Btn_setPW.Size = new System.Drawing.Size(298, 39);
            this.Btn_setPW.TabIndex = 15;
            this.Btn_setPW.Text = "비밀번호 재설정";
            this.Btn_setPW.UseVisualStyleBackColor = true;
            this.Btn_setPW.Click += new System.EventHandler(this.Btn_setPW_Click);
            // 
            // radioBtn_professor
            // 
            this.radioBtn_professor.AutoSize = true;
            this.radioBtn_professor.Location = new System.Drawing.Point(71, 22);
            this.radioBtn_professor.Name = "radioBtn_professor";
            this.radioBtn_professor.Size = new System.Drawing.Size(49, 19);
            this.radioBtn_professor.TabIndex = 7;
            this.radioBtn_professor.Text = "교수";
            this.radioBtn_professor.UseVisualStyleBackColor = true;
            this.radioBtn_professor.CheckedChanged += new System.EventHandler(this.radioBtn_professor_CheckedChanged);
            // 
            // radioBtn_student
            // 
            this.radioBtn_student.AutoSize = true;
            this.radioBtn_student.Checked = true;
            this.radioBtn_student.Location = new System.Drawing.Point(16, 22);
            this.radioBtn_student.Name = "radioBtn_student";
            this.radioBtn_student.Size = new System.Drawing.Size(49, 19);
            this.radioBtn_student.TabIndex = 6;
            this.radioBtn_student.TabStop = true;
            this.radioBtn_student.Text = "학생";
            this.radioBtn_student.UseVisualStyleBackColor = true;
            this.radioBtn_student.CheckedChanged += new System.EventHandler(this.radioBtn_student_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Location = new System.Drawing.Point(15, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 78);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "비밀번호를 찾고자 하는 아이디를 입력해주세요.";
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(20, 37);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(255, 27);
            this.txt_id.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_dept);
            this.groupBox3.Controls.Add(this.txt_num);
            this.groupBox3.Controls.Add(this.txt_name);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label_dept);
            this.groupBox3.Controls.Add(this.label_num);
            this.groupBox3.Controls.Add(this.label_name);
            this.groupBox3.Location = new System.Drawing.Point(15, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 171);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // combo_dept
            // 
            this.combo_dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_dept.FormattingEnabled = true;
            this.combo_dept.Items.AddRange(new object[] {
            "소프트웨어학과",
            "건설방재학과",
            "패션디자인학과",
            "치위생학과"});
            this.combo_dept.Location = new System.Drawing.Point(62, 127);
            this.combo_dept.Name = "combo_dept";
            this.combo_dept.Size = new System.Drawing.Size(213, 23);
            this.combo_dept.TabIndex = 13;
            // 
            // txt_num
            // 
            this.txt_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_num.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_num.Location = new System.Drawing.Point(62, 86);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(213, 27);
            this.txt_num.TabIndex = 11;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(62, 46);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(213, 27);
            this.txt_name.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "본인 확인을 위해 아래 정보를 입력해주세요.";
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_dept.Location = new System.Drawing.Point(15, 130);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(39, 20);
            this.label_dept.TabIndex = 5;
            this.label_dept.Text = "학과";
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_num.Location = new System.Drawing.Point(15, 90);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(39, 20);
            this.label_num.TabIndex = 4;
            this.label_num.Text = "학번";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(15, 50);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(39, 20);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "이름";
            // 
            // FindPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 414);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindPW";
            this.Padding = new System.Windows.Forms.Padding(16, 60, 16, 15);
            this.Text = "FindPW";
            this.Load += new System.EventHandler(this.FindPW_Load);
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
        private System.Windows.Forms.Button Btn_setPW;
        private System.Windows.Forms.RadioButton radioBtn_professor;
        private System.Windows.Forms.RadioButton radioBtn_student;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combo_dept;
        public System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_dept;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_name;
        public System.Windows.Forms.TextBox txt_id;
    }
}