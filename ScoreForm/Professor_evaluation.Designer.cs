
namespace ScoreForm
{
    partial class Professor_evaluation
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
            this.HomeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReviewText = new System.Windows.Forms.RichTextBox();
            this.Courseview = new System.Windows.Forms.ListView();
            this.Course = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeName
            // 
            this.HomeName.AutoSize = true;
            this.HomeName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeName.Location = new System.Drawing.Point(514, 78);
            this.HomeName.Name = "HomeName";
            this.HomeName.Size = new System.Drawing.Size(65, 20);
            this.HomeName.TabIndex = 9;
            this.HomeName.Text = "- 강의명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(514, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "- 강의평";
            // 
            // ReviewText
            // 
            this.ReviewText.Location = new System.Drawing.Point(514, 207);
            this.ReviewText.Name = "ReviewText";
            this.ReviewText.ReadOnly = true;
            this.ReviewText.Size = new System.Drawing.Size(239, 201);
            this.ReviewText.TabIndex = 10;
            this.ReviewText.Text = "";
            // 
            // Courseview
            // 
            this.Courseview.HideSelection = false;
            this.Courseview.Location = new System.Drawing.Point(23, 78);
            this.Courseview.Name = "Courseview";
            this.Courseview.Size = new System.Drawing.Size(460, 330);
            this.Courseview.TabIndex = 11;
            this.Courseview.UseCompatibleStateImageBehavior = false;
            this.Courseview.SelectedIndexChanged += new System.EventHandler(this.Courseview_SelectedIndexChanged);
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.BackColor = System.Drawing.Color.LightCoral;
            this.Course.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Course.Location = new System.Drawing.Point(514, 109);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(20, 30);
            this.Course.TabIndex = 12;
            this.Course.Text = " ";
            // 
            // Professor_evaluation
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Courseview);
            this.Controls.Add(this.ReviewText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomeName);
            this.Name = "Professor_evaluation";
            this.Text = "강의 평가 확인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HomeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ReviewText;
        private System.Windows.Forms.ListView Courseview;
        private System.Windows.Forms.Label Course;
    }
}