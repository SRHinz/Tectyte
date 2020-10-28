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
            this.copyrightBox = new System.Windows.Forms.TextBox();
            this.studentList = new System.Windows.Forms.ListBox();
            this.facultyList = new System.Windows.Forms.ListBox();
            this.MenuReturn = new System.Windows.Forms.Button();
            this.changeAdv = new System.Windows.Forms.Button();
            this.searchStudents = new System.Windows.Forms.Label();
            this.searchFaculty = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // copyrightBox
            // 
            this.copyrightBox.BackColor = System.Drawing.SystemColors.Control;
            this.copyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightBox.Location = new System.Drawing.Point(-393, 1089);
            this.copyrightBox.Margin = new System.Windows.Forms.Padding(5);
            this.copyrightBox.Name = "copyrightBox";
            this.copyrightBox.Size = new System.Drawing.Size(443, 24);
            this.copyrightBox.TabIndex = 12;
            this.copyrightBox.Text = "this software is property of tectyte ©2020";
            this.copyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 25;
            this.studentList.Location = new System.Drawing.Point(392, 118);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(325, 329);
            this.studentList.TabIndex = 13;
            // 
            // facultyList
            // 
            this.facultyList.FormattingEnabled = true;
            this.facultyList.ItemHeight = 25;
            this.facultyList.Location = new System.Drawing.Point(392, 543);
            this.facultyList.Name = "facultyList";
            this.facultyList.Size = new System.Drawing.Size(325, 329);
            this.facultyList.TabIndex = 14;
            // 
            // MenuReturn
            // 
            this.MenuReturn.Location = new System.Drawing.Point(872, 398);
            this.MenuReturn.Name = "MenuReturn";
            this.MenuReturn.Size = new System.Drawing.Size(406, 73);
            this.MenuReturn.TabIndex = 15;
            this.MenuReturn.Text = "Return to Menu";
            this.MenuReturn.UseVisualStyleBackColor = true;
            this.MenuReturn.Click += new System.EventHandler(this.MenuReturn_Click);
            // 
            // changeAdv
            // 
            this.changeAdv.Location = new System.Drawing.Point(872, 525);
            this.changeAdv.Name = "changeAdv";
            this.changeAdv.Size = new System.Drawing.Size(406, 73);
            this.changeAdv.TabIndex = 16;
            this.changeAdv.Text = "Change Student Advisor";
            this.changeAdv.UseVisualStyleBackColor = true;
            // 
            // searchStudents
            // 
            this.searchStudents.AutoSize = true;
            this.searchStudents.Location = new System.Drawing.Point(45, 67);
            this.searchStudents.Name = "searchStudents";
            this.searchStudents.Size = new System.Drawing.Size(321, 25);
            this.searchStudents.TabIndex = 17;
            this.searchStudents.Text = "Search Students by Last Name: ";
            // 
            // searchFaculty
            // 
            this.searchFaculty.AutoSize = true;
            this.searchFaculty.Location = new System.Drawing.Point(45, 508);
            this.searchFaculty.Name = "searchFaculty";
            this.searchFaculty.Size = new System.Drawing.Size(306, 25);
            this.searchFaculty.TabIndex = 18;
            this.searchFaculty.Text = "Search Faculty by Last Name: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 31);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "placeholder";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(392, 502);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 31);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "placeholder";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(446, 950);
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
            this.textBox3.Location = new System.Drawing.Point(478, 958);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(443, 24);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "this software is property of tectyte ©2020";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 996);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchFaculty);
            this.Controls.Add(this.searchStudents);
            this.Controls.Add(this.changeAdv);
            this.Controls.Add(this.MenuReturn);
            this.Controls.Add(this.facultyList);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.copyrightBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "changeAdvisor";
            this.Text = "Change Advisor";
            this.Load += new System.EventHandler(this.changeAdvisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox copyrightBox;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.ListBox facultyList;
        private System.Windows.Forms.Button MenuReturn;
        private System.Windows.Forms.Button changeAdv;
        private System.Windows.Forms.Label searchStudents;
        private System.Windows.Forms.Label searchFaculty;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}