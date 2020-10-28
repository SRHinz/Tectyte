namespace RegSystemGUI
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.ViewCoursesButton = new System.Windows.Forms.Button();
            this.CourseHisButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyrightBox = new System.Windows.Forms.TextBox();
            this.viewAdvisees = new System.Windows.Forms.Button();
            this.AdminStuHisButton = new System.Windows.Forms.Button();
            this.changeAdvisor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewCoursesButton
            // 
            this.ViewCoursesButton.Location = new System.Drawing.Point(152, 181);
            this.ViewCoursesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ViewCoursesButton.Name = "ViewCoursesButton";
            this.ViewCoursesButton.Size = new System.Drawing.Size(202, 73);
            this.ViewCoursesButton.TabIndex = 0;
            this.ViewCoursesButton.Text = "View Courses";
            this.ViewCoursesButton.UseVisualStyleBackColor = true;
            this.ViewCoursesButton.Click += new System.EventHandler(this.viewCourse_Click);
            // 
            // CourseHisButton
            // 
            this.CourseHisButton.Location = new System.Drawing.Point(364, 266);
            this.CourseHisButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CourseHisButton.Name = "CourseHisButton";
            this.CourseHisButton.Size = new System.Drawing.Size(176, 73);
            this.CourseHisButton.TabIndex = 1;
            this.CourseHisButton.Text = "View Course History";
            this.CourseHisButton.UseVisualStyleBackColor = true;
            this.CourseHisButton.Click += new System.EventHandler(this.CourseHisButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(364, 351);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(176, 73);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(228, 539);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // copyrightBox
            // 
            this.copyrightBox.BackColor = System.Drawing.SystemColors.Control;
            this.copyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightBox.Location = new System.Drawing.Point(258, 544);
            this.copyrightBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyrightBox.Name = "copyrightBox";
            this.copyrightBox.Size = new System.Drawing.Size(416, 24);
            this.copyrightBox.TabIndex = 8;
            this.copyrightBox.Text = "this software is property of tectyte ©2020";
            this.copyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewAdvisees
            // 
            this.viewAdvisees.Location = new System.Drawing.Point(550, 181);
            this.viewAdvisees.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.viewAdvisees.Name = "viewAdvisees";
            this.viewAdvisees.Size = new System.Drawing.Size(176, 73);
            this.viewAdvisees.TabIndex = 1;
            this.viewAdvisees.Text = "View Advisees";
            this.viewAdvisees.UseVisualStyleBackColor = true;
            this.viewAdvisees.Click += new System.EventHandler(this.viewAdvisees_Click);
            // 
            // AdminStuHisButton
            // 
            this.AdminStuHisButton.Location = new System.Drawing.Point(364, 181);
            this.AdminStuHisButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AdminStuHisButton.Name = "AdminStuHisButton";
            this.AdminStuHisButton.Size = new System.Drawing.Size(176, 73);
            this.AdminStuHisButton.TabIndex = 9;
            this.AdminStuHisButton.Text = "View Student History";
            this.AdminStuHisButton.UseVisualStyleBackColor = true;
            this.AdminStuHisButton.Visible = false;
            // 
            // changeAdvisor
            // 
            this.changeAdvisor.Location = new System.Drawing.Point(152, 266);
            this.changeAdvisor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changeAdvisor.Name = "changeAdvisor";
            this.changeAdvisor.Size = new System.Drawing.Size(202, 73);
            this.changeAdvisor.TabIndex = 10;
            this.changeAdvisor.Text = "Change Advisor";
            this.changeAdvisor.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 581);
            this.Controls.Add(this.changeAdvisor);
            this.Controls.Add(this.AdminStuHisButton);
            this.Controls.Add(this.viewAdvisees);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyrightBox);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.CourseHisButton);
            this.Controls.Add(this.ViewCoursesButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewCoursesButton;
        private System.Windows.Forms.Button CourseHisButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox copyrightBox;
        private System.Windows.Forms.Button viewAdvisees;
        private System.Windows.Forms.Button AdminStuHisButton;
        private System.Windows.Forms.Button changeAdvisor;
    }
}