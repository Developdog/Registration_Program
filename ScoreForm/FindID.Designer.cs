
namespace ScoreForm
{
    partial class FindID
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
            this.Btn_findID = new System.Windows.Forms.Button();
            this.radioBtn_professor = new System.Windows.Forms.RadioButton();
            this.radioBtn_student = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_dept = new System.Windows.Forms.ComboBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_dept = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_findID);
            this.groupBox1.Controls.Add(this.radioBtn_professor);
            this.groupBox1.Controls.Add(this.radioBtn_student);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(19, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 267);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Btn_findID
            // 
            this.Btn_findID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_findID.Location = new System.Drawing.Point(15, 217);
            this.Btn_findID.Name = "Btn_findID";
            this.Btn_findID.Size = new System.Drawing.Size(298, 39);
            this.Btn_findID.TabIndex = 15;
            this.Btn_findID.Text = "아이디 찾기";
            this.Btn_findID.UseVisualStyleBackColor = true;
            this.Btn_findID.Click += new System.EventHandler(this.Btn_findID_Click);
            // 
            // radioBtn_professor
            // 
            this.radioBtn_professor.AutoSize = true;
            this.radioBtn_professor.Location = new System.Drawing.Point(71, 22);
            this.radioBtn_professor.Name = "radioBtn_professor";
            this.radioBtn_professor.Size = new System.Drawing.Size(49, 19);
            this.radioBtn_professor.TabIndex = 7;
            this.radioBtn_professor.TabStop = true;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_dept);
            this.groupBox3.Controls.Add(this.txt_num);
            this.groupBox3.Controls.Add(this.txt_name);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label_dept);
            this.groupBox3.Controls.Add(this.label_num);
            this.groupBox3.Controls.Add(this.label_name);
            this.groupBox3.Location = new System.Drawing.Point(15, 40);
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
            this.combo_dept.Location = new System.Drawing.Point(62, 130);
            this.combo_dept.Name = "combo_dept";
            this.combo_dept.Size = new System.Drawing.Size(213, 23);
            this.combo_dept.TabIndex = 12;
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
            // FindID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 338);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindID";
            this.Padding = new System.Windows.Forms.Padding(16, 60, 16, 15);
            this.Text = "FindID";
            this.Load += new System.EventHandler(this.FindID_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_findID;
        private System.Windows.Forms.RadioButton radioBtn_professor;
        private System.Windows.Forms.RadioButton radioBtn_student;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combo_dept;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_dept;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_name;
    }
}