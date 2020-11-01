namespace RegSystemGUI
{
    partial class DatabaseMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseMod));
            this.choiceCourse = new System.Windows.Forms.Button();
            this.choiceStudent = new System.Windows.Forms.Button();
            this.choiceFaculty = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyrightBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // choiceCourse
            // 
            this.choiceCourse.Location = new System.Drawing.Point(78, 119);
            this.choiceCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choiceCourse.Name = "choiceCourse";
            this.choiceCourse.Size = new System.Drawing.Size(175, 77);
            this.choiceCourse.TabIndex = 0;
            this.choiceCourse.Text = "Course";
            this.choiceCourse.UseVisualStyleBackColor = true;
            this.choiceCourse.Click += new System.EventHandler(this.CourseButtonClick);
            // 
            // choiceStudent
            // 
            this.choiceStudent.Location = new System.Drawing.Point(362, 119);
            this.choiceStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choiceStudent.Name = "choiceStudent";
            this.choiceStudent.Size = new System.Drawing.Size(187, 77);
            this.choiceStudent.TabIndex = 1;
            this.choiceStudent.Text = "Student";
            this.choiceStudent.UseVisualStyleBackColor = true;
            this.choiceStudent.Click += new System.EventHandler(this.StudentButtonClick);
            // 
            // choiceFaculty
            // 
            this.choiceFaculty.Location = new System.Drawing.Point(666, 119);
            this.choiceFaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choiceFaculty.Name = "choiceFaculty";
            this.choiceFaculty.Size = new System.Drawing.Size(172, 77);
            this.choiceFaculty.TabIndex = 2;
            this.choiceFaculty.Text = "Faculty";
            this.choiceFaculty.UseVisualStyleBackColor = true;
            this.choiceFaculty.Click += new System.EventHandler(this.FacultyButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(230, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(467, 43);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "What are you modifying?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 248);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // copyrightBox
            // 
            this.copyrightBox.BackColor = System.Drawing.SystemColors.Control;
            this.copyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightBox.Location = new System.Drawing.Point(258, 256);
            this.copyrightBox.Margin = new System.Windows.Forms.Padding(5);
            this.copyrightBox.Name = "copyrightBox";
            this.copyrightBox.Size = new System.Drawing.Size(443, 24);
            this.copyrightBox.TabIndex = 14;
            this.copyrightBox.Text = "this software is property of tectyte ©2020";
            this.copyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DatabaseMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 294);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyrightBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.choiceFaculty);
            this.Controls.Add(this.choiceStudent);
            this.Controls.Add(this.choiceCourse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DatabaseMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Modifier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choiceCourse;
        private System.Windows.Forms.Button choiceStudent;
        private System.Windows.Forms.Button choiceFaculty;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox copyrightBox;
    }
}