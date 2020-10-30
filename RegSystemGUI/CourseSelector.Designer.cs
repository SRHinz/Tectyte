namespace RegSystemGUI
{
    partial class CourseSelector
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
            this.courseModifierView = new System.Windows.Forms.DataGridView();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.delCourse = new System.Windows.Forms.Button();
            this.editCourse = new System.Windows.Forms.Button();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.courseModifierView)).BeginInit();
            this.SuspendLayout();
            // 
            // courseModifierView
            // 
            this.courseModifierView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseModifierView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.CourseTitle,
            this.Instructor,
            this.Credits,
            this.TotalSeats,
            this.AvailableSeats,
            this.TB1,
            this.TB2,
            this.TB3,
            this.TB4,
            this.TB5});
            this.courseModifierView.Location = new System.Drawing.Point(12, 12);
            this.courseModifierView.Name = "courseModifierView";
            this.courseModifierView.RowHeadersWidth = 123;
            this.courseModifierView.RowTemplate.Height = 46;
            this.courseModifierView.Size = new System.Drawing.Size(2091, 810);
            this.courseModifierView.TabIndex = 0;
            this.courseModifierView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.SystemColors.Window;
            this.searchBar.Location = new System.Drawing.Point(2130, 13);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(443, 44);
            this.searchBar.TabIndex = 1;
            this.searchBar.Text = "Search...";
            // 
            // delCourse
            // 
            this.delCourse.Location = new System.Drawing.Point(2180, 495);
            this.delCourse.Name = "delCourse";
            this.delCourse.Size = new System.Drawing.Size(351, 113);
            this.delCourse.TabIndex = 2;
            this.delCourse.Text = "Delete Course";
            this.delCourse.UseVisualStyleBackColor = true;
            // 
            // editCourse
            // 
            this.editCourse.Location = new System.Drawing.Point(2180, 653);
            this.editCourse.Name = "editCourse";
            this.editCourse.Size = new System.Drawing.Size(351, 114);
            this.editCourse.TabIndex = 3;
            this.editCourse.Text = "Edit Course Time";
            this.editCourse.UseVisualStyleBackColor = true;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 15;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 300;
            // 
            // CourseTitle
            // 
            this.CourseTitle.HeaderText = "Course Title";
            this.CourseTitle.MinimumWidth = 15;
            this.CourseTitle.Name = "CourseTitle";
            this.CourseTitle.ReadOnly = true;
            this.CourseTitle.Width = 300;
            // 
            // Instructor
            // 
            this.Instructor.HeaderText = "Instructor";
            this.Instructor.MinimumWidth = 15;
            this.Instructor.Name = "Instructor";
            this.Instructor.ReadOnly = true;
            this.Instructor.Width = 300;
            // 
            // Credits
            // 
            this.Credits.HeaderText = "Credits";
            this.Credits.MinimumWidth = 15;
            this.Credits.Name = "Credits";
            this.Credits.ReadOnly = true;
            this.Credits.Width = 300;
            // 
            // TotalSeats
            // 
            this.TotalSeats.HeaderText = "Total Seats";
            this.TotalSeats.MinimumWidth = 15;
            this.TotalSeats.Name = "TotalSeats";
            this.TotalSeats.ReadOnly = true;
            this.TotalSeats.Width = 300;
            // 
            // AvailableSeats
            // 
            this.AvailableSeats.HeaderText = "Available Seats";
            this.AvailableSeats.MinimumWidth = 15;
            this.AvailableSeats.Name = "AvailableSeats";
            this.AvailableSeats.ReadOnly = true;
            this.AvailableSeats.Width = 300;
            // 
            // TB1
            // 
            this.TB1.HeaderText = "Time Block 1";
            this.TB1.MinimumWidth = 15;
            this.TB1.Name = "TB1";
            this.TB1.ReadOnly = true;
            this.TB1.Width = 300;
            // 
            // TB2
            // 
            this.TB2.HeaderText = "Time Block 2";
            this.TB2.MinimumWidth = 15;
            this.TB2.Name = "TB2";
            this.TB2.ReadOnly = true;
            this.TB2.Width = 300;
            // 
            // TB3
            // 
            this.TB3.HeaderText = "Time Block 3";
            this.TB3.MinimumWidth = 15;
            this.TB3.Name = "TB3";
            this.TB3.ReadOnly = true;
            this.TB3.Width = 300;
            // 
            // TB4
            // 
            this.TB4.HeaderText = "Time Block 4";
            this.TB4.MinimumWidth = 15;
            this.TB4.Name = "TB4";
            this.TB4.ReadOnly = true;
            this.TB4.Width = 300;
            // 
            // TB5
            // 
            this.TB5.HeaderText = "Time Block 5";
            this.TB5.MinimumWidth = 15;
            this.TB5.Name = "TB5";
            this.TB5.ReadOnly = true;
            this.TB5.Width = 300;
            // 
            // CourseSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2585, 836);
            this.Controls.Add(this.editCourse);
            this.Controls.Add(this.delCourse);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.courseModifierView);
            this.Name = "CourseSelector";
            this.Text = "CourseSelector";
            ((System.ComponentModel.ISupportInitialize)(this.courseModifierView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView courseModifierView;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button delCourse;
        private System.Windows.Forms.Button editCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn TB1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TB2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TB3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TB4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TB5;
    }
}