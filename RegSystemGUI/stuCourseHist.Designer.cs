using System;

namespace RegSystemGUI
{
    partial class stuCourseHist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stuCourseHist));
            this.MenuReturn = new System.Windows.Forms.Button();
            this.TermSelectorBox = new System.Windows.Forms.ComboBox();
            this.CourseDataGrid = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropButton = new System.Windows.Forms.Button();
            this.warningBox = new System.Windows.Forms.TextBox();
            this.warningBox2 = new System.Windows.Forms.TextBox();
            this.courseSchedule = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyrightBox = new System.Windows.Forms.TextBox();
            this.GPABox = new System.Windows.Forms.TextBox();
            this.GPALabel = new System.Windows.Forms.Label();
            this.CreditsEarnedBox = new System.Windows.Forms.TextBox();
            this.NumCreditsEarnedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuReturn
            // 
            this.MenuReturn.Location = new System.Drawing.Point(1570, 382);
            this.MenuReturn.Margin = new System.Windows.Forms.Padding(2);
            this.MenuReturn.Name = "MenuReturn";
            this.MenuReturn.Size = new System.Drawing.Size(354, 67);
            this.MenuReturn.TabIndex = 1;
            this.MenuReturn.Text = "Return to Menu";
            this.MenuReturn.UseVisualStyleBackColor = true;
            this.MenuReturn.Click += new System.EventHandler(this.MenuReturn_Click);
            // 
            // TermSelectorBox
            // 
            this.TermSelectorBox.FormattingEnabled = true;
            this.TermSelectorBox.Items.AddRange(new object[] {
            "--select--",
            "Course History",
            "Current Courses",
            "Future Courses"});
            this.TermSelectorBox.Location = new System.Drawing.Point(1570, 237);
            this.TermSelectorBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TermSelectorBox.Name = "TermSelectorBox";
            this.TermSelectorBox.Size = new System.Drawing.Size(191, 33);
            this.TermSelectorBox.TabIndex = 2;
            this.TermSelectorBox.SelectedIndexChanged += new System.EventHandler(this.TermSelectorBox_SelectedIndexChanged);
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
            this.Course,
            this.Term,
            this.Credits,
            this.Grade});
            this.CourseDataGrid.Location = new System.Drawing.Point(34, 179);
            this.CourseDataGrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CourseDataGrid.MultiSelect = false;
            this.CourseDataGrid.Name = "CourseDataGrid";
            this.CourseDataGrid.ReadOnly = true;
            this.CourseDataGrid.RowHeadersWidth = 30;
            this.CourseDataGrid.RowTemplate.Height = 46;
            this.CourseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGrid.Size = new System.Drawing.Size(1498, 458);
            this.CourseDataGrid.TabIndex = 4;
            this.CourseDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseDataGrid_CellContentClick);
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Term
            // 
            this.Term.HeaderText = "Term";
            this.Term.MinimumWidth = 6;
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            // 
            // Credits
            // 
            this.Credits.HeaderText = "Credits";
            this.Credits.MinimumWidth = 6;
            this.Credits.Name = "Credits";
            this.Credits.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // DropButton
            // 
            this.DropButton.Location = new System.Drawing.Point(1570, 510);
            this.DropButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(354, 58);
            this.DropButton.TabIndex = 5;
            this.DropButton.Text = "Drop";
            this.DropButton.UseVisualStyleBackColor = true;
            this.DropButton.Click += new System.EventHandler(this.DropButton_Click);
            // 
            // warningBox
            // 
            this.warningBox.BackColor = System.Drawing.SystemColors.Control;
            this.warningBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warningBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningBox.Location = new System.Drawing.Point(136, 139);
            this.warningBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.warningBox.Name = "warningBox";
            this.warningBox.Size = new System.Drawing.Size(864, 31);
            this.warningBox.TabIndex = 6;
            this.warningBox.Text = "**Warning: There are no registered classes.**";
            this.warningBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // warningBox2
            // 
            this.warningBox2.BackColor = System.Drawing.SystemColors.Control;
            this.warningBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warningBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningBox2.Location = new System.Drawing.Point(136, 139);
            this.warningBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.warningBox2.Name = "warningBox2";
            this.warningBox2.Size = new System.Drawing.Size(864, 31);
            this.warningBox2.TabIndex = 7;
            this.warningBox2.Text = "**Warning: There is a time conflict between two or more classes.**";
            // 
            // courseSchedule
            // 
            this.courseSchedule.AllowUserToAddRows = false;
            this.courseSchedule.AllowUserToDeleteRows = false;
            this.courseSchedule.AllowUserToResizeColumns = false;
            this.courseSchedule.AllowUserToResizeRows = false;
            this.courseSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.courseSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.courseSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.courseSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cTerm,
            this.Credit,
            this.dataGridViewTextBoxColumn4,
            this.TimeBlock1,
            this.TimeBlock2,
            this.TimeBlock3,
            this.TimeBlock4,
            this.TimeBlock5});
            this.courseSchedule.Location = new System.Drawing.Point(34, 179);
            this.courseSchedule.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.courseSchedule.MultiSelect = false;
            this.courseSchedule.Name = "courseSchedule";
            this.courseSchedule.ReadOnly = true;
            this.courseSchedule.RowHeadersWidth = 30;
            this.courseSchedule.RowTemplate.Height = 46;
            this.courseSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseSchedule.Size = new System.Drawing.Size(1498, 458);
            this.courseSchedule.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Course";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 126;
            // 
            // cTerm
            // 
            this.cTerm.HeaderText = "Term";
            this.cTerm.MinimumWidth = 10;
            this.cTerm.Name = "cTerm";
            this.cTerm.ReadOnly = true;
            this.cTerm.Width = 106;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.MinimumWidth = 10;
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Width = 114;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 116;
            // 
            // TimeBlock1
            // 
            this.TimeBlock1.HeaderText = "Time Block 1";
            this.TimeBlock1.MinimumWidth = 10;
            this.TimeBlock1.Name = "TimeBlock1";
            this.TimeBlock1.ReadOnly = true;
            this.TimeBlock1.Width = 181;
            // 
            // TimeBlock2
            // 
            this.TimeBlock2.HeaderText = "Time Block 2";
            this.TimeBlock2.MinimumWidth = 10;
            this.TimeBlock2.Name = "TimeBlock2";
            this.TimeBlock2.ReadOnly = true;
            this.TimeBlock2.Width = 181;
            // 
            // TimeBlock3
            // 
            this.TimeBlock3.HeaderText = "Time Block 3";
            this.TimeBlock3.MinimumWidth = 10;
            this.TimeBlock3.Name = "TimeBlock3";
            this.TimeBlock3.ReadOnly = true;
            this.TimeBlock3.Width = 181;
            // 
            // TimeBlock4
            // 
            this.TimeBlock4.HeaderText = "Time Block 4";
            this.TimeBlock4.MinimumWidth = 10;
            this.TimeBlock4.Name = "TimeBlock4";
            this.TimeBlock4.ReadOnly = true;
            this.TimeBlock4.Width = 181;
            // 
            // TimeBlock5
            // 
            this.TimeBlock5.HeaderText = "Time Block 5";
            this.TimeBlock5.MinimumWidth = 10;
            this.TimeBlock5.Name = "TimeBlock5";
            this.TimeBlock5.ReadOnly = true;
            this.TimeBlock5.Width = 181;
            // 
            // courseDatabaseBindingSource
            // 
            this.courseDatabaseBindingSource.DataSource = typeof(RegSystemGUI.Program.CourseDatabase);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 906);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // copyrightBox
            // 
            this.copyrightBox.BackColor = System.Drawing.SystemColors.Control;
            this.copyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightBox.Location = new System.Drawing.Point(776, 912);
            this.copyrightBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.copyrightBox.Name = "copyrightBox";
            this.copyrightBox.Size = new System.Drawing.Size(443, 24);
            this.copyrightBox.TabIndex = 10;
            this.copyrightBox.Text = "this software is property of tectyte ©2020";
            this.copyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GPABox
            // 
            this.GPABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPABox.Location = new System.Drawing.Point(371, 698);
            this.GPABox.Margin = new System.Windows.Forms.Padding(6);
            this.GPABox.Name = "GPABox";
            this.GPABox.ReadOnly = true;
            this.GPABox.Size = new System.Drawing.Size(209, 24);
            this.GPABox.TabIndex = 13;
            this.GPABox.TextChanged += new System.EventHandler(this.GPABox_TextChanged);
            // 
            // GPALabel
            // 
            this.GPALabel.AutoSize = true;
            this.GPALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GPALabel.Location = new System.Drawing.Point(280, 691);
            this.GPALabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GPALabel.Name = "GPALabel";
            this.GPALabel.Size = new System.Drawing.Size(79, 31);
            this.GPALabel.TabIndex = 14;
            this.GPALabel.Text = "GPA:";
            this.GPALabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreditsEarnedBox
            // 
            this.CreditsEarnedBox.BackColor = System.Drawing.SystemColors.Control;
            this.CreditsEarnedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreditsEarnedBox.Location = new System.Drawing.Point(371, 662);
            this.CreditsEarnedBox.Margin = new System.Windows.Forms.Padding(2);
            this.CreditsEarnedBox.Name = "CreditsEarnedBox";
            this.CreditsEarnedBox.Size = new System.Drawing.Size(209, 24);
            this.CreditsEarnedBox.TabIndex = 15;
            // 
            // NumCreditsEarnedLabel
            // 
            this.NumCreditsEarnedLabel.AutoSize = true;
            this.NumCreditsEarnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NumCreditsEarnedLabel.Location = new System.Drawing.Point(23, 656);
            this.NumCreditsEarnedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NumCreditsEarnedLabel.Name = "NumCreditsEarnedLabel";
            this.NumCreditsEarnedLabel.Size = new System.Drawing.Size(336, 31);
            this.NumCreditsEarnedLabel.TabIndex = 16;
            this.NumCreditsEarnedLabel.Text = "Number of Credits Earned:";
            // 
            // stuCourseHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1957, 854);
            this.Controls.Add(this.NumCreditsEarnedLabel);
            this.Controls.Add(this.CreditsEarnedBox);
            this.Controls.Add(this.GPALabel);
            this.Controls.Add(this.GPABox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyrightBox);
            this.Controls.Add(this.courseSchedule);
            this.Controls.Add(this.warningBox2);
            this.Controls.Add(this.warningBox);
            this.Controls.Add(this.DropButton);
            this.Controls.Add(this.CourseDataGrid);
            this.Controls.Add(this.TermSelectorBox);
            this.Controls.Add(this.MenuReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "stuCourseHist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GPABox_TextChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button MenuReturn;
        private System.Windows.Forms.ComboBox TermSelectorBox;
        private System.Windows.Forms.DataGridView CourseDataGrid;
        private System.Windows.Forms.BindingSource courseDatabaseBindingSource;
        private System.Windows.Forms.Button DropButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.TextBox warningBox;
        private System.Windows.Forms.TextBox warningBox2;
        private System.Windows.Forms.DataGridView courseSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox copyrightBox;
        private System.Windows.Forms.TextBox GPABox;
        private System.Windows.Forms.Label GPALabel;
        private System.Windows.Forms.TextBox CreditsEarnedBox;
        private System.Windows.Forms.Label NumCreditsEarnedLabel;
    }
}