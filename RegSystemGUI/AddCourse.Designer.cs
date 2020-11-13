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
            ((System.ComponentModel.ISupportInitialize)(this.Num_TimeBlocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Seats)).BeginInit();
            this.SuspendLayout();
            // 
            // Course_Name_Label
            // 
            this.Course_Name_Label.AutoSize = true;
            this.Course_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Name_Label.Location = new System.Drawing.Point(83, 28);
            this.Course_Name_Label.Name = "Course_Name_Label";
            this.Course_Name_Label.Size = new System.Drawing.Size(138, 24);
            this.Course_Name_Label.TabIndex = 0;
            this.Course_Name_Label.Text = "Course Name";
            // 
            // Course_Title_Label
            // 
            this.Course_Title_Label.AutoSize = true;
            this.Course_Title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Title_Label.Location = new System.Drawing.Point(83, 67);
            this.Course_Title_Label.Name = "Course_Title_Label";
            this.Course_Title_Label.Size = new System.Drawing.Size(123, 24);
            this.Course_Title_Label.TabIndex = 1;
            this.Course_Title_Label.Text = "Course Title";
            // 
            // Instructor_Label
            // 
            this.Instructor_Label.AutoSize = true;
            this.Instructor_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructor_Label.Location = new System.Drawing.Point(83, 105);
            this.Instructor_Label.Name = "Instructor_Label";
            this.Instructor_Label.Size = new System.Drawing.Size(96, 24);
            this.Instructor_Label.TabIndex = 2;
            this.Instructor_Label.Text = "Instructor";
            // 
            // Num_TimeBlocks
            // 
            this.Num_TimeBlocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_TimeBlocks.Location = new System.Drawing.Point(315, 223);
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
            this.Num_TimeBlocks.Size = new System.Drawing.Size(120, 22);
            this.Num_TimeBlocks.TabIndex = 3;
            this.Num_TimeBlocks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Num_TB_Label
            // 
            this.Num_TB_Label.AutoSize = true;
            this.Num_TB_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_TB_Label.Location = new System.Drawing.Point(83, 221);
            this.Num_TB_Label.Name = "Num_TB_Label";
            this.Num_TB_Label.Size = new System.Drawing.Size(221, 24);
            this.Num_TB_Label.TabIndex = 4;
            this.Num_TB_Label.Text = "Number of Timeblocks";
            // 
            // Credits_Label
            // 
            this.Credits_Label.AutoSize = true;
            this.Credits_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits_Label.Location = new System.Drawing.Point(83, 144);
            this.Credits_Label.Name = "Credits_Label";
            this.Credits_Label.Size = new System.Drawing.Size(75, 24);
            this.Credits_Label.TabIndex = 5;
            this.Credits_Label.Text = "Credits";
            // 
            // Num_Seats_Label
            // 
            this.Num_Seats_Label.AutoSize = true;
            this.Num_Seats_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Seats_Label.Location = new System.Drawing.Point(83, 179);
            this.Num_Seats_Label.Name = "Num_Seats_Label";
            this.Num_Seats_Label.Size = new System.Drawing.Size(165, 24);
            this.Num_Seats_Label.TabIndex = 6;
            this.Num_Seats_Label.Text = "Number of Seats";
            // 
            // Course_Name_Box
            // 
            this.Course_Name_Box.Location = new System.Drawing.Point(314, 31);
            this.Course_Name_Box.MaxLength = 10;
            this.Course_Name_Box.Name = "Course_Name_Box";
            this.Course_Name_Box.Size = new System.Drawing.Size(100, 20);
            this.Course_Name_Box.TabIndex = 8;
            // 
            // Course_Title_Box
            // 
            this.Course_Title_Box.Location = new System.Drawing.Point(314, 70);
            this.Course_Title_Box.MaxLength = 15;
            this.Course_Title_Box.Name = "Course_Title_Box";
            this.Course_Title_Box.Size = new System.Drawing.Size(100, 20);
            this.Course_Title_Box.TabIndex = 9;
            // 
            // Instructor_Button
            // 
            this.Instructor_Button.Location = new System.Drawing.Point(315, 105);
            this.Instructor_Button.Name = "Instructor_Button";
            this.Instructor_Button.Size = new System.Drawing.Size(75, 23);
            this.Instructor_Button.TabIndex = 10;
            this.Instructor_Button.Text = "Select";
            this.Instructor_Button.UseVisualStyleBackColor = true;
            // 
            // Credit_Box
            // 
            this.Credit_Box.Items.Add("0.2");
            this.Credit_Box.Items.Add("0.3");
            this.Credit_Box.Items.Add("0.5");
            this.Credit_Box.Items.Add("1.0");
            this.Credit_Box.Location = new System.Drawing.Point(314, 144);
            this.Credit_Box.Name = "Credit_Box";
            this.Credit_Box.Size = new System.Drawing.Size(120, 20);
            this.Credit_Box.TabIndex = 11;
            // 
            // Num_Seats
            // 
            this.Num_Seats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Seats.Location = new System.Drawing.Point(314, 183);
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
            this.Num_Seats.Size = new System.Drawing.Size(120, 22);
            this.Num_Seats.TabIndex = 12;
            this.Num_Seats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(87, 273);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(87, 310);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(87, 343);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(87, 376);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 21;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(87, 409);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 22;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // Edit_TB1_Button
            // 
            this.Edit_TB1_Button.Location = new System.Drawing.Point(182, 269);
            this.Edit_TB1_Button.Name = "Edit_TB1_Button";
            this.Edit_TB1_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_TB1_Button.TabIndex = 23;
            this.Edit_TB1_Button.Text = "Edit";
            this.Edit_TB1_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_TB2_Button
            // 
            this.Edit_TB2_Button.Location = new System.Drawing.Point(182, 306);
            this.Edit_TB2_Button.Name = "Edit_TB2_Button";
            this.Edit_TB2_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_TB2_Button.TabIndex = 24;
            this.Edit_TB2_Button.Text = "Edit";
            this.Edit_TB2_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_TB3_Button
            // 
            this.Edit_TB3_Button.Location = new System.Drawing.Point(182, 339);
            this.Edit_TB3_Button.Name = "Edit_TB3_Button";
            this.Edit_TB3_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_TB3_Button.TabIndex = 25;
            this.Edit_TB3_Button.Text = "Edit";
            this.Edit_TB3_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_TB4_Button
            // 
            this.Edit_TB4_Button.Location = new System.Drawing.Point(182, 372);
            this.Edit_TB4_Button.Name = "Edit_TB4_Button";
            this.Edit_TB4_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_TB4_Button.TabIndex = 26;
            this.Edit_TB4_Button.Text = "Edit";
            this.Edit_TB4_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_TB5_Button
            // 
            this.Edit_TB5_Button.Location = new System.Drawing.Point(182, 405);
            this.Edit_TB5_Button.Name = "Edit_TB5_Button";
            this.Edit_TB5_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_TB5_Button.TabIndex = 27;
            this.Edit_TB5_Button.Text = "Edit";
            this.Edit_TB5_Button.UseVisualStyleBackColor = true;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "AddCourse";
            this.Text = "AddCourse";
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
    }
}