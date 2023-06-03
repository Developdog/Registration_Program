
namespace ScoreForm
{
    partial class Student_Evaluating
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_professor = new System.Windows.Forms.Label();
            this.Text_Course = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Finish = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Student_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "강의 평가하기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "- 강의명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(256, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "- 담당교수";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(23, 118);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(34, 17);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "강의";
            // 
            // label_professor
            // 
            this.label_professor.AutoSize = true;
            this.label_professor.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_professor.Location = new System.Drawing.Point(256, 118);
            this.label_professor.Name = "label_professor";
            this.label_professor.Size = new System.Drawing.Size(34, 17);
            this.label_professor.TabIndex = 4;
            this.label_professor.Text = "교수";
            // 
            // Text_Course
            // 
            this.Text_Course.Location = new System.Drawing.Point(23, 270);
            this.Text_Course.Name = "Text_Course";
            this.Text_Course.Size = new System.Drawing.Size(319, 174);
            this.Text_Course.TabIndex = 5;
            this.Text_Course.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "- 강의 평가하기";
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.Color.Red;
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Finish.ForeColor = System.Drawing.Color.White;
            this.Finish.Location = new System.Drawing.Point(212, 459);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(130, 48);
            this.Finish.TabIndex = 15;
            this.Finish.Text = "완료하기";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "- 평점";
            // 
            // Student_comboBox
            // 
            this.Student_comboBox.FormattingEnabled = true;
            this.Student_comboBox.Items.AddRange(new object[] {
            "★★★★★",
            "★★★★",
            "★★★",
            "★★",
            "★"});
            this.Student_comboBox.Location = new System.Drawing.Point(23, 187);
            this.Student_comboBox.Name = "Student_comboBox";
            this.Student_comboBox.Size = new System.Drawing.Size(121, 23);
            this.Student_comboBox.TabIndex = 18;
            // 
            // Student_Evaluating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(365, 520);
            this.Controls.Add(this.Student_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Text_Course);
            this.Controls.Add(this.label_professor);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student_Evaluating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_professor;
        private System.Windows.Forms.RichTextBox Text_Course;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Student_comboBox;
    }
}