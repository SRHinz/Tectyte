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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stuCourseHist));
            this.MenuReturn = new System.Windows.Forms.Button();
            this.TermSelectorBox = new System.Windows.Forms.ComboBox();
            this.CourseDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuReturn
            // 
            this.MenuReturn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MenuReturn.Location = new System.Drawing.Point(1250, 402);
            this.MenuReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuReturn.Name = "MenuReturn";
            this.MenuReturn.Size = new System.Drawing.Size(333, 66);
            this.MenuReturn.TabIndex = 1;
            this.MenuReturn.Text = "Return to Menu";
            this.MenuReturn.UseVisualStyleBackColor = false;
            this.MenuReturn.Click += new System.EventHandler(this.MenuReturn_Click);
            // 
            // TermSelectorBox
            // 
            this.TermSelectorBox.FormattingEnabled = true;
            this.TermSelectorBox.Items.AddRange(new object[] {
            "Course History",
            "Current Courses",
            "Future Courses"});
            this.TermSelectorBox.Location = new System.Drawing.Point(1263, 53);
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
            this.CourseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CourseDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CourseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDataGrid.Location = new System.Drawing.Point(51, 53);
            this.CourseDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CourseDataGrid.Name = "CourseDataGrid";
            this.CourseDataGrid.ReadOnly = true;
            this.CourseDataGrid.RowHeadersWidth = 30;
            this.CourseDataGrid.RowTemplate.Height = 46;
            this.CourseDataGrid.Size = new System.Drawing.Size(1096, 909);
            this.CourseDataGrid.TabIndex = 4;
            // 
            // stuCourseHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 1138);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MenuReturn;
        private System.Windows.Forms.ComboBox TermSelectorBox;
        private System.Windows.Forms.DataGridView CourseDataGrid;
    }
}