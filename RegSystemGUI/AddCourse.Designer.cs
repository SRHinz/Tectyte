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
            ((System.ComponentModel.ISupportInitialize)(this.Num_TimeBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Seats)).BeginInit();
            this.SuspendLayout();
            // 
            // Course_Name_Label
            // 
            this.Course_Name_Label.AutoSize = true;
            this.Course_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Name_Label.Location = new System.Drawing.Point(263, 80);
            this.Course_Name_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Course_Name_Label.Name = "Course_Name_Label";
            this.Course_Name_Label.Size = new System.Drawing.Size(391, 65);
            this.Course_Name_Label.TabIndex = 0;
            this.Course_Name_Label.Text = "Course Name";
            // 
            // Course_Title_Label
            // 
            this.Course_Title_Label.AutoSize = true;
            this.Course_Title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Title_Label.Location = new System.Drawing.Point(263, 191);
            this.Course_Title_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Course_Title_Label.Name = "Course_Title_Label";
            this.Course_Title_Label.Size = new System.Drawing.Size(349, 65);
            this.Course_Title_Label.TabIndex = 1;
            this.Course_Title_Label.Text = "Course Title";
            // 
            // Instructor_Label
            // 
            this.Instructor_Label.AutoSize = true;
            this.Instructor_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructor_Label.Location = new System.Drawing.Point(263, 299);
            this.Instructor_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Instructor_Label.Name = "Instructor_Label";
            this.Instructor_Label.Size = new System.Drawing.Size(278, 65);
            this.Instructor_Label.TabIndex = 2;
            this.Instructor_Label.Text = "Instructor";
            // 
            // Num_TimeBlocks
            // 
            this.Num_TimeBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_TimeBlocks.Location = new System.Drawing.Point(998, 635);
            this.Num_TimeBlocks.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
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
            this.Num_TimeBlocks.Size = new System.Drawing.Size(376, 52);
            this.Num_TimeBlocks.TabIndex = 3;
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
            this.Num_TB_Label.Location = new System.Drawing.Point(263, 629);
            this.Num_TB_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Num_TB_Label.Name = "Num_TB_Label";
            this.Num_TB_Label.Size = new System.Drawing.Size(620, 65);
            this.Num_TB_Label.TabIndex = 4;
            this.Num_TB_Label.Text = "Number of Timeblocks";
            // 
            // Credits_Label
            // 
            this.Credits_Label.AutoSize = true;
            this.Credits_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits_Label.Location = new System.Drawing.Point(263, 410);
            this.Credits_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Credits_Label.Name = "Credits_Label";
            this.Credits_Label.Size = new System.Drawing.Size(217, 65);
            this.Credits_Label.TabIndex = 5;
            this.Credits_Label.Text = "Credits";
            // 
            // Num_Seats_Label
            // 
            this.Num_Seats_Label.AutoSize = true;
            this.Num_Seats_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Seats_Label.Location = new System.Drawing.Point(263, 509);
            this.Num_Seats_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Num_Seats_Label.Name = "Num_Seats_Label";
            this.Num_Seats_Label.Size = new System.Drawing.Size(471, 65);
            this.Num_Seats_Label.TabIndex = 6;
            this.Num_Seats_Label.Text = "Number of Seats";
            // 
            // Course_Name_Box
            // 
            this.Course_Name_Box.Location = new System.Drawing.Point(994, 88);
            this.Course_Name_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Course_Name_Box.MaxLength = 10;
            this.Course_Name_Box.Name = "Course_Name_Box";
            this.Course_Name_Box.Size = new System.Drawing.Size(308, 44);
            this.Course_Name_Box.TabIndex = 8;
            // 
            // Course_Title_Box
            // 
            this.Course_Title_Box.Location = new System.Drawing.Point(994, 199);
            this.Course_Title_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Course_Title_Box.MaxLength = 15;
            this.Course_Title_Box.Name = "Course_Title_Box";
            this.Course_Title_Box.Size = new System.Drawing.Size(308, 44);
            this.Course_Title_Box.TabIndex = 9;
            // 
            // Instructor_Button
            // 
            this.Instructor_Button.Location = new System.Drawing.Point(998, 299);
            this.Instructor_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Instructor_Button.Name = "Instructor_Button";
            this.Instructor_Button.Size = new System.Drawing.Size(238, 65);
            this.Instructor_Button.TabIndex = 10;
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
            this.Credit_Box.Location = new System.Drawing.Point(994, 410);
            this.Credit_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Credit_Box.Name = "Credit_Box";
            this.Credit_Box.Size = new System.Drawing.Size(380, 44);
            this.Credit_Box.TabIndex = 11;
            this.Credit_Box.Text = "None Selected";
            // 
            // Num_Seats
            // 
            this.Num_Seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Seats.Location = new System.Drawing.Point(994, 521);
            this.Num_Seats.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
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
            this.Num_Seats.Size = new System.Drawing.Size(380, 52);
            this.Num_Seats.TabIndex = 12;
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
            this.checkBox1.Location = new System.Drawing.Point(276, 777);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(246, 41);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Time Block 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoCheck = false;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(276, 882);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(248, 41);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Time Block 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoCheck = false;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(276, 976);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(248, 41);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Time Block 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoCheck = false;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(276, 1070);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(248, 41);
            this.checkBox4.TabIndex = 21;
            this.checkBox4.Text = "Time Block 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoCheck = false;
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(276, 1164);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(248, 41);
            this.checkBox5.TabIndex = 22;
            this.checkBox5.Text = "Time Block 5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // Edit_TB1_Button
            // 
            this.Edit_TB1_Button.Location = new System.Drawing.Point(576, 766);
            this.Edit_TB1_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Edit_TB1_Button.Name = "Edit_TB1_Button";
            this.Edit_TB1_Button.Size = new System.Drawing.Size(238, 65);
            this.Edit_TB1_Button.TabIndex = 23;
            this.Edit_TB1_Button.Text = "Edit";
            this.Edit_TB1_Button.UseVisualStyleBackColor = true;
            this.Edit_TB1_Button.Click += new System.EventHandler(this.Edit_TB1_Button_Click);
            // 
            // Edit_TB2_Button
            // 
            this.Edit_TB2_Button.Location = new System.Drawing.Point(576, 871);
            this.Edit_TB2_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Edit_TB2_Button.Name = "Edit_TB2_Button";
            this.Edit_TB2_Button.Size = new System.Drawing.Size(238, 65);
            this.Edit_TB2_Button.TabIndex = 24;
            this.Edit_TB2_Button.Text = "Edit";
            this.Edit_TB2_Button.UseVisualStyleBackColor = true;
            this.Edit_TB2_Button.Click += new System.EventHandler(this.Edit_TB2_Button_Click);
            // 
            // Edit_TB3_Button
            // 
            this.Edit_TB3_Button.Location = new System.Drawing.Point(576, 965);
            this.Edit_TB3_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Edit_TB3_Button.Name = "Edit_TB3_Button";
            this.Edit_TB3_Button.Size = new System.Drawing.Size(238, 65);
            this.Edit_TB3_Button.TabIndex = 25;
            this.Edit_TB3_Button.Text = "Edit";
            this.Edit_TB3_Button.UseVisualStyleBackColor = true;
            this.Edit_TB3_Button.Click += new System.EventHandler(this.Edit_TB3_Button_Click);
            // 
            // Edit_TB4_Button
            // 
            this.Edit_TB4_Button.Location = new System.Drawing.Point(576, 1059);
            this.Edit_TB4_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Edit_TB4_Button.Name = "Edit_TB4_Button";
            this.Edit_TB4_Button.Size = new System.Drawing.Size(238, 65);
            this.Edit_TB4_Button.TabIndex = 26;
            this.Edit_TB4_Button.Text = "Edit";
            this.Edit_TB4_Button.UseVisualStyleBackColor = true;
            this.Edit_TB4_Button.Click += new System.EventHandler(this.Edit_TB4_Button_Click);
            // 
            // Edit_TB5_Button
            // 
            this.Edit_TB5_Button.Location = new System.Drawing.Point(576, 1153);
            this.Edit_TB5_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Edit_TB5_Button.Name = "Edit_TB5_Button";
            this.Edit_TB5_Button.Size = new System.Drawing.Size(238, 65);
            this.Edit_TB5_Button.TabIndex = 27;
            this.Edit_TB5_Button.Text = "Edit";
            this.Edit_TB5_Button.UseVisualStyleBackColor = true;
            this.Edit_TB5_Button.Click += new System.EventHandler(this.Edit_TB5_Button_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(994, 773);
            this.TB1.Name = "TB1";
            this.TB1.ReadOnly = true;
            this.TB1.Size = new System.Drawing.Size(380, 44);
            this.TB1.TabIndex = 28;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(994, 880);
            this.TB2.Name = "TB2";
            this.TB2.ReadOnly = true;
            this.TB2.Size = new System.Drawing.Size(380, 44);
            this.TB2.TabIndex = 29;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(994, 973);
            this.TB3.Name = "TB3";
            this.TB3.ReadOnly = true;
            this.TB3.Size = new System.Drawing.Size(380, 44);
            this.TB3.TabIndex = 30;
            // 
            // TB4
            // 
            this.TB4.Location = new System.Drawing.Point(994, 1067);
            this.TB4.Name = "TB4";
            this.TB4.ReadOnly = true;
            this.TB4.Size = new System.Drawing.Size(380, 44);
            this.TB4.TabIndex = 31;
            // 
            // TB5
            // 
            this.TB5.Location = new System.Drawing.Point(994, 1161);
            this.TB5.Name = "TB5";
            this.TB5.ReadOnly = true;
            this.TB5.Size = new System.Drawing.Size(380, 44);
            this.TB5.TabIndex = 32;
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(745, 1617);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(330, 108);
            this.Submit_Button.TabIndex = 33;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 1296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 64);
            this.label1.TabIndex = 35;
            this.label1.Text = "Prerequisite Courses";
            // 
            // Prereq
            // 
            this.Prereq.AutoSize = true;
            this.Prereq.Location = new System.Drawing.Point(994, 1305);
            this.Prereq.Name = "Prereq";
            this.Prereq.Size = new System.Drawing.Size(42, 41);
            this.Prereq.TabIndex = 36;
            this.Prereq.UseVisualStyleBackColor = true;
            this.Prereq.Click += new System.EventHandler(this.Prereq_Click);
            // 
            // Prereq_Display
            // 
            this.Prereq_Display.Location = new System.Drawing.Point(276, 1363);
            this.Prereq_Display.Multiline = true;
            this.Prereq_Display.Name = "Prereq_Display";
            this.Prereq_Display.Size = new System.Drawing.Size(560, 225);
            this.Prereq_Display.TabIndex = 37;
            // 
            // Add_P_Button
            // 
            this.Add_P_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_P_Button.Location = new System.Drawing.Point(998, 1420);
            this.Add_P_Button.Name = "Add_P_Button";
            this.Add_P_Button.Size = new System.Drawing.Size(283, 81);
            this.Add_P_Button.TabIndex = 38;
            this.Add_P_Button.Text = "Add";
            this.Add_P_Button.UseVisualStyleBackColor = true;
            this.Add_P_Button.Click += new System.EventHandler(this.Add_P_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(1488, 1698);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(142, 54);
            this.Cancel_Button.TabIndex = 39;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1642, 1764);
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
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Num_TimeBlocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Seats)).EndInit();
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
    }
}