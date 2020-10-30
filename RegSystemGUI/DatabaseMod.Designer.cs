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
            this.choiceCourse = new System.Windows.Forms.Button();
            this.choiceStudent = new System.Windows.Forms.Button();
            this.choiceFaculty = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // choiceCourse
            // 
            this.choiceCourse.Location = new System.Drawing.Point(123, 176);
            this.choiceCourse.Name = "choiceCourse";
            this.choiceCourse.Size = new System.Drawing.Size(277, 114);
            this.choiceCourse.TabIndex = 0;
            this.choiceCourse.Text = "Course";
            this.choiceCourse.UseVisualStyleBackColor = true;
            this.choiceCourse.Click += new System.EventHandler(this.CourseButtonClick);
            // 
            // choiceStudent
            // 
            this.choiceStudent.Location = new System.Drawing.Point(573, 176);
            this.choiceStudent.Name = "choiceStudent";
            this.choiceStudent.Size = new System.Drawing.Size(296, 114);
            this.choiceStudent.TabIndex = 1;
            this.choiceStudent.Text = "Student";
            this.choiceStudent.UseVisualStyleBackColor = true;
            this.choiceStudent.Click += new System.EventHandler(this.StudentButtonClick);
            // 
            // choiceFaculty
            // 
            this.choiceFaculty.Location = new System.Drawing.Point(1054, 176);
            this.choiceFaculty.Name = "choiceFaculty";
            this.choiceFaculty.Size = new System.Drawing.Size(273, 114);
            this.choiceFaculty.TabIndex = 2;
            this.choiceFaculty.Text = "Faculty";
            this.choiceFaculty.UseVisualStyleBackColor = true;
            this.choiceFaculty.Click += new System.EventHandler(this.FacultyButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(413, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(649, 71);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "What are you modifying?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DatabaseMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 335);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.choiceFaculty);
            this.Controls.Add(this.choiceStudent);
            this.Controls.Add(this.choiceCourse);
            this.Name = "DatabaseMod";
            this.Text = "DatabaseMod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choiceCourse;
        private System.Windows.Forms.Button choiceStudent;
        private System.Windows.Forms.Button choiceFaculty;
        private System.Windows.Forms.TextBox textBox1;
    }
}