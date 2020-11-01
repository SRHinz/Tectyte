﻿namespace RegSystemGUI
{
    partial class studentsEnrolled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentsEnrolled));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyrightBox = new System.Windows.Forms.TextBox();
            this.enrolledStudentList = new System.Windows.Forms.ListView();
            this.MenuReturn = new System.Windows.Forms.Button();
            this.courseReturn = new System.Windows.Forms.Button();
            this.noEnrolledBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 793);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // copyrightBox
            // 
            this.copyrightBox.BackColor = System.Drawing.SystemColors.Control;
            this.copyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightBox.Location = new System.Drawing.Point(360, 800);
            this.copyrightBox.Name = "copyrightBox";
            this.copyrightBox.Size = new System.Drawing.Size(416, 24);
            this.copyrightBox.TabIndex = 8;
            this.copyrightBox.Text = "this software is property of tectyte ©2020";
            this.copyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enrolledStudentList
            // 
            this.enrolledStudentList.HideSelection = false;
            this.enrolledStudentList.Location = new System.Drawing.Point(50, 45);
            this.enrolledStudentList.Margin = new System.Windows.Forms.Padding(5);
            this.enrolledStudentList.MultiSelect = false;
            this.enrolledStudentList.Name = "enrolledStudentList";
            this.enrolledStudentList.Size = new System.Drawing.Size(535, 679);
            this.enrolledStudentList.TabIndex = 11;
            this.enrolledStudentList.UseCompatibleStateImageBehavior = false;
            this.enrolledStudentList.View = System.Windows.Forms.View.List;
            // 
            // MenuReturn
            // 
            this.MenuReturn.Location = new System.Drawing.Point(649, 257);
            this.MenuReturn.Name = "MenuReturn";
            this.MenuReturn.Size = new System.Drawing.Size(406, 73);
            this.MenuReturn.TabIndex = 12;
            this.MenuReturn.Text = "Return to Menu";
            this.MenuReturn.UseVisualStyleBackColor = true;
            this.MenuReturn.Click += new System.EventHandler(this.MenuReturn_Click);
            // 
            // courseReturn
            // 
            this.courseReturn.Location = new System.Drawing.Point(649, 420);
            this.courseReturn.Name = "courseReturn";
            this.courseReturn.Size = new System.Drawing.Size(406, 73);
            this.courseReturn.TabIndex = 13;
            this.courseReturn.Text = "Return to My Courses";
            this.courseReturn.UseVisualStyleBackColor = true;
            this.courseReturn.Click += new System.EventHandler(this.courseReturn_Click);
            // 
            // noEnrolledBox
            // 
            this.noEnrolledBox.BackColor = System.Drawing.SystemColors.Control;
            this.noEnrolledBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noEnrolledBox.Location = new System.Drawing.Point(50, 12);
            this.noEnrolledBox.Name = "noEnrolledBox";
            this.noEnrolledBox.Size = new System.Drawing.Size(539, 24);
            this.noEnrolledBox.TabIndex = 14;
            this.noEnrolledBox.Text = "**No students are currently registered for this course.**";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(751, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Course: ";
            // 
            // courseBox
            // 
            this.courseBox.BackColor = System.Drawing.SystemColors.Control;
            this.courseBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBox.Location = new System.Drawing.Point(874, 12);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(221, 31);
            this.courseBox.TabIndex = 16;
            this.courseBox.Text = "placeholder";
            // 
            // studentsEnrolled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 836);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noEnrolledBox);
            this.Controls.Add(this.courseReturn);
            this.Controls.Add(this.MenuReturn);
            this.Controls.Add(this.enrolledStudentList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyrightBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "studentsEnrolled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Enrolled";
            this.Load += new System.EventHandler(this.studentsEnrolled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox copyrightBox;
        private System.Windows.Forms.ListView enrolledStudentList;
        private System.Windows.Forms.Button MenuReturn;
        private System.Windows.Forms.Button courseReturn;
        private System.Windows.Forms.TextBox noEnrolledBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseBox;
    }
}