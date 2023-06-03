
namespace ScoreForm
{
    partial class Student_CheckScore
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
            this.Student_ = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Courseview = new System.Windows.Forms.ListView();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Student_
            // 
            this.Student_.BackColor = System.Drawing.Color.Red;
            this.Student_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student_.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Student_.ForeColor = System.Drawing.Color.White;
            this.Student_.Location = new System.Drawing.Point(627, 76);
            this.Student_.Name = "Student_";
            this.Student_.Size = new System.Drawing.Size(150, 66);
            this.Student_.TabIndex = 14;
            this.Student_.Text = "성적 확인하기";
            this.Student_.UseVisualStyleBackColor = false;
            this.Student_.Click += new System.EventHandler(this.Student__Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(23, 23);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(410, 20);
            this.Label.TabIndex = 17;
            this.Label.Text = "* 성적 확인은 강의 평가를 전부 끝낸 뒤 확인이 가능합니다.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "- 더블 클릭해서 강의 평가를 완료해주세요.";
            // 
            // Courseview
            // 
            this.Courseview.FullRowSelect = true;
            this.Courseview.GridLines = true;
            this.Courseview.HideSelection = false;
            this.Courseview.Location = new System.Drawing.Point(23, 76);
            this.Courseview.Name = "Courseview";
            this.Courseview.Size = new System.Drawing.Size(580, 330);
            this.Courseview.TabIndex = 19;
            this.Courseview.UseCompatibleStateImageBehavior = false;
            this.Courseview.View = System.Windows.Forms.View.Details;
            this.Courseview.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.Courseview_ColumnWidthChanging);
            this.Courseview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Courseview_MouseDoubleClick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(678, 362);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(99, 44);
            this.Exit.TabIndex = 20;
            this.Exit.Text = "닫기";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // Student_CheckScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Courseview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Student_);
            this.Name = "Student_CheckScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Student_;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView Courseview;
        private System.Windows.Forms.Button Exit;
    }
}