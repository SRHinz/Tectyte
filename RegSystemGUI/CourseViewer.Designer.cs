namespace RegSystemGUI
{
    partial class CourseViewer
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
            this.CourseDisplays = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CourseDisplays
            // 
            this.CourseDisplays.AcceptsTab = true;
            this.CourseDisplays.Location = new System.Drawing.Point(12, 66);
            this.CourseDisplays.Multiline = true;
            this.CourseDisplays.Name = "CourseDisplays";
            this.CourseDisplays.ReadOnly = true;
            this.CourseDisplays.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CourseDisplays.Size = new System.Drawing.Size(1909, 808);
            this.CourseDisplays.TabIndex = 0;
            this.CourseDisplays.WordWrap = false;
            this.CourseDisplays.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1937, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2282, 886);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CourseDisplays);
            this.Name = "CourseViewer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CourseDisplays;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}