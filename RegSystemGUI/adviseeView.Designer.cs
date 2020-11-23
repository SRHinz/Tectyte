namespace RegSystemGUI
{
    partial class adviseeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adviseeView));
            this.AdviseeViewGrid = new System.Windows.Forms.DataGridView();
            this.Courses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBlock5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Return_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyrightBox = new System.Windows.Forms.TextBox();
            this.NumCreditsEarnedLabel = new System.Windows.Forms.Label();
            this.CreditsEarnedBox = new System.Windows.Forms.TextBox();
            this.GPALabel = new System.Windows.Forms.Label();
            this.GPABox = new System.Windows.Forms.TextBox();
            this.warningBox2 = new System.Windows.Forms.TextBox();
            this.warningBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdviseeViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdviseeViewGrid
            // 
            this.AdviseeViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdviseeViewGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AdviseeViewGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AdviseeViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdviseeViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Courses,
            this.Term,
            this.Credit,
            this.Grade,
            this.TimeBlock1,
            this.TimeBlock2,
            this.TimeBlock3,
            this.TimeBlock4,
            this.TimeBlock5});
            this.AdviseeViewGrid.Location = new System.Drawing.Point(12, 56);
            this.AdviseeViewGrid.Margin = new System.Windows.Forms.Padding(1);
            this.AdviseeViewGrid.Name = "AdviseeViewGrid";
            this.AdviseeViewGrid.ReadOnly = true;
            this.AdviseeViewGrid.RowHeadersWidth = 30;
            this.AdviseeViewGrid.RowTemplate.Height = 46;
            this.AdviseeViewGrid.Size = new System.Drawing.Size(1028, 398);
            this.AdviseeViewGrid.TabIndex = 0;
            // 
            // Courses
            // 
            this.Courses.HeaderText = "Courses";
            this.Courses.MinimumWidth = 6;
            this.Courses.Name = "Courses";
            this.Courses.ReadOnly = true;
            // 
            // Term
            // 
            this.Term.HeaderText = "Term";
            this.Term.MinimumWidth = 6;
            this.Term.Name = "Term";
            this.Term.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.MinimumWidth = 6;
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // TimeBlock1
            // 
            this.TimeBlock1.HeaderText = "Time Block 1";
            this.TimeBlock1.MinimumWidth = 6;
            this.TimeBlock1.Name = "TimeBlock1";
            this.TimeBlock1.ReadOnly = true;
            // 
            // TimeBlock2
            // 
            this.TimeBlock2.HeaderText = "Time Block 2";
            this.TimeBlock2.MinimumWidth = 6;
            this.TimeBlock2.Name = "TimeBlock2";
            this.TimeBlock2.ReadOnly = true;
            // 
            // TimeBlock3
            // 
            this.TimeBlock3.HeaderText = "Time Block 3";
            this.TimeBlock3.MinimumWidth = 6;
            this.TimeBlock3.Name = "TimeBlock3";
            this.TimeBlock3.ReadOnly = true;
            // 
            // TimeBlock4
            // 
            this.TimeBlock4.HeaderText = "Time Block 4";
            this.TimeBlock4.MinimumWidth = 6;
            this.TimeBlock4.Name = "TimeBlock4";
            this.TimeBlock4.ReadOnly = true;
            // 
            // TimeBlock5
            // 
            this.TimeBlock5.HeaderText = "Time Block 5";
            this.TimeBlock5.MinimumWidth = 6;
            this.TimeBlock5.Name = "TimeBlock5";
            this.TimeBlock5.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Course History",
            "Current Courses",
            "Future Courses"});
            this.comboBox1.Location = new System.Drawing.Point(1104, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(1104, 102);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(139, 36);
            this.Return_Button.TabIndex = 2;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.return_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 548);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // copyrightBox
            // 
            this.copyrightBox.BackColor = System.Drawing.SystemColors.Control;
            this.copyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightBox.Location = new System.Drawing.Point(502, 552);
            this.copyrightBox.Margin = new System.Windows.Forms.Padding(2);
            this.copyrightBox.Name = "copyrightBox";
            this.copyrightBox.Size = new System.Drawing.Size(278, 15);
            this.copyrightBox.TabIndex = 10;
            this.copyrightBox.Text = "this software is property of tectyte ©2020";
            this.copyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumCreditsEarnedLabel
            // 
            this.NumCreditsEarnedLabel.AutoSize = true;
            this.NumCreditsEarnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NumCreditsEarnedLabel.Location = new System.Drawing.Point(22, 470);
            this.NumCreditsEarnedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumCreditsEarnedLabel.Name = "NumCreditsEarnedLabel";
            this.NumCreditsEarnedLabel.Size = new System.Drawing.Size(209, 20);
            this.NumCreditsEarnedLabel.TabIndex = 20;
            this.NumCreditsEarnedLabel.Text = "Number of Credits Earned:";
            // 
            // CreditsEarnedBox
            // 
            this.CreditsEarnedBox.BackColor = System.Drawing.SystemColors.Control;
            this.CreditsEarnedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreditsEarnedBox.Location = new System.Drawing.Point(240, 474);
            this.CreditsEarnedBox.Margin = new System.Windows.Forms.Padding(1);
            this.CreditsEarnedBox.Name = "CreditsEarnedBox";
            this.CreditsEarnedBox.Size = new System.Drawing.Size(130, 15);
            this.CreditsEarnedBox.TabIndex = 19;
            this.CreditsEarnedBox.Text = "placeholder";
            // 
            // GPALabel
            // 
            this.GPALabel.AutoSize = true;
            this.GPALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GPALabel.Location = new System.Drawing.Point(182, 492);
            this.GPALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GPALabel.Name = "GPALabel";
            this.GPALabel.Size = new System.Drawing.Size(49, 20);
            this.GPALabel.TabIndex = 18;
            this.GPALabel.Text = "GPA:";
            // 
            // GPABox
            // 
            this.GPABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GPABox.Location = new System.Drawing.Point(240, 496);
            this.GPABox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPABox.Name = "GPABox";
            this.GPABox.ReadOnly = true;
            this.GPABox.Size = new System.Drawing.Size(130, 15);
            this.GPABox.TabIndex = 17;
            this.GPABox.Text = "placeholder";
            // 
            // warningBox2
            // 
            this.warningBox2.BackColor = System.Drawing.SystemColors.Control;
            this.warningBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warningBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningBox2.Location = new System.Drawing.Point(46, 32);
            this.warningBox2.Margin = new System.Windows.Forms.Padding(2);
            this.warningBox2.Name = "warningBox2";
            this.warningBox2.Size = new System.Drawing.Size(540, 20);
            this.warningBox2.TabIndex = 22;
            this.warningBox2.Text = "**Warning: There is a time conflict between two or more classes.**";
            // 
            // warningBox
            // 
            this.warningBox.BackColor = System.Drawing.SystemColors.Control;
            this.warningBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warningBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningBox.Location = new System.Drawing.Point(46, 32);
            this.warningBox.Margin = new System.Windows.Forms.Padding(2);
            this.warningBox.Name = "warningBox";
            this.warningBox.Size = new System.Drawing.Size(540, 20);
            this.warningBox.TabIndex = 21;
            this.warningBox.Text = "**Warning: There are no registered classes.**";
            // 
            // adviseeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1264, 582);
            this.ControlBox = false;
            this.Controls.Add(this.warningBox2);
            this.Controls.Add(this.warningBox);
            this.Controls.Add(this.NumCreditsEarnedLabel);
            this.Controls.Add(this.CreditsEarnedBox);
            this.Controls.Add(this.GPALabel);
            this.Controls.Add(this.GPABox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyrightBox);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AdviseeViewGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "adviseeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advisee View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.AdviseeViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdviseeViewGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Courses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBlock5;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox copyrightBox;
        private System.Windows.Forms.Label NumCreditsEarnedLabel;
        private System.Windows.Forms.TextBox CreditsEarnedBox;
        private System.Windows.Forms.Label GPALabel;
        private System.Windows.Forms.TextBox GPABox;
        private System.Windows.Forms.TextBox warningBox2;
        private System.Windows.Forms.TextBox warningBox;
    }
}