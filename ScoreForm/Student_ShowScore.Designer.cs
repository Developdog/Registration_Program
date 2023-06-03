
namespace ScoreForm
{
    partial class Student_ShowScore
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
            this.Scoreview = new System.Windows.Forms.ListView();
            this.FormClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Scoreview
            // 
            this.Scoreview.HideSelection = false;
            this.Scoreview.Location = new System.Drawing.Point(23, 72);
            this.Scoreview.Name = "Scoreview";
            this.Scoreview.Size = new System.Drawing.Size(350, 280);
            this.Scoreview.TabIndex = 0;
            this.Scoreview.UseCompatibleStateImageBehavior = false;
            this.Scoreview.View = System.Windows.Forms.View.Details;
            this.Scoreview.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Scoreview_ColumnWidthChanging);
            // 
            // FormClose
            // 
            this.FormClose.BackColor = System.Drawing.Color.Red;
            this.FormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormClose.ForeColor = System.Drawing.Color.White;
            this.FormClose.Location = new System.Drawing.Point(274, 374);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(99, 44);
            this.FormClose.TabIndex = 15;
            this.FormClose.Text = "닫기";
            this.FormClose.UseVisualStyleBackColor = false;
            this.FormClose.Click += new System.EventHandler(this.FormClose_Click);
            // 
            // Student_ShowScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.FormClose);
            this.Controls.Add(this.Scoreview);
            this.Name = "Student_ShowScore";
            this.Text = "성적 확인";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Scoreview;
        private System.Windows.Forms.Button FormClose;
    }
}