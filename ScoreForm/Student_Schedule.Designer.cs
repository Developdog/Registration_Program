
namespace ScoreForm
{
    partial class Student_Schedule
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
            this.Student_CheckScore = new System.Windows.Forms.Button();
            this.Courseview = new System.Windows.Forms.ListView();
            this.Refresh = new System.Windows.Forms.Button();
            this.Exlabel = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Student_CheckScore
            // 
            this.Student_CheckScore.BackColor = System.Drawing.Color.Red;
            this.Student_CheckScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student_CheckScore.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Student_CheckScore.ForeColor = System.Drawing.Color.White;
            this.Student_CheckScore.Location = new System.Drawing.Point(650, 358);
            this.Student_CheckScore.Name = "Student_CheckScore";
            this.Student_CheckScore.Size = new System.Drawing.Size(138, 65);
            this.Student_CheckScore.TabIndex = 10;
            this.Student_CheckScore.Text = "닫기";
            this.Student_CheckScore.UseVisualStyleBackColor = false;
            this.Student_CheckScore.Click += new System.EventHandler(this.Student_CheckScore_Click);
            // 
            // Courseview
            // 
            this.Courseview.GridLines = true;
            this.Courseview.HideSelection = false;
            this.Courseview.Location = new System.Drawing.Point(23, 63);
            this.Courseview.Name = "Courseview";
            this.Courseview.Size = new System.Drawing.Size(610, 360);
            this.Courseview.TabIndex = 11;
            this.Courseview.UseCompatibleStateImageBehavior = false;
            this.Courseview.View = System.Windows.Forms.View.Details;
            this.Courseview.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Courseview_ColumnWidthChanging);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(549, 15);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(84, 42);
            this.Refresh.TabIndex = 12;
            this.Refresh.Text = " 조회하기";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Exlabel
            // 
            this.Exlabel.AutoSize = true;
            this.Exlabel.Location = new System.Drawing.Point(248, 20);
            this.Exlabel.Name = "Exlabel";
            this.Exlabel.Size = new System.Drawing.Size(0, 15);
            this.Exlabel.TabIndex = 13;
            // 
            // Semester
            // 
            this.Semester.Location = new System.Drawing.Point(427, 26);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(100, 23);
            this.Semester.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "수업 시간표 조회";
            // 
            // Student_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Exlabel);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Courseview);
            this.Controls.Add(this.Student_CheckScore);
            this.Name = "Student_Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Student_CheckScore;
        private System.Windows.Forms.ListView Courseview;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label Exlabel;
        private System.Windows.Forms.TextBox Semester;
        private System.Windows.Forms.Label label1;
    }
}