
namespace ScoreForm
{
    partial class Student_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Select));
            this.Student_application = new System.Windows.Forms.Button();
            this.Student_Withdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InCourse = new System.Windows.Forms.ListView();
            this.OutCourse = new System.Windows.Forms.ListView();
            this.EndButton = new System.Windows.Forms.Button();
            this.ReNew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReNew)).BeginInit();
            this.SuspendLayout();
            // 
            // Student_application
            // 
            this.Student_application.BackColor = System.Drawing.Color.Red;
            this.Student_application.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student_application.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Student_application.ForeColor = System.Drawing.Color.White;
            this.Student_application.Location = new System.Drawing.Point(737, 86);
            this.Student_application.Name = "Student_application";
            this.Student_application.Size = new System.Drawing.Size(150, 66);
            this.Student_application.TabIndex = 8;
            this.Student_application.Text = "수강 신청";
            this.Student_application.UseVisualStyleBackColor = false;
            this.Student_application.Click += new System.EventHandler(this.Student_application_Click);
            // 
            // Student_Withdraw
            // 
            this.Student_Withdraw.BackColor = System.Drawing.Color.Red;
            this.Student_Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student_Withdraw.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Student_Withdraw.ForeColor = System.Drawing.Color.White;
            this.Student_Withdraw.Location = new System.Drawing.Point(737, 319);
            this.Student_Withdraw.Name = "Student_Withdraw";
            this.Student_Withdraw.Size = new System.Drawing.Size(150, 66);
            this.Student_Withdraw.TabIndex = 9;
            this.Student_Withdraw.Text = "수강 철회";
            this.Student_Withdraw.UseVisualStyleBackColor = false;
            this.Student_Withdraw.Click += new System.EventHandler(this.Student_Withdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "- 수강 신청 가능한 과목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "- 수강 신청한 과목";
            // 
            // InCourse
            // 
            this.InCourse.GridLines = true;
            this.InCourse.HideSelection = false;
            this.InCourse.Location = new System.Drawing.Point(23, 86);
            this.InCourse.MultiSelect = false;
            this.InCourse.Name = "InCourse";
            this.InCourse.Size = new System.Drawing.Size(690, 180);
            this.InCourse.TabIndex = 13;
            this.InCourse.UseCompatibleStateImageBehavior = false;
            this.InCourse.View = System.Windows.Forms.View.Details;
            this.InCourse.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.InCourse_ColumnWidthChanging_1);
            // 
            // OutCourse
            // 
            this.OutCourse.GridLines = true;
            this.OutCourse.HideSelection = false;
            this.OutCourse.Location = new System.Drawing.Point(23, 319);
            this.OutCourse.Name = "OutCourse";
            this.OutCourse.Size = new System.Drawing.Size(690, 180);
            this.OutCourse.TabIndex = 14;
            this.OutCourse.UseCompatibleStateImageBehavior = false;
            this.OutCourse.View = System.Windows.Forms.View.Details;
            this.OutCourse.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.OutCourse_ColumnWidthChanging);
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.Red;
            this.EndButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EndButton.ForeColor = System.Drawing.Color.White;
            this.EndButton.Location = new System.Drawing.Point(779, 453);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(99, 44);
            this.EndButton.TabIndex = 16;
            this.EndButton.Text = "닫기";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click_1);
            // 
            // ReNew
            // 
            this.ReNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReNew.Image = ((System.Drawing.Image)(resources.GetObject("ReNew.Image")));
            this.ReNew.Location = new System.Drawing.Point(683, 37);
            this.ReNew.Name = "ReNew";
            this.ReNew.Size = new System.Drawing.Size(30, 30);
            this.ReNew.TabIndex = 17;
            this.ReNew.TabStop = false;
            this.ReNew.Click += new System.EventHandler(this.ReNew_Click);
            // 
            // Student_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(901, 520);
            this.Controls.Add(this.ReNew);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.OutCourse);
            this.Controls.Add(this.InCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Student_Withdraw);
            this.Controls.Add(this.Student_application);
            this.Name = "Student_Select";
            this.Text = "수강 신청";
            ((System.ComponentModel.ISupportInitialize)(this.ReNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Student_application;
        private System.Windows.Forms.Button Student_Withdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView InCourse;
        private System.Windows.Forms.ListView OutCourse;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.PictureBox ReNew;
    }
}