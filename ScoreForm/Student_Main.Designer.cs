
namespace ScoreForm
{
    partial class Student_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Main));
            this.HomePicture = new System.Windows.Forms.PictureBox();
            this.HomeName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Student_Schedule_b = new System.Windows.Forms.Button();
            this.Student_Select_b = new System.Windows.Forms.Button();
            this.Student_CheckScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePicture
            // 
            this.HomePicture.Image = ((System.Drawing.Image)(resources.GetObject("HomePicture.Image")));
            this.HomePicture.Location = new System.Drawing.Point(23, 105);
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.Size = new System.Drawing.Size(580, 320);
            this.HomePicture.TabIndex = 0;
            this.HomePicture.TabStop = false;
            // 
            // HomeName
            // 
            this.HomeName.AutoSize = true;
            this.HomeName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeName.Location = new System.Drawing.Point(23, 70);
            this.HomeName.Name = "HomeName";
            this.HomeName.Size = new System.Drawing.Size(139, 20);
            this.HomeName.TabIndex = 2;
            this.HomeName.Text = "XXX님 환영합니다!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Student_Schedule_b
            // 
            this.Student_Schedule_b.BackColor = System.Drawing.Color.Red;
            this.Student_Schedule_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student_Schedule_b.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Student_Schedule_b.ForeColor = System.Drawing.Color.White;
            this.Student_Schedule_b.Location = new System.Drawing.Point(627, 194);
            this.Student_Schedule_b.Name = "Student_Schedule_b";
            this.Student_Schedule_b.Size = new System.Drawing.Size(150, 66);
            this.Student_Schedule_b.TabIndex = 7;
            this.Student_Schedule_b.Text = "수업시간 조회";
            this.Student_Schedule_b.UseVisualStyleBackColor = false;
            this.Student_Schedule_b.Click += new System.EventHandler(this.Student_Schedule_b_Click);
            // 
            // Student_Select_b
            // 
            this.Student_Select_b.BackColor = System.Drawing.Color.Red;
            this.Student_Select_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student_Select_b.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Student_Select_b.ForeColor = System.Drawing.Color.White;
            this.Student_Select_b.Location = new System.Drawing.Point(627, 275);
            this.Student_Select_b.Name = "Student_Select_b";
            this.Student_Select_b.Size = new System.Drawing.Size(150, 66);
            this.Student_Select_b.TabIndex = 8;
            this.Student_Select_b.Text = "수강 신청 및 조회";
            this.Student_Select_b.UseVisualStyleBackColor = false;
            this.Student_Select_b.Click += new System.EventHandler(this.Student_Select_b_Click);
            // 
            // Student_CheckScore
            // 
            this.Student_CheckScore.BackColor = System.Drawing.Color.Red;
            this.Student_CheckScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student_CheckScore.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Student_CheckScore.ForeColor = System.Drawing.Color.White;
            this.Student_CheckScore.Location = new System.Drawing.Point(627, 359);
            this.Student_CheckScore.Name = "Student_CheckScore";
            this.Student_CheckScore.Size = new System.Drawing.Size(150, 66);
            this.Student_CheckScore.TabIndex = 9;
            this.Student_CheckScore.Text = "성적 조회";
            this.Student_CheckScore.UseVisualStyleBackColor = false;
            this.Student_CheckScore.Click += new System.EventHandler(this.Student_CheckScore_Click);
            // 
            // Student_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Student_CheckScore);
            this.Controls.Add(this.Student_Select_b);
            this.Controls.Add(this.Student_Schedule_b);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HomeName);
            this.Controls.Add(this.HomePicture);
            this.Name = "Student_Main";
            this.Text = "경북대학교";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HomePicture;
        private System.Windows.Forms.Label HomeName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Student_Schedule_b;
        private System.Windows.Forms.Button Student_Select_b;
        private System.Windows.Forms.Button Student_CheckScore;
    }
}

