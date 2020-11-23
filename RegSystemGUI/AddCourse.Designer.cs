namespace RegSystemGUI
{
    partial class AddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.Course_Name_Label = new System.Windows.Forms.Label();
            this.Course_Title_Label = new System.Windows.Forms.Label();
            this.Instructor_Label = new System.Windows.Forms.Label();
            this.Num_TimeBlocks = new System.Windows.Forms.NumericUpDown();
            this.Num_TB_Label = new System.Windows.Forms.Label();
            this.Credits_Label = new System.Windows.Forms.Label();
            this.Num_Seats_Label = new System.Windows.Forms.Label();
            this.Course_Name_Box = new System.Windows.Forms.TextBox();
            this.Course_Title_Box = new System.Windows.Forms.TextBox();
            this.Instructor_Button = new System.Windows.Forms.Button();
            this.Credit_Box = new System.Windows.Forms.DomainUpDown();
            this.Num_Seats = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.Edit_TB1_Button = new System.Windows.Forms.Button();
            this.Edit_TB2_Button = new System.Windows.Forms.Button();
            this.Edit_TB3_Button = new System.Windows.Forms.Button();
            this.Edit_TB4_Button = new System.Windows.Forms.Button();
            this.Edit_TB5_Button = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Prereq = new System.Windows.Forms.CheckBox();
            this.Prereq_Display = new System.Windows.Forms.TextBox();
            this.Add_P_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyrightBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Num_TimeBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Seats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Course_Name_Label
            // 
            this.Course_Name_Label.AutoSize = true;
            this.Course_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Name_Label.Location = new System.Drawing.Point(111, 35);
            this.Course_Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Course_Name_Label.Name = "Course_Name_Label";
            this.Course_Name_Label.Size = new System.Drawing.Size(173, 29);
            this.Course_Name_Label.TabIndex = 0;
            this.Course_Name_Label.Text = "Course Name";
            // 
            // Course_Title_Label
            // 
            this.Course_Title_Label.AutoSize = true;
            this.Course_Title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Title_Label.Location = new System.Drawing.Point(111, 83);
            this.Course_Title_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Course_Title_Label.Name = "Course_Title_Label";
            this.Course_Title_Label.Size = new System.Drawing.Size(157, 29);
            this.Course_Title_Label.TabIndex = 1;
            this.Course_Title_Label.Text = "Course Title";
            // 
            // Instructor_Label
            // 
            this.Instructor_Label.AutoSize = true;
            this.Instructor_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructor_Label.Location = new System.Drawing.Point(111, 129);
            this.Instructor_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Instructor_Label.Name = "Instructor_Label";
            this.Instructor_Label.Size = new System.Drawing.Size(121, 29);
            this.Instructor_Label.TabIndex = 2;
            this.Instructor_Label.Text = "Instructor";
            // 
            // Num_TimeBlocks
            // 
            this.Num_TimeBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_TimeBlocks.Location = new System.Drawing.Point(420, 275);
            this.Num_TimeBlocks.Margin = new System.Windows.Forms.Padding(4);
            this.Num_TimeBlocks.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Num_TimeBlocks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_TimeBlocks.Name = "Num_TimeBlocks";
            this.Num_TimeBlocks.Size = new System.Drawing.Size(159, 26);
            this.Num_TimeBlocks.TabIndex = 5;
            this.Num_TimeBlocks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_TimeBlocks.ValueChanged += new System.EventHandler(this.Num_TB_Change);
            // 
            // Num_TB_Label
            // 
            this.Num_TB_Label.AutoSize = true;
            this.Num_TB_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_TB_Label.Location = new System.Drawing.Point(111, 272);
            this.Num_TB_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Num_TB_Label.Name = "Num_TB_Label";
            this.Num_TB_Label.Size = new System.Drawing.Size(278, 29);
            this.Num_TB_Label.TabIndex = 4;
            this.Num_TB_Label.Text = "Number of Timeblocks";
            // 
            // Credits_Label
            // 
            this.Credits_Label.AutoSize = true;
            this.Credits_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits_Label.Location = new System.Drawing.Point(111, 177);
            this.Credits_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Credits_Label.Name = "Credits_Label";
            this.Credits_Label.Size = new System.Drawing.Size(97, 29);
            this.Credits_Label.TabIndex = 5;
            this.Credits_Label.Text = "Credits";
            // 
            // Num_Seats_Label
            // 
            this.Num_Seats_Label.AutoSize = true;
            this.Num_Seats_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Seats_Label.Location = new System.Drawing.Point(111, 220);
            this.Num_Seats_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Num_Seats_Label.Name = "Num_Seats_Label";
            this.Num_Seats_Label.Size = new System.Drawing.Size(208, 29);
            this.Num_Seats_Label.TabIndex = 6;
            this.Num_Seats_Label.Text = "Number of Seats";
            // 
            // Course_Name_Box
            // 
            this.Course_Name_Box.Location = new System.Drawing.Point(419, 38);
            this.Course_Name_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Course_Name_Box.MaxLength = 10;
            this.Course_Name_Box.Name = "Course_Name_Box";
            this.Course_Name_Box.Size = new System.Drawing.Size(132, 22);
            this.Course_Name_Box.TabIndex = 0;
            // 
            // Course_Title_Box
            // 
            this.Course_Title_Box.Location = new System.Drawing.Point(419, 86);
            this.Course_Title_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Course_Title_Box.MaxLength = 15;
            this.Course_Title_Box.Name = "Course_Title_Box";
            this.Course_Title_Box.Size = new System.Drawing.Size(132, 22);
            this.Course_Title_Box.TabIndex = 1;
            // 
            // Instructor_Button
            // 
            this.Instructor_Button.Location = new System.Drawing.Point(420, 129);
            this.Instructor_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Instructor_Button.Name = "Instructor_Button";
            this.Instructor_Button.Size = new System.Drawing.Size(100, 28);
            this.Instructor_Button.TabIndex = 2;
            this.Instructor_Button.Text = "Select";
            this.Instructor_Button.UseVisualStyleBackColor = true;
            this.Instructor_Button.Click += new System.EventHandler(this.Instructor_Button_Click);
            // 
            // Credit_Box
            // 
            this.Credit_Box.Items.Add("0.2");
            this.Credit_Box.Items.Add("0.3");
            this.Credit_Box.Items.Add("0.5");
            this.Credit_Box.Items.Add("1.0");
            this.Credit_Box.Location = new System.Drawing.Point(419, 177);
            this.Credit_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Credit_Box.Name = "Credit_Box";
            this.Credit_Box.Size = new System.Drawing.Size(160, 22);
            this.Credit_Box.TabIndex = 3;
            this.Credit_Box.Text = "None Selected";
            // 
            // Num_Seats
            // 
            this.Num_Seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Seats.Location = new System.Drawing.Point(419, 225);
            this.Num_Seats.Margin = new System.Windows.Forms.Padding(4);
            this.Num_Seats.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Num_Seats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Seats.Name = "Num_Seats";
            this.Num_Seats.Size = new System.Drawing.Size(160, 26);
            this.Num_Seats.TabIndex = 4;
            this.Num_Seats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(116, 336);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 21);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Time Block 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoCheck = false;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(116, 381);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 21);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Time Block 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoCheck = false;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(116, 422);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(111, 21);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Time Block 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoCheck = false;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(116, 463);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(111, 21);
            this.checkBox4.TabIndex = 21;
            this.checkBox4.Text = "Time Block 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoCheck = false;
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(116, 504);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(111, 21);
            this.checkBox5.TabIndex = 22;
            this.checkBox5.Text = "Time Block 5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // Edit_TB1_Button
            // 
            this.Edit_TB1_Button.Location = new System.Drawing.Point(243, 331);
            this.Edit_TB1_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_TB1_Button.Name = "Edit_TB1_Button";
            this.Edit_TB1_Button.Size = new System.Drawing.Size(100, 28);
            this.Edit_TB1_Button.TabIndex = 6;
            this.Edit_TB1_Button.Text = "Edit";
            this.Edit_TB1_Button.UseVisualStyleBackColor = true;
            this.Edit_TB1_Button.Click += new System.EventHandler(this.Edit_TB1_Button_Click);
            // 
            // Edit_TB2_Button
            // 
            this.Edit_TB2_Button.Location = new System.Drawing.Point(243, 376);
            this.Edit_TB2_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_TB2_Button.Name = "Edit_TB2_Button";
            this.Edit_TB2_Button.Size = new System.Drawing.Size(100, 28);
            this.Edit_TB2_Button.TabIndex = 7;
            this.Edit_TB2_Button.Text = "Edit";
            this.Edit_TB2_Button.UseVisualStyleBackColor = true;
            this.Edit_TB2_Button.Click += new System.EventHandler(this.Edit_TB2_Button_Click);
            // 
            // Edit_TB3_Button
            // 
            this.Edit_TB3_Button.Location = new System.Drawing.Point(243, 417);
            this.Edit_TB3_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_TB3_Button.Name = "Edit_TB3_Button";
            this.Edit_TB3_Button.Size = new System.Drawing.Size(100, 28);
            this.Edit_TB3_Button.TabIndex = 8;
            this.Edit_TB3_Button.Text = "Edit";
            this.Edit_TB3_Button.UseVisualStyleBackColor = true;
            this.Edit_TB3_Button.Click += new System.EventHandler(this.Edit_TB3_Button_Click);
            // 
            // Edit_TB4_Button
            // 
            this.Edit_TB4_Button.Location = new System.Drawing.Point(243, 458);
            this.Edit_TB4_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_TB4_Button.Name = "Edit_TB4_Button";
            this.Edit_TB4_Button.Size = new System.Drawing.Size(100, 28);
            this.Edit_TB4_Button.TabIndex = 9;
            this.Edit_TB4_Button.Text = "Edit";
            this.Edit_TB4_Button.UseVisualStyleBackColor = true;
            this.Edit_TB4_Button.Click += new System.EventHandler(this.Edit_TB4_Button_Click);
            // 
            // Edit_TB5_Button
            // 
            this.Edit_TB5_Button.Location = new System.Drawing.Point(243, 499);
            this.Edit_TB5_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_TB5_Button.Name = "Edit_TB5_Button";
            this.Edit_TB5_Button.Size = new System.Drawing.Size(100, 28);
            this.Edit_TB5_Button.TabIndex = 10;
            this.Edit_TB5_Button.Text = "Edit";
            this.Edit_TB5_Button.UseVisualStyleBackColor = true;
            this.Edit_TB5_Button.Click += new System.EventHandler(this.Edit_TB5_Button_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(419, 335);
            this.TB1.Margin = new System.Windows.Forms.Padding(1);
            this.TB1.Name = "TB1";
            this.TB1.ReadOnly = true;
            this.TB1.Size = new System.Drawing.Size(163, 22);
            this.TB1.TabIndex = 11;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(419, 380);
            this.TB2.Margin = new System.Windows.Forms.Padding(1);
            this.TB2.Name = "TB2";
            this.TB2.ReadOnly = true;
            this.TB2.Size = new System.Drawing.Size(163, 22);
            this.TB2.TabIndex = 12;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(419, 421);
            this.TB3.Margin = new System.Windows.Forms.Padding(1);
            this.TB3.Name = "TB3";
            this.TB3.ReadOnly = true;
            this.TB3.Size = new System.Drawing.Size(163, 22);
            this.TB3.TabIndex = 13;
            // 
            // TB4
            // 
            this.TB4.Location = new System.Drawing.Point(419, 461);
            this.TB4.Margin = new System.Windows.Forms.Padding(1);
            this.TB4.Name = "TB4";
            this.TB4.ReadOnly = true;
            this.TB4.Size = new System.Drawing.Size(163, 22);
            this.TB4.TabIndex = 14;
            // 
            // TB5
            // 
            this.TB5.Location = new System.Drawing.Point(419, 502);
            this.TB5.Margin = new System.Windows.Forms.Padding(1);
            this.TB5.Name = "TB5";
            this.TB5.ReadOnly = true;
            this.TB5.Size = new System.Drawing.Size(163, 22);
            this.TB5.TabIndex = 15;
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(281, 710);
            this.Submit_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(139, 47);
            this.Submit_Button.TabIndex = 19;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 560);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Prerequisite Courses";
            // 
            // Prereq
            // 
            this.Prereq.AutoSize = true;
            this.Prereq.Location = new System.Drawing.Point(419, 565);
            this.Prereq.Margin = new System.Windows.Forms.Padding(1);
            this.Prereq.Name = "Prereq";
            this.Prereq.Size = new System.Drawing.Size(18, 17);
            this.Prereq.TabIndex = 16;
            this.Prereq.UseVisualStyleBackColor = true;
            this.Prereq.Click += new System.EventHandler(this.Prereq_Click);
            // 
            // Prereq_Display
            // 
            this.Prereq_Display.Location = new System.Drawing.Point(116, 589);
            this.Prereq_Display.Margin = new System.Windows.Forms.Padding(1);
            this.Prereq_Display.Multiline = true;
            this.Prereq_Display.Name = "Prereq_Display";
            this.Prereq_Display.Size = new System.Drawing.Size(239, 100);
            this.Prereq_Display.TabIndex = 17;
            // 
            // Add_P_Button
            // 
            this.Add_P_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_P_Button.Location = new System.Drawing.Point(420, 614);
            this.Add_P_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Add_P_Button.Name = "Add_P_Button";
            this.Add_P_Button.Size = new System.Drawing.Size(119, 35);
            this.Add_P_Button.TabIndex = 18;
            this.Add_P_Button.Text = "Add";
            this.Add_P_Button.UseVisualStyleBackColor = true;
            this.Add_P_Button.Click += new System.EventHandler(this.Add_P_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(627, 720);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(76, 37);
            this.Cancel_Button.TabIndex = 20;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 773);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // copyrightBox
            // 
            this.copyrightBox.BackColor = System.Drawing.SystemColors.Control;
            this.copyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightBox.Location = new System.Drawing.Point(220, 778);
            this.copyrightBox.Name = "copyrightBox";
            this.copyrightBox.Size = new System.Drawing.Size(296, 15);
            this.copyrightBox.TabIndex = 40;
            this.copyrightBox.TabStop = false;
            this.copyrightBox.Text = "this software is property of tectyte ©2020";
            this.copyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(734, 772);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyrightBox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Add_P_Button);
            this.Controls.Add(this.Prereq_Display);
            this.Controls.Add(this.Prereq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.Edit_TB5_Button);
            this.Controls.Add(this.Edit_TB4_Button);
            this.Controls.Add(this.Edit_TB3_Button);
            this.Controls.Add(this.Edit_TB2_Button);
            this.Controls.Add(this.Edit_TB1_Button);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Num_Seats);
            this.Controls.Add(this.Credit_Box);
            this.Controls.Add(this.Instructor_Button);
            this.Controls.Add(this.Course_Title_Box);
            this.Controls.Add(this.Course_Name_Box);
            this.Controls.Add(this.Num_Seats_Label);
            this.Controls.Add(this.Credits_Label);
            this.Controls.Add(this.Num_TB_Label);
            this.Controls.Add(this.Num_TimeBlocks);
            this.Controls.Add(this.Instructor_Label);
            this.Controls.Add(this.Course_Title_Label);
            this.Controls.Add(this.Course_Name_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Num_TimeBlocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Seats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Course_Name_Label;
        private System.Windows.Forms.Label Course_Title_Label;
        private System.Windows.Forms.Label Instructor_Label;
        private System.Windows.Forms.NumericUpDown Num_TimeBlocks;
        private System.Windows.Forms.Label Num_TB_Label;
        private System.Windows.Forms.Label Credits_Label;
        private System.Windows.Forms.Label Num_Seats_Label;
        private System.Windows.Forms.TextBox Course_Name_Box;
        private System.Windows.Forms.TextBox Course_Title_Box;
        private System.Windows.Forms.Button Instructor_Button;
        private System.Windows.Forms.DomainUpDown Credit_Box;
        private System.Windows.Forms.NumericUpDown Num_Seats;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button Edit_TB1_Button;
        private System.Windows.Forms.Button Edit_TB2_Button;
        private System.Windows.Forms.Button Edit_TB3_Button;
        private System.Windows.Forms.Button Edit_TB4_Button;
        private System.Windows.Forms.Button Edit_TB5_Button;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.TextBox TB5;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Prereq;
        private System.Windows.Forms.TextBox Prereq_Display;
        private System.Windows.Forms.Button Add_P_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox copyrightBox;
    }
}