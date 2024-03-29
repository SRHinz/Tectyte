﻿namespace RegSystemGUI
{
    partial class CourseViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseViewer));
            this.CourseDataGrid = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBlock1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBlock2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBlock3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBlock4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBlock5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuReturn = new System.Windows.Forms.Button();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyrightBox = new System.Windows.Forms.TextBox();
            this.FacultyCourseSelector = new System.Windows.Forms.ComboBox();
            this.studentsEnrolled = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseDataGrid
            // 
            this.CourseDataGrid.AllowUserToAddRows = false;
            this.CourseDataGrid.AllowUserToDeleteRows = false;
            this.CourseDataGrid.AllowUserToResizeColumns = false;
            this.CourseDataGrid.AllowUserToResizeRows = false;
            this.CourseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CourseDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CourseDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CourseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.CourseTitle,
            this.Instructor,
            this.TotalSeats,
            this.OpenSeats,
            this.CreditsCol,
            this.tBlock1,
            this.tBlock2,
            this.tBlock3,
            this.tBlock4,
            this.tBlock5});
            this.CourseDataGrid.Location = new System.Drawing.Point(14, 56);
            this.CourseDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CourseDataGrid.Name = "CourseDataGrid";
            this.CourseDataGrid.ReadOnly = true;
            this.CourseDataGrid.RowHeadersWidth = 30;
            this.CourseDataGrid.RowTemplate.Height = 46;
            this.CourseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGrid.Size = new System.Drawing.Size(1261, 818);
            this.CourseDataGrid.TabIndex = 3;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 123;
            // 
            // CourseTitle
            // 
            this.CourseTitle.HeaderText = "Course Title";
            this.CourseTitle.MinimumWidth = 10;
            this.CourseTitle.Name = "CourseTitle";
            this.CourseTitle.ReadOnly = true;
            this.CourseTitle.Width = 113;
            // 
            // Instructor
            // 
            this.Instructor.HeaderText = "Instructor";
            this.Instructor.MinimumWidth = 6;
            this.Instructor.Name = "Instructor";
            this.Instructor.ReadOnly = true;
            this.Instructor.Width = 96;
            // 
            // TotalSeats
            // 
            this.TotalSeats.HeaderText = "Total Seats";
            this.TotalSeats.MinimumWidth = 6;
            this.TotalSeats.Name = "TotalSeats";
            this.TotalSeats.ReadOnly = true;
            this.TotalSeats.Width = 109;
            // 
            // OpenSeats
            // 
            this.OpenSeats.HeaderText = "Open Seats";
            this.OpenSeats.MinimumWidth = 6;
            this.OpenSeats.Name = "OpenSeats";
            this.OpenSeats.ReadOnly = true;
            this.OpenSeats.Width = 112;
            // 
            // CreditsCol
            // 
            this.CreditsCol.HeaderText = "Credits";
            this.CreditsCol.MinimumWidth = 6;
            this.CreditsCol.Name = "CreditsCol";
            this.CreditsCol.ReadOnly = true;
            this.CreditsCol.Width = 81;
            // 
            // tBlock1
            // 
            this.tBlock1.HeaderText = "Time Block 1";
            this.tBlock1.MinimumWidth = 6;
            this.tBlock1.Name = "tBlock1";
            this.tBlock1.ReadOnly = true;
            this.tBlock1.Width = 118;
            // 
            // tBlock2
            // 
            this.tBlock2.HeaderText = "Time Block 2";
            this.tBlock2.MinimumWidth = 6;
            this.tBlock2.Name = "tBlock2";
            this.tBlock2.ReadOnly = true;
            this.tBlock2.Width = 118;
            // 
            // tBlock3
            // 
            this.tBlock3.HeaderText = "Time Block 3";
            this.tBlock3.MinimumWidth = 6;
            this.tBlock3.Name = "tBlock3";
            this.tBlock3.ReadOnly = true;
            this.tBlock3.Width = 118;
            // 
            // tBlock4
            // 
            this.tBlock4.HeaderText = "Time Block 4";
            this.tBlock4.MinimumWidth = 6;
            this.tBlock4.Name = "tBlock4";
            this.tBlock4.ReadOnly = true;
            this.tBlock4.Width = 118;
            // 
            // tBlock5
            // 
            this.tBlock5.HeaderText = "Time Block 5";
            this.tBlock5.MinimumWidth = 6;
            this.tBlock5.Name = "tBlock5";
            this.tBlock5.ReadOnly = true;
            this.tBlock5.Width = 118;
            // 
            // MenuReturn
            // 
            this.MenuReturn.Location = new System.Drawing.Point(1374, 411);
            this.MenuReturn.Margin = new System.Windows.Forms.Padding(2);
            this.MenuReturn.Name = "MenuReturn";
            this.MenuReturn.Size = new System.Drawing.Size(332, 65);
            this.MenuReturn.TabIndex = 4;
            this.MenuReturn.Text = "Return to Menu";
            this.MenuReturn.UseVisualStyleBackColor = true;
            this.MenuReturn.Click += new System.EventHandler(this.MenuReturn_Click_1);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(1374, 518);
            this.AddCourseButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(332, 72);
            this.AddCourseButton.TabIndex = 5;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(680, 921);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // copyrightBox
            // 
            this.copyrightBox.BackColor = System.Drawing.SystemColors.Control;
            this.copyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightBox.Location = new System.Drawing.Point(710, 928);
            this.copyrightBox.Margin = new System.Windows.Forms.Padding(2);
            this.copyrightBox.Name = "copyrightBox";
            this.copyrightBox.Size = new System.Drawing.Size(416, 15);
            this.copyrightBox.TabIndex = 8;
            this.copyrightBox.Text = "this software is property of tectyte ©2020";
            this.copyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FacultyCourseSelector
            // 
            this.FacultyCourseSelector.FormattingEnabled = true;
            this.FacultyCourseSelector.Items.AddRange(new object[] {
            "All Courses",
            "My Courses"});
            this.FacultyCourseSelector.Location = new System.Drawing.Point(1368, 56);
            this.FacultyCourseSelector.Margin = new System.Windows.Forms.Padding(2);
            this.FacultyCourseSelector.Name = "FacultyCourseSelector";
            this.FacultyCourseSelector.Size = new System.Drawing.Size(164, 24);
            this.FacultyCourseSelector.TabIndex = 9;
            this.FacultyCourseSelector.SelectedIndexChanged += new System.EventHandler(this.FacultyCourseSelector_SelectedIndexChanged);
            // 
            // studentsEnrolled
            // 
            this.studentsEnrolled.Location = new System.Drawing.Point(1374, 622);
            this.studentsEnrolled.Margin = new System.Windows.Forms.Padding(2);
            this.studentsEnrolled.Name = "studentsEnrolled";
            this.studentsEnrolled.Size = new System.Drawing.Size(332, 72);
            this.studentsEnrolled.TabIndex = 10;
            this.studentsEnrolled.Text = "View Enrolled Students";
            this.studentsEnrolled.UseVisualStyleBackColor = true;
            this.studentsEnrolled.Click += new System.EventHandler(this.studentsEnrolled_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(14, 38);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(170, 17);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Search by Course Name: ";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(179, 29);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(464, 22);
            this.searchBox.TabIndex = 13;
            this.searchBox.Text = "placeholder";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1439, 702);
            this.ControlBox = false;
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.studentsEnrolled);
            this.Controls.Add(this.FacultyCourseSelector);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyrightBox);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.MenuReturn);
            this.Controls.Add(this.CourseDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CourseViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Courses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CourseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CourseDataGrid;
        private System.Windows.Forms.Button MenuReturn;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBlock1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBlock2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBlock3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBlock4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBlock5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox copyrightBox;
        private System.Windows.Forms.ComboBox FacultyCourseSelector;
        private System.Windows.Forms.Button studentsEnrolled;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
    }
}