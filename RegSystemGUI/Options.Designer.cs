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
            this.SuspendLayout();
            // 
            // ViewCoursesButton
            // 
            this.ViewCoursesButton.Location = new System.Drawing.Point(104, 69);
            this.ViewCoursesButton.Name = "ViewCoursesButton";
            this.ViewCoursesButton.Size = new System.Drawing.Size(135, 47);
            this.ViewCoursesButton.TabIndex = 0;
            this.ViewCoursesButton.Text = "View Courses";
            this.ViewCoursesButton.UseVisualStyleBackColor = true;
            this.ViewCoursesButton.Click += new System.EventHandler(this.viewCourse_Click);
            // 
            // CourseHisButton
            // 
            this.CourseHisButton.Location = new System.Drawing.Point(293, 69);
            this.CourseHisButton.Name = "CourseHisButton";
            this.CourseHisButton.Size = new System.Drawing.Size(118, 47);
            this.CourseHisButton.TabIndex = 1;
            this.CourseHisButton.Text = "View Course History";
            this.CourseHisButton.UseVisualStyleBackColor = true;
            this.CourseHisButton.Click += new System.EventHandler(this.CourseHisButton_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 372);
            this.Controls.Add(this.CourseHisButton);
            this.Controls.Add(this.ViewCoursesButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Options";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewCoursesButton;
        private System.Windows.Forms.Button CourseHisButton;
    }
}