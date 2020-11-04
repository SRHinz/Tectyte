namespace RegSystemGUI
{
    partial class EditCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB1_Box = new System.Windows.Forms.TextBox();
            this.Instructor_Box = new System.Windows.Forms.TextBox();
            this.TB2_Box = new System.Windows.Forms.TextBox();
            this.TB3_Box = new System.Windows.Forms.TextBox();
            this.TB4_Box = new System.Windows.Forms.TextBox();
            this.TB5_Box = new System.Windows.Forms.TextBox();
            this.EditInstructorButton = new System.Windows.Forms.Button();
            this.EditTB1Button = new System.Windows.Forms.Button();
            this.EditTB2Button = new System.Windows.Forms.Button();
            this.EditTB3Button = new System.Windows.Forms.Button();
            this.EditTB4Button = new System.Windows.Forms.Button();
            this.EditTB5Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Block 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Block 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time Block 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time Block 4";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time Block 5";
            // 
            // TB1_Box
            // 
            this.TB1_Box.BackColor = System.Drawing.SystemColors.Control;
            this.TB1_Box.Location = new System.Drawing.Point(159, 105);
            this.TB1_Box.Name = "TB1_Box";
            this.TB1_Box.ReadOnly = true;
            this.TB1_Box.Size = new System.Drawing.Size(164, 20);
            this.TB1_Box.TabIndex = 6;
            // 
            // Instructor_Box
            // 
            this.Instructor_Box.BackColor = System.Drawing.SystemColors.Control;
            this.Instructor_Box.Location = new System.Drawing.Point(159, 38);
            this.Instructor_Box.Name = "Instructor_Box";
            this.Instructor_Box.ReadOnly = true;
            this.Instructor_Box.Size = new System.Drawing.Size(100, 20);
            this.Instructor_Box.TabIndex = 7;
            // 
            // TB2_Box
            // 
            this.TB2_Box.BackColor = System.Drawing.SystemColors.Control;
            this.TB2_Box.Location = new System.Drawing.Point(159, 157);
            this.TB2_Box.Name = "TB2_Box";
            this.TB2_Box.ReadOnly = true;
            this.TB2_Box.Size = new System.Drawing.Size(164, 20);
            this.TB2_Box.TabIndex = 8;
            // 
            // TB3_Box
            // 
            this.TB3_Box.BackColor = System.Drawing.SystemColors.Control;
            this.TB3_Box.Location = new System.Drawing.Point(158, 211);
            this.TB3_Box.Name = "TB3_Box";
            this.TB3_Box.ReadOnly = true;
            this.TB3_Box.Size = new System.Drawing.Size(165, 20);
            this.TB3_Box.TabIndex = 9;
            // 
            // TB4_Box
            // 
            this.TB4_Box.BackColor = System.Drawing.SystemColors.Control;
            this.TB4_Box.Location = new System.Drawing.Point(159, 272);
            this.TB4_Box.Name = "TB4_Box";
            this.TB4_Box.ReadOnly = true;
            this.TB4_Box.Size = new System.Drawing.Size(164, 20);
            this.TB4_Box.TabIndex = 10;
            // 
            // TB5_Box
            // 
            this.TB5_Box.BackColor = System.Drawing.SystemColors.Control;
            this.TB5_Box.Location = new System.Drawing.Point(157, 326);
            this.TB5_Box.Name = "TB5_Box";
            this.TB5_Box.ReadOnly = true;
            this.TB5_Box.Size = new System.Drawing.Size(165, 20);
            this.TB5_Box.TabIndex = 11;
            // 
            // EditInstructorButton
            // 
            this.EditInstructorButton.Location = new System.Drawing.Point(329, 35);
            this.EditInstructorButton.Name = "EditInstructorButton";
            this.EditInstructorButton.Size = new System.Drawing.Size(75, 23);
            this.EditInstructorButton.TabIndex = 12;
            this.EditInstructorButton.Text = "Edit";
            this.EditInstructorButton.UseVisualStyleBackColor = true;
            this.EditInstructorButton.Click += new System.EventHandler(this.EditInstructorButton_Click);
            // 
            // EditTB1Button
            // 
            this.EditTB1Button.Location = new System.Drawing.Point(329, 105);
            this.EditTB1Button.Name = "EditTB1Button";
            this.EditTB1Button.Size = new System.Drawing.Size(75, 23);
            this.EditTB1Button.TabIndex = 13;
            this.EditTB1Button.Text = "Edit";
            this.EditTB1Button.UseVisualStyleBackColor = true;
            this.EditTB1Button.Click += new System.EventHandler(this.EditTB1Button_Click);
            // 
            // EditTB2Button
            // 
            this.EditTB2Button.Location = new System.Drawing.Point(329, 157);
            this.EditTB2Button.Name = "EditTB2Button";
            this.EditTB2Button.Size = new System.Drawing.Size(75, 23);
            this.EditTB2Button.TabIndex = 14;
            this.EditTB2Button.Text = "Edit";
            this.EditTB2Button.UseVisualStyleBackColor = true;
            // 
            // EditTB3Button
            // 
            this.EditTB3Button.Location = new System.Drawing.Point(329, 211);
            this.EditTB3Button.Name = "EditTB3Button";
            this.EditTB3Button.Size = new System.Drawing.Size(75, 23);
            this.EditTB3Button.TabIndex = 15;
            this.EditTB3Button.Text = "Edit";
            this.EditTB3Button.UseVisualStyleBackColor = true;
            // 
            // EditTB4Button
            // 
            this.EditTB4Button.Location = new System.Drawing.Point(329, 270);
            this.EditTB4Button.Name = "EditTB4Button";
            this.EditTB4Button.Size = new System.Drawing.Size(75, 23);
            this.EditTB4Button.TabIndex = 16;
            this.EditTB4Button.Text = "Edit";
            this.EditTB4Button.UseVisualStyleBackColor = true;
            // 
            // EditTB5Button
            // 
            this.EditTB5Button.Location = new System.Drawing.Point(328, 323);
            this.EditTB5Button.Name = "EditTB5Button";
            this.EditTB5Button.Size = new System.Drawing.Size(75, 23);
            this.EditTB5Button.TabIndex = 17;
            this.EditTB5Button.Text = "Edit";
            this.EditTB5Button.UseVisualStyleBackColor = true;
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.EditTB5Button);
            this.Controls.Add(this.EditTB4Button);
            this.Controls.Add(this.EditTB3Button);
            this.Controls.Add(this.EditTB2Button);
            this.Controls.Add(this.EditTB1Button);
            this.Controls.Add(this.EditInstructorButton);
            this.Controls.Add(this.TB5_Box);
            this.Controls.Add(this.TB4_Box);
            this.Controls.Add(this.TB3_Box);
            this.Controls.Add(this.TB2_Box);
            this.Controls.Add(this.Instructor_Box);
            this.Controls.Add(this.TB1_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCourse";
            this.Text = "EditCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB1_Box;
        private System.Windows.Forms.TextBox Instructor_Box;
        private System.Windows.Forms.TextBox TB2_Box;
        private System.Windows.Forms.TextBox TB3_Box;
        private System.Windows.Forms.TextBox TB4_Box;
        private System.Windows.Forms.TextBox TB5_Box;
        private System.Windows.Forms.Button EditInstructorButton;
        private System.Windows.Forms.Button EditTB1Button;
        private System.Windows.Forms.Button EditTB2Button;
        private System.Windows.Forms.Button EditTB3Button;
        private System.Windows.Forms.Button EditTB4Button;
        private System.Windows.Forms.Button EditTB5Button;
    }
}