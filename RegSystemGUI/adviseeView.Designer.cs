namespace RegSystemGUI
{
    partial class adviseeView
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
            this.AdviseeViewGrid = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Courses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AdviseeViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdviseeViewGrid
            // 
            this.AdviseeViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AdviseeViewGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AdviseeViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdviseeViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Courses,
            this.Term,
            this.Credit,
            this.Grade,
            this.TimeBlock1,
            this.TimeBlock2,
            this.TimeBlock3,
            this.TimeBlock4,
            this.TimeBlock5});
            this.AdviseeViewGrid.Location = new System.Drawing.Point(5, 6);
            this.AdviseeViewGrid.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.AdviseeViewGrid.Name = "AdviseeViewGrid";
            this.AdviseeViewGrid.ReadOnly = true;
            this.AdviseeViewGrid.RowHeadersWidth = 123;
            this.AdviseeViewGrid.RowTemplate.Height = 46;
            this.AdviseeViewGrid.Size = new System.Drawing.Size(1028, 397);
            this.AdviseeViewGrid.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--select--",
            "Course History",
            "Current Courses",
            "Future Courses"});
            this.comboBox1.Location = new System.Drawing.Point(1096, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Current Term";
            // 
            // Courses
            // 
            this.Courses.HeaderText = "Courses";
            this.Courses.MinimumWidth = 6;
            this.Courses.Name = "Courses";
            this.Courses.ReadOnly = true;
            this.Courses.Width = 89;
            // 
            // Term
            // 
            this.Term.HeaderText = "Term";
            this.Term.MinimumWidth = 6;
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            this.Term.Width = 70;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.MinimumWidth = 6;
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Width = 74;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 77;
            // 
            // TimeBlock1
            // 
            this.TimeBlock1.HeaderText = "Time Block 1";
            this.TimeBlock1.MinimumWidth = 6;
            this.TimeBlock1.Name = "TimeBlock1";
            this.TimeBlock1.ReadOnly = true;
            this.TimeBlock1.Width = 118;
            // 
            // TimeBlock2
            // 
            this.TimeBlock2.HeaderText = "Time Block 2";
            this.TimeBlock2.MinimumWidth = 6;
            this.TimeBlock2.Name = "TimeBlock2";
            this.TimeBlock2.ReadOnly = true;
            this.TimeBlock2.Width = 118;
            // 
            // TimeBlock3
            // 
            this.TimeBlock3.HeaderText = "Time Block 3";
            this.TimeBlock3.MinimumWidth = 6;
            this.TimeBlock3.Name = "TimeBlock3";
            this.TimeBlock3.ReadOnly = true;
            this.TimeBlock3.Width = 118;
            // 
            // TimeBlock4
            // 
            this.TimeBlock4.HeaderText = "Time Block 4";
            this.TimeBlock4.MinimumWidth = 6;
            this.TimeBlock4.Name = "TimeBlock4";
            this.TimeBlock4.ReadOnly = true;
            this.TimeBlock4.Width = 118;
            // 
            // TimeBlock5
            // 
            this.TimeBlock5.HeaderText = "Time Block 5";
            this.TimeBlock5.MinimumWidth = 6;
            this.TimeBlock5.Name = "TimeBlock5";
            this.TimeBlock5.ReadOnly = true;
            this.TimeBlock5.Width = 118;
            // 
            // adviseeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1507, 492);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AdviseeViewGrid);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "adviseeView";
            this.Text = "adviseeView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.AdviseeViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AdviseeViewGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Courses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock5;
    }
}