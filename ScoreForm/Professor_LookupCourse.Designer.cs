
namespace ScoreForm
{
    partial class Professor_LookupCourse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professor_LookupCourse));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ListView_Schedule = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.월요일 = new System.Windows.Forms.ColumnHeader();
            this.화요일 = new System.Windows.Forms.ColumnHeader();
            this.수요일 = new System.Windows.Forms.ColumnHeader();
            this.목요일 = new System.Windows.Forms.ColumnHeader();
            this.금요일 = new System.Windows.Forms.ColumnHeader();
            this.ReNew = new System.Windows.Forms.PictureBox();
            this.comboBox_semester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReNew)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 40);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ListView_Schedule
            // 
            this.ListView_Schedule.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListView_Schedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView_Schedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.월요일,
            this.화요일,
            this.수요일,
            this.목요일,
            this.금요일});
            this.ListView_Schedule.GridLines = true;
            this.ListView_Schedule.HideSelection = false;
            this.ListView_Schedule.Location = new System.Drawing.Point(25, 70);
            this.ListView_Schedule.Name = "ListView_Schedule";
            this.ListView_Schedule.Size = new System.Drawing.Size(560, 440);
            this.ListView_Schedule.SmallImageList = this.imageList1;
            this.ListView_Schedule.TabIndex = 7;
            this.ListView_Schedule.UseCompatibleStateImageBehavior = false;
            this.ListView_Schedule.View = System.Windows.Forms.View.Details;
            this.ListView_Schedule.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListView_Schedule_ColumnWidthChanging);
            this.ListView_Schedule.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_Schedule_ItemSelectionChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // 월요일
            // 
            this.월요일.Text = "월요일";
            this.월요일.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.월요일.Width = 100;
            // 
            // 화요일
            // 
            this.화요일.Text = "화요일";
            this.화요일.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.화요일.Width = 100;
            // 
            // 수요일
            // 
            this.수요일.Text = "수요일";
            this.수요일.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.수요일.Width = 100;
            // 
            // 목요일
            // 
            this.목요일.Text = "목요일";
            this.목요일.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.목요일.Width = 100;
            // 
            // 금요일
            // 
            this.금요일.Text = "금요일";
            this.금요일.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.금요일.Width = 100;
            // 
            // ReNew
            // 
            this.ReNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReNew.Image = ((System.Drawing.Image)(resources.GetObject("ReNew.Image")));
            this.ReNew.Location = new System.Drawing.Point(555, 34);
            this.ReNew.Name = "ReNew";
            this.ReNew.Size = new System.Drawing.Size(30, 30);
            this.ReNew.TabIndex = 9;
            this.ReNew.TabStop = false;
            this.ReNew.Click += new System.EventHandler(this.ReNew_Click);
            // 
            // comboBox_semester
            // 
            this.comboBox_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_semester.FormattingEnabled = true;
            this.comboBox_semester.Items.AddRange(new object[] {
            "2021년 2학기",
            "2021년 1학기",
            "2020년 2학기",
            "2020년 1학기",
            "2019년 2학기",
            "2019년 1학기",
            "2018년 2학기",
            "2018년 1학기",
            "2017년 2학기",
            "2017년 1학기"});
            this.comboBox_semester.Location = new System.Drawing.Point(449, 41);
            this.comboBox_semester.Name = "comboBox_semester";
            this.comboBox_semester.Size = new System.Drawing.Size(100, 23);
            this.comboBox_semester.TabIndex = 10;
            this.comboBox_semester.TextChanged += new System.EventHandler(this.comboBox_semester_TextChanged);
            // 
            // Professor_LookupCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 535);
            this.Controls.Add(this.comboBox_semester);
            this.Controls.Add(this.ReNew);
            this.Controls.Add(this.ListView_Schedule);
            this.Name = "Professor_LookupCourse";
            this.Text = "담당 수업 조회";
            this.Load += new System.EventHandler(this.Professor_LookupCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView ListView_Schedule;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader 월요일;
        private System.Windows.Forms.ColumnHeader 화요일;
        private System.Windows.Forms.ColumnHeader 수요일;
        private System.Windows.Forms.ColumnHeader 목요일;
        private System.Windows.Forms.ColumnHeader 금요일;
        private System.Windows.Forms.PictureBox ReNew;
        private System.Windows.Forms.ComboBox comboBox_semester;
    }
}