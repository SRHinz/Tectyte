namespace RegSystemGUI
{
    partial class changeAdvisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeAdvisor));
            this.MenuReturn = new System.Windows.Forms.Button();
            this.changeAdv = new System.Windows.Forms.Button();
            this.searchStudents = new System.Windows.Forms.Label();
            this.searchFaculty = new System.Windows.Forms.Label();
            this.studentSearchBox = new System.Windows.Forms.TextBox();
            this.facultySearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.studentDatagrid = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDatagrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuReturn
            // 
            this.MenuReturn.Location = new System.Drawing.Point(974, 455);
            this.MenuReturn.Name = "MenuReturn";
            this.MenuReturn.Size = new System.Drawing.Size(406, 73);
            this.MenuReturn.TabIndex = 15;
            this.MenuReturn.Text = "Return to Menu";
            this.MenuReturn.UseVisualStyleBackColor = true;
            this.MenuReturn.Click += new System.EventHandler(this.MenuReturn_Click);
            // 
            // changeAdv
            // 
            this.changeAdv.Location = new System.Drawing.Point(974, 582);
            this.changeAdv.Name = "changeAdv";
            this.changeAdv.Size = new System.Drawing.Size(406, 73);
            this.changeAdv.TabIndex = 16;
            this.changeAdv.Text = "Change Student Advisor";
            this.changeAdv.UseVisualStyleBackColor = true;
            // 
            // searchStudents
            // 
            this.searchStudents.AutoSize = true;
            this.searchStudents.Location = new System.Drawing.Point(48, 67);
            this.searchStudents.Name = "searchStudents";
            this.searchStudents.Size = new System.Drawing.Size(321, 25);
            this.searchStudents.TabIndex = 17;
            this.searchStudents.Text = "Search Students by Last Name: ";
            // 
            // searchFaculty
            // 
            this.searchFaculty.AutoSize = true;
            this.searchFaculty.Location = new System.Drawing.Point(48, 526);
            this.searchFaculty.Name = "searchFaculty";
            this.searchFaculty.Size = new System.Drawing.Size(306, 25);
            this.searchFaculty.TabIndex = 18;
            this.searchFaculty.Text = "Search Faculty by Last Name: ";
            // 
            // studentSearchBox
            // 
            this.studentSearchBox.Location = new System.Drawing.Point(395, 67);
            this.studentSearchBox.Name = "studentSearchBox";
            this.studentSearchBox.Size = new System.Drawing.Size(486, 31);
            this.studentSearchBox.TabIndex = 19;
            this.studentSearchBox.Text = "placeholder";
            this.studentSearchBox.TextChanged += new System.EventHandler(this.studentSearchBox_TextChanged);
            // 
            // facultySearchBox
            // 
            this.facultySearchBox.Location = new System.Drawing.Point(395, 526);
            this.facultySearchBox.Name = "facultySearchBox";
            this.facultySearchBox.Size = new System.Drawing.Size(486, 31);
            this.facultySearchBox.TabIndex = 20;
            this.facultySearchBox.Text = "placeholder";
            this.facultySearchBox.TextChanged += new System.EventHandler(this.facultySearchBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(477, 984);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(509, 992);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(443, 24);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "this software is property of tectyte ©2020";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studentDatagrid
            // 
            this.studentDatagrid.AllowUserToAddRows = false;
            this.studentDatagrid.AllowUserToDeleteRows = false;
            this.studentDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.studentDatagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.studentDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Username});
            this.studentDatagrid.Location = new System.Drawing.Point(395, 106);
            this.studentDatagrid.Margin = new System.Windows.Forms.Padding(5);
            this.studentDatagrid.Name = "studentDatagrid";
            this.studentDatagrid.ReadOnly = true;
            this.studentDatagrid.RowHeadersWidth = 4;
            this.studentDatagrid.RowTemplate.Height = 24;
            this.studentDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentDatagrid.Size = new System.Drawing.Size(486, 375);
            this.studentDatagrid.TabIndex = 23;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // facultyDatagrid
            // 
            this.facultyDatagrid.AllowUserToAddRows = false;
            this.facultyDatagrid.AllowUserToDeleteRows = false;
            this.facultyDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facultyDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.facultyDatagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.facultyDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.facultyDatagrid.Location = new System.Drawing.Point(395, 565);
            this.facultyDatagrid.Margin = new System.Windows.Forms.Padding(5);
            this.facultyDatagrid.Name = "facultyDatagrid";
            this.facultyDatagrid.ReadOnly = true;
            this.facultyDatagrid.RowHeadersWidth = 4;
            this.facultyDatagrid.RowTemplate.Height = 24;
            this.facultyDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.facultyDatagrid.Size = new System.Drawing.Size(486, 375);
            this.facultyDatagrid.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Username";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // changeAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 1030);
            this.Controls.Add(this.facultyDatagrid);
            this.Controls.Add(this.studentDatagrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.facultySearchBox);
            this.Controls.Add(this.studentSearchBox);
            this.Controls.Add(this.searchFaculty);
            this.Controls.Add(this.searchStudents);
            this.Controls.Add(this.changeAdv);
            this.Controls.Add(this.MenuReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "changeAdvisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Advisor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.changeAdvisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MenuReturn;
        private System.Windows.Forms.Button changeAdv;
        private System.Windows.Forms.Label searchStudents;
        private System.Windows.Forms.Label searchFaculty;
        private System.Windows.Forms.TextBox studentSearchBox;
        private System.Windows.Forms.TextBox facultySearchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView studentDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridView facultyDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}