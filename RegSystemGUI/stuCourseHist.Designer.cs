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
            this.courseDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DropButton = new System.Windows.Forms.Button();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuReturn
            // 
            this.MenuReturn.Location = new System.Drawing.Point(735, 166);
            this.MenuReturn.Margin = new System.Windows.Forms.Padding(1);
            this.MenuReturn.Name = "MenuReturn";
            this.MenuReturn.Size = new System.Drawing.Size(222, 42);
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
            this.TermSelectorBox.Location = new System.Drawing.Point(735, 74);
            this.TermSelectorBox.Name = "TermSelectorBox";
            this.TermSelectorBox.Size = new System.Drawing.Size(121, 24);
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
            this.CourseDataGrid.Location = new System.Drawing.Point(97, 62);
            this.CourseDataGrid.MultiSelect = false;
            this.CourseDataGrid.Name = "CourseDataGrid";
            this.CourseDataGrid.ReadOnly = true;
            this.CourseDataGrid.RowHeadersWidth = 30;
            this.CourseDataGrid.RowTemplate.Height = 46;
            this.CourseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGrid.Size = new System.Drawing.Size(540, 232);
            this.CourseDataGrid.TabIndex = 4;
            // 
            // courseDatabaseBindingSource
            // 
            this.courseDatabaseBindingSource.DataSource = typeof(RegSystemGUI.Program.CourseDatabase);
            // 
            // DropButton
            // 
            this.DropButton.Location = new System.Drawing.Point(735, 245);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(222, 35);
            this.DropButton.TabIndex = 5;
            this.DropButton.Text = "Drop";
            this.DropButton.UseVisualStyleBackColor = true;
            this.DropButton.Click += new System.EventHandler(this.DropButton_Click);
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
            // stuCourseHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 600);
            this.Controls.Add(this.DropButton);
            this.Controls.Add(this.CourseDataGrid);
            this.Controls.Add(this.TermSelectorBox);
            this.Controls.Add(this.MenuReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "stuCourseHist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}