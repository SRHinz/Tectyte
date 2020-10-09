namespace RegSystemGUI
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
            this.MenuReturn = new System.Windows.Forms.Button();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBlock1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBlock2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBlock3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBlock4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBlock5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseDataGrid
            // 
            this.CourseDataGrid.AllowUserToAddRows = false;
            this.CourseDataGrid.AllowUserToDeleteRows = false;
            this.CourseDataGrid.AllowUserToResizeColumns = false;
            this.CourseDataGrid.AllowUserToResizeRows = false;
            this.CourseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CourseDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CourseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
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
            this.CourseDataGrid.Name = "CourseDataGrid";
            this.CourseDataGrid.ReadOnly = true;
            this.CourseDataGrid.RowHeadersWidth = 30;
            this.CourseDataGrid.RowTemplate.Height = 46;
            this.CourseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGrid.Size = new System.Drawing.Size(1261, 818);
            this.CourseDataGrid.TabIndex = 3;
            this.CourseDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseDataGrid_CellContentClick);
            // 
            // MenuReturn
            // 
            this.MenuReturn.Location = new System.Drawing.Point(1374, 411);
            this.MenuReturn.Margin = new System.Windows.Forms.Padding(2);
            this.MenuReturn.Name = "MenuReturn";
            this.MenuReturn.Size = new System.Drawing.Size(333, 65);
            this.MenuReturn.TabIndex = 4;
            this.MenuReturn.Text = "Return to Menu";
            this.MenuReturn.UseVisualStyleBackColor = true;
            this.MenuReturn.Click += new System.EventHandler(this.MenuReturn_Click_1);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(1374, 569);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(333, 73);
            this.AddCourseButton.TabIndex = 5;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Instructor
            // 
            this.Instructor.HeaderText = "Instructor";
            this.Instructor.MinimumWidth = 6;
            this.Instructor.Name = "Instructor";
            this.Instructor.ReadOnly = true;
            // 
            // TotalSeats
            // 
            this.TotalSeats.HeaderText = "Total Seats";
            this.TotalSeats.MinimumWidth = 6;
            this.TotalSeats.Name = "TotalSeats";
            this.TotalSeats.ReadOnly = true;
            // 
            // OpenSeats
            // 
            this.OpenSeats.HeaderText = "Open Seats";
            this.OpenSeats.MinimumWidth = 6;
            this.OpenSeats.Name = "OpenSeats";
            this.OpenSeats.ReadOnly = true;
            // 
            // CreditsCol
            // 
            this.CreditsCol.HeaderText = "Credits";
            this.CreditsCol.MinimumWidth = 6;
            this.CreditsCol.Name = "CreditsCol";
            this.CreditsCol.ReadOnly = true;
            // 
            // tBlock1
            // 
            this.tBlock1.HeaderText = "Time Block 1";
            this.tBlock1.MinimumWidth = 6;
            this.tBlock1.Name = "tBlock1";
            this.tBlock1.ReadOnly = true;
            // 
            // tBlock2
            // 
            this.tBlock2.HeaderText = "Time Block 2";
            this.tBlock2.MinimumWidth = 6;
            this.tBlock2.Name = "tBlock2";
            this.tBlock2.ReadOnly = true;
            // 
            // tBlock3
            // 
            this.tBlock3.HeaderText = "Time Block 3";
            this.tBlock3.MinimumWidth = 6;
            this.tBlock3.Name = "tBlock3";
            this.tBlock3.ReadOnly = true;
            // 
            // tBlock4
            // 
            this.tBlock4.HeaderText = "Time Block 4";
            this.tBlock4.MinimumWidth = 6;
            this.tBlock4.Name = "tBlock4";
            this.tBlock4.ReadOnly = true;
            // 
            // tBlock5
            // 
            this.tBlock5.HeaderText = "Time Block 5";
            this.tBlock5.MinimumWidth = 6;
            this.tBlock5.Name = "tBlock5";
            this.tBlock5.ReadOnly = true;
            // 
            // CourseViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1806, 886);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.MenuReturn);
            this.Controls.Add(this.CourseDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Courses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView CourseDataGrid;
        private System.Windows.Forms.Button MenuReturn;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBlock1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBlock2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBlock3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBlock4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBlock5;
    }
}