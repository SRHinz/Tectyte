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
            this.ViewCoursesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewCoursesButton
            // 
            this.ViewCoursesButton.Location = new System.Drawing.Point(247, 160);
            this.ViewCoursesButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ViewCoursesButton.Name = "ViewCoursesButton";
            this.ViewCoursesButton.Size = new System.Drawing.Size(321, 109);
            this.ViewCoursesButton.TabIndex = 0;
            this.ViewCoursesButton.Text = "View Courses";
            this.ViewCoursesButton.UseVisualStyleBackColor = true;
            this.ViewCoursesButton.Click += new System.EventHandler(this.viewCourse_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 860);
            this.Controls.Add(this.ViewCoursesButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Options";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewCoursesButton;
    }
}