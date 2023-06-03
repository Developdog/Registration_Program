
namespace ScoreForm
{
    partial class Professor_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professor_Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeName = new System.Windows.Forms.Label();
            this.HomePicture = new System.Windows.Forms.PictureBox();
            this.Professor_OpenCourse_b = new System.Windows.Forms.Button();
            this.Professor_LookupCourse_b = new System.Windows.Forms.Button();
            this.Professor_evaluation_b = new System.Windows.Forms.Button();
            this.Professor_LookupStudent_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // HomeName
            // 
            this.HomeName.AutoSize = true;
            this.HomeName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeName.Location = new System.Drawing.Point(23, 71);
            this.HomeName.Name = "HomeName";
            this.HomeName.Size = new System.Drawing.Size(174, 20);
            this.HomeName.TabIndex = 8;
            this.HomeName.Text = "XXX 교수님 환영합니다!";
            // 
            // HomePicture
            // 
            this.HomePicture.Image = ((System.Drawing.Image)(resources.GetObject("HomePicture.Image")));
            this.HomePicture.Location = new System.Drawing.Point(23, 106);
            this.HomePicture.Name = "HomePicture";
            this.HomePicture.Size = new System.Drawing.Size(580, 320);
            this.HomePicture.TabIndex = 7;
            this.HomePicture.TabStop = false;
            // 
            // Professor_OpenCourse_b
            // 
            this.Professor_OpenCourse_b.BackColor = System.Drawing.Color.Red;
            this.Professor_OpenCourse_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Professor_OpenCourse_b.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Professor_OpenCourse_b.ForeColor = System.Drawing.Color.White;
            this.Professor_OpenCourse_b.Location = new System.Drawing.Point(627, 193);
            this.Professor_OpenCourse_b.Name = "Professor_OpenCourse_b";
            this.Professor_OpenCourse_b.Size = new System.Drawing.Size(150, 47);
            this.Professor_OpenCourse_b.TabIndex = 14;
            this.Professor_OpenCourse_b.Text = "강의 개설";
            this.Professor_OpenCourse_b.UseVisualStyleBackColor = false;
            this.Professor_OpenCourse_b.Click += new System.EventHandler(this.Professor_OpenCourse_b_Click);
            // 
            // Professor_LookupCourse_b
            // 
            this.Professor_LookupCourse_b.BackColor = System.Drawing.Color.Red;
            this.Professor_LookupCourse_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Professor_LookupCourse_b.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Professor_LookupCourse_b.ForeColor = System.Drawing.Color.White;
            this.Professor_LookupCourse_b.Location = new System.Drawing.Point(627, 255);
            this.Professor_LookupCourse_b.Name = "Professor_LookupCourse_b";
            this.Professor_LookupCourse_b.Size = new System.Drawing.Size(150, 47);
            this.Professor_LookupCourse_b.TabIndex = 14;
            this.Professor_LookupCourse_b.Text = "담당 강의 조회";
            this.Professor_LookupCourse_b.UseVisualStyleBackColor = false;
            this.Professor_LookupCourse_b.Click += new System.EventHandler(this.Professor_LookupCourse_b_Click);
            // 
            // Professor_evaluation_b
            // 
            this.Professor_evaluation_b.BackColor = System.Drawing.Color.Red;
            this.Professor_evaluation_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Professor_evaluation_b.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Professor_evaluation_b.ForeColor = System.Drawing.Color.White;
            this.Professor_evaluation_b.Location = new System.Drawing.Point(627, 380);
            this.Professor_evaluation_b.Name = "Professor_evaluation_b";
            this.Professor_evaluation_b.Size = new System.Drawing.Size(150, 47);
            this.Professor_evaluation_b.TabIndex = 14;
            this.Professor_evaluation_b.Text = "강의 평가 확인";
            this.Professor_evaluation_b.UseVisualStyleBackColor = false;
            this.Professor_evaluation_b.Click += new System.EventHandler(this.Professor_evaluation_b_Click);
            // 
            // Professor_LookupStudent_b
            // 
            this.Professor_LookupStudent_b.BackColor = System.Drawing.Color.Red;
            this.Professor_LookupStudent_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Professor_LookupStudent_b.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Professor_LookupStudent_b.ForeColor = System.Drawing.Color.White;
            this.Professor_LookupStudent_b.Location = new System.Drawing.Point(627, 317);
            this.Professor_LookupStudent_b.Name = "Professor_LookupStudent_b";
            this.Professor_LookupStudent_b.Size = new System.Drawing.Size(150, 47);
            this.Professor_LookupStudent_b.TabIndex = 14;
            this.Professor_LookupStudent_b.Text = "강의별 정보 조회";
            this.Professor_LookupStudent_b.UseVisualStyleBackColor = false;
            this.Professor_LookupStudent_b.Click += new System.EventHandler(this.Professor_LookupStudent_b_Click);
            // 
            // Professor_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Professor_OpenCourse_b);
            this.Controls.Add(this.Professor_LookupCourse_b);
            this.Controls.Add(this.Professor_LookupStudent_b);
            this.Controls.Add(this.Professor_evaluation_b);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HomeName);
            this.Controls.Add(this.HomePicture);
            this.Name = "Professor_Main";
            this.Text = "경북대학교";
            this.Load += new System.EventHandler(this.Professor_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HomeName;
        private System.Windows.Forms.PictureBox HomePicture;
        private System.Windows.Forms.Button Professor_OpenCourse_b;
        private System.Windows.Forms.Button Professor_LookupCourse_b;
        private System.Windows.Forms.Button Professor_evaluation_b;
        private System.Windows.Forms.Button Professor_LookupStudent_b;
    }
}