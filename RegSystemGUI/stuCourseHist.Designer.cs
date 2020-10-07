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
            this.courseDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DropButton = new System.Windows.Forms.Button();
            this.warningBox = new System.Windows.Forms.TextBox();
            this.warningBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuReturn
            // 
            this.MenuReturn.Location = new System.Drawing.Point(1085, 343);
            this.MenuReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuReturn.Name = "MenuReturn";
            this.MenuReturn.Size = new System.Drawing.Size(333, 66);
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
            this.TermSelectorBox.Location = new System.Drawing.Point(1085, 200);
            this.TermSelectorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TermSelectorBox.Name = "TermSelectorBox";
            this.TermSelectorBox.Size = new System.Drawing.Size(180, 33);
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
            this.CourseDataGrid.Location = new System.Drawing.Point(129, 181);
            this.CourseDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CourseDataGrid.MultiSelect = false;
            this.CourseDataGrid.Name = "CourseDataGrid";
            this.CourseDataGrid.ReadOnly = true;
            this.CourseDataGrid.RowHeadersWidth = 30;
            this.CourseDataGrid.RowTemplate.Height = 46;
            this.CourseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGrid.Size = new System.Drawing.Size(810, 362);
            this.CourseDataGrid.TabIndex = 4;
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
            // courseDatabaseBindingSource
            // 
            this.courseDatabaseBindingSource.DataSource = typeof(RegSystemGUI.Program.CourseDatabase);
            // 
            // DropButton
            // 
            this.DropButton.Location = new System.Drawing.Point(1085, 467);
            this.DropButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(333, 55);
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
            this.warningBox.Location = new System.Drawing.Point(129, 136);
            this.warningBox.Name = "warningBox";
            this.warningBox.Size = new System.Drawing.Size(810, 31);
            this.warningBox.TabIndex = 6;
            this.warningBox.Text = "**Warning: There are no registered classes.**";
            this.warningBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // warningBox2
            // 
            this.warningBox2.BackColor = System.Drawing.SystemColors.Control;
            this.warningBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warningBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningBox2.Location = new System.Drawing.Point(129, 136);
            this.warningBox2.Name = "warningBox2";
            this.warningBox2.Size = new System.Drawing.Size(810, 31);
            this.warningBox2.TabIndex = 7;
            this.warningBox2.Text = "**Warning: There is a time conflict between two or more classes.**";
            // 
            // stuCourseHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 938);
            this.Controls.Add(this.warningBox2);
            this.Controls.Add(this.warningBox);
            this.Controls.Add(this.DropButton);
            this.Controls.Add(this.CourseDataGrid);
            this.Controls.Add(this.TermSelectorBox);
            this.Controls.Add(this.MenuReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "stuCourseHist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}