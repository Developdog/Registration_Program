
namespace ScoreForm
{
    partial class Professor_LookupGrade
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
            this.label_text = new System.Windows.Forms.Label();
            this.groupBox_insert = new System.Windows.Forms.GroupBox();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.txt_absence = new System.Windows.Forms.TextBox();
            this.txt_assignment = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.txt_midterm = new System.Windows.Forms.TextBox();
            this.label_absence = new System.Windows.Forms.Label();
            this.label_assignment = new System.Windows.Forms.Label();
            this.label_final = new System.Windows.Forms.Label();
            this.label_midterm = new System.Windows.Forms.Label();
            this.ListView_grade = new MetroFramework.Controls.MetroListView();
            this.학번 = new System.Windows.Forms.ColumnHeader();
            this.학과 = new System.Windows.Forms.ColumnHeader();
            this.이름 = new System.Windows.Forms.ColumnHeader();
            this.점수 = new System.Windows.Forms.ColumnHeader();
            this.순위 = new System.Windows.Forms.ColumnHeader();
            this.등급 = new System.Windows.Forms.ColumnHeader();
            this.Btn_reEvaluation = new System.Windows.Forms.Button();
            this.groupBox_insert.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_text.Location = new System.Drawing.Point(25, 70);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(319, 20);
            this.label_text.TabIndex = 4;
            this.label_text.Text = "- 성적 평가 요소의 배점 비율을 입력해주세요.";
            // 
            // groupBox_insert
            // 
            this.groupBox_insert.Controls.Add(this.Btn_ok);
            this.groupBox_insert.Controls.Add(this.txt_absence);
            this.groupBox_insert.Controls.Add(this.txt_assignment);
            this.groupBox_insert.Controls.Add(this.txt_final);
            this.groupBox_insert.Controls.Add(this.txt_midterm);
            this.groupBox_insert.Controls.Add(this.label_absence);
            this.groupBox_insert.Controls.Add(this.label_assignment);
            this.groupBox_insert.Controls.Add(this.label_final);
            this.groupBox_insert.Controls.Add(this.label_midterm);
            this.groupBox_insert.Location = new System.Drawing.Point(25, 90);
            this.groupBox_insert.Name = "groupBox_insert";
            this.groupBox_insert.Size = new System.Drawing.Size(500, 67);
            this.groupBox_insert.TabIndex = 9;
            this.groupBox_insert.TabStop = false;
            // 
            // Btn_ok
            // 
            this.Btn_ok.BackColor = System.Drawing.Color.Red;
            this.Btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ok.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ok.ForeColor = System.Drawing.Color.White;
            this.Btn_ok.Location = new System.Drawing.Point(400, 22);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(75, 30);
            this.Btn_ok.TabIndex = 28;
            this.Btn_ok.Text = "확인";
            this.Btn_ok.UseVisualStyleBackColor = false;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // txt_absence
            // 
            this.txt_absence.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_absence.Location = new System.Drawing.Point(307, 35);
            this.txt_absence.Name = "txt_absence";
            this.txt_absence.Size = new System.Drawing.Size(70, 23);
            this.txt_absence.TabIndex = 26;
            this.txt_absence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_absence_KeyPress);
            // 
            // txt_assignment
            // 
            this.txt_assignment.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_assignment.Location = new System.Drawing.Point(213, 35);
            this.txt_assignment.Name = "txt_assignment";
            this.txt_assignment.Size = new System.Drawing.Size(70, 23);
            this.txt_assignment.TabIndex = 25;
            this.txt_assignment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_assignment_KeyPress);
            // 
            // txt_final
            // 
            this.txt_final.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_final.Location = new System.Drawing.Point(119, 35);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(70, 23);
            this.txt_final.TabIndex = 24;
            this.txt_final.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_final_KeyPress);
            // 
            // txt_midterm
            // 
            this.txt_midterm.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_midterm.Location = new System.Drawing.Point(25, 35);
            this.txt_midterm.Name = "txt_midterm";
            this.txt_midterm.Size = new System.Drawing.Size(70, 23);
            this.txt_midterm.TabIndex = 9;
            this.txt_midterm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_midterm_KeyPress);
            // 
            // label_absence
            // 
            this.label_absence.AutoSize = true;
            this.label_absence.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_absence.Location = new System.Drawing.Point(307, 15);
            this.label_absence.Name = "label_absence";
            this.label_absence.Size = new System.Drawing.Size(74, 20);
            this.label_absence.TabIndex = 22;
            this.label_absence.Text = "출석 점수";
            // 
            // label_assignment
            // 
            this.label_assignment.AutoSize = true;
            this.label_assignment.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_assignment.Location = new System.Drawing.Point(213, 15);
            this.label_assignment.Name = "label_assignment";
            this.label_assignment.Size = new System.Drawing.Size(74, 20);
            this.label_assignment.TabIndex = 21;
            this.label_assignment.Text = "과제 점수";
            // 
            // label_final
            // 
            this.label_final.AutoSize = true;
            this.label_final.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_final.Location = new System.Drawing.Point(119, 15);
            this.label_final.Name = "label_final";
            this.label_final.Size = new System.Drawing.Size(69, 20);
            this.label_final.TabIndex = 20;
            this.label_final.Text = "기말고사";
            // 
            // label_midterm
            // 
            this.label_midterm.AutoSize = true;
            this.label_midterm.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_midterm.Location = new System.Drawing.Point(25, 15);
            this.label_midterm.Name = "label_midterm";
            this.label_midterm.Size = new System.Drawing.Size(69, 20);
            this.label_midterm.TabIndex = 19;
            this.label_midterm.Text = "중간고사";
            // 
            // ListView_grade
            // 
            this.ListView_grade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView_grade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.학번,
            this.학과,
            this.이름,
            this.점수,
            this.순위,
            this.등급});
            this.ListView_grade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListView_grade.FullRowSelect = true;
            this.ListView_grade.GridLines = true;
            this.ListView_grade.Location = new System.Drawing.Point(25, 70);
            this.ListView_grade.Name = "ListView_grade";
            this.ListView_grade.OwnerDraw = true;
            this.ListView_grade.Size = new System.Drawing.Size(450, 360);
            this.ListView_grade.TabIndex = 10;
            this.ListView_grade.UseCompatibleStateImageBehavior = false;
            this.ListView_grade.UseSelectable = true;
            this.ListView_grade.View = System.Windows.Forms.View.Details;
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
            // 점수
            // 
            this.점수.Text = "점수";
            this.점수.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.점수.Width = 70;
            // 
            // 순위
            // 
            this.순위.Text = "순위";
            this.순위.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.순위.Width = 70;
            // 
            // 등급
            // 
            this.등급.Text = "등급";
            this.등급.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.등급.Width = 70;
            // 
            // Btn_reEvaluation
            // 
            this.Btn_reEvaluation.BackColor = System.Drawing.Color.Red;
            this.Btn_reEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reEvaluation.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_reEvaluation.ForeColor = System.Drawing.Color.White;
            this.Btn_reEvaluation.Location = new System.Drawing.Point(400, 39);
            this.Btn_reEvaluation.Name = "Btn_reEvaluation";
            this.Btn_reEvaluation.Size = new System.Drawing.Size(75, 25);
            this.Btn_reEvaluation.TabIndex = 29;
            this.Btn_reEvaluation.Text = "재평가";
            this.Btn_reEvaluation.UseVisualStyleBackColor = false;
            this.Btn_reEvaluation.Click += new System.EventHandler(this.Btn_reEvaluation_Click);
            // 
            // Professor_LookupGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 510);
            this.Controls.Add(this.Btn_reEvaluation);
            this.Controls.Add(this.groupBox_insert);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.ListView_grade);
            this.Name = "Professor_LookupGrade";
            this.Text = "성적 평가";
            this.Load += new System.EventHandler(this.Professor_LookupGrade_Load);
            this.groupBox_insert.ResumeLayout(false);
            this.groupBox_insert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.GroupBox groupBox_insert;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.TextBox txt_absence;
        private System.Windows.Forms.TextBox txt_assignment;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.TextBox txt_midterm;
        private System.Windows.Forms.Label label_absence;
        private System.Windows.Forms.Label label_assignment;
        private System.Windows.Forms.Label label_final;
        private System.Windows.Forms.Label label_midterm;
        private MetroFramework.Controls.MetroListView ListView_grade;
        private System.Windows.Forms.ColumnHeader 학번;
        private System.Windows.Forms.ColumnHeader 학과;
        private System.Windows.Forms.ColumnHeader 이름;
        private System.Windows.Forms.ColumnHeader 점수;
        private System.Windows.Forms.ColumnHeader 순위;
        private System.Windows.Forms.ColumnHeader 등급;
        private System.Windows.Forms.Button Btn_reEvaluation;
    }
}