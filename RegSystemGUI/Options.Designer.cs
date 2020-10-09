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
            this.viewAdvisees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewCoursesButton
            // 
            this.ViewCoursesButton.Location = new System.Drawing.Point(214, 181);
            this.ViewCoursesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewCoursesButton.Name = "ViewCoursesButton";
            this.ViewCoursesButton.Size = new System.Drawing.Size(202, 73);
            this.ViewCoursesButton.TabIndex = 0;
            this.ViewCoursesButton.Text = "View Courses";
            this.ViewCoursesButton.UseVisualStyleBackColor = true;
            this.ViewCoursesButton.Click += new System.EventHandler(this.viewCourse_Click);
            // 
            // CourseHisButton
            // 
            this.CourseHisButton.Location = new System.Drawing.Point(486, 181);
            this.CourseHisButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CourseHisButton.Name = "CourseHisButton";
            this.CourseHisButton.Size = new System.Drawing.Size(202, 73);
            this.CourseHisButton.TabIndex = 1;
            this.CourseHisButton.Text = "View Course History";
            this.CourseHisButton.UseVisualStyleBackColor = true;
            this.CourseHisButton.Click += new System.EventHandler(this.CourseHisButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(356, 327);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(177, 73);
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
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewAdvisees
            // 
            this.viewAdvisees.Location = new System.Drawing.Point(486, 181);
            this.viewAdvisees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewAdvisees.Name = "viewAdvisees";
            this.viewAdvisees.Size = new System.Drawing.Size(202, 73);
            this.viewAdvisees.TabIndex = 4;
            this.viewAdvisees.Text = "View Advisees";
            this.viewAdvisees.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 581);
            this.Controls.Add(this.viewAdvisees);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.CourseHisButton);
            this.Controls.Add(this.ViewCoursesButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewCoursesButton;
        private System.Windows.Forms.Button CourseHisButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button viewAdvisees;
    }
}