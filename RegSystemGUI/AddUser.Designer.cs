namespace RegSystemGUI
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyrightBox = new System.Windows.Forms.TextBox();
            this.FName_Label = new System.Windows.Forms.Label();
            this.LName_Label = new System.Windows.Forms.Label();
            this.Advisor_Label = new System.Windows.Forms.Label();
            this.Account_Type_Label = new System.Windows.Forms.Label();
            this.FName_Box = new System.Windows.Forms.TextBox();
            this.LName_Box = new System.Windows.Forms.TextBox();
            this.AccountType_Box = new System.Windows.Forms.ComboBox();
            this.MName_Label = new System.Windows.Forms.Label();
            this.MName_Box = new System.Windows.Forms.TextBox();
            this.Select_Advisor_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 456);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // copyrightBox
            // 
            this.copyrightBox.BackColor = System.Drawing.SystemColors.Control;
            this.copyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightBox.Location = new System.Drawing.Point(131, 460);
            this.copyrightBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.copyrightBox.Name = "copyrightBox";
            this.copyrightBox.Size = new System.Drawing.Size(222, 13);
            this.copyrightBox.TabIndex = 16;
            this.copyrightBox.Text = "this software is property of tectyte ©2020";
            this.copyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FName_Label
            // 
            this.FName_Label.AutoSize = true;
            this.FName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName_Label.Location = new System.Drawing.Point(68, 45);
            this.FName_Label.Name = "FName_Label";
            this.FName_Label.Size = new System.Drawing.Size(83, 16);
            this.FName_Label.TabIndex = 17;
            this.FName_Label.Text = "First Name";
            // 
            // LName_Label
            // 
            this.LName_Label.AutoSize = true;
            this.LName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName_Label.Location = new System.Drawing.Point(68, 142);
            this.LName_Label.Name = "LName_Label";
            this.LName_Label.Size = new System.Drawing.Size(82, 16);
            this.LName_Label.TabIndex = 18;
            this.LName_Label.Text = "Last Name";
            // 
            // Advisor_Label
            // 
            this.Advisor_Label.AutoSize = true;
            this.Advisor_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisor_Label.Location = new System.Drawing.Point(68, 246);
            this.Advisor_Label.Name = "Advisor_Label";
            this.Advisor_Label.Size = new System.Drawing.Size(61, 16);
            this.Advisor_Label.TabIndex = 19;
            this.Advisor_Label.Text = "Advisor";
            // 
            // Account_Type_Label
            // 
            this.Account_Type_Label.AutoSize = true;
            this.Account_Type_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account_Type_Label.Location = new System.Drawing.Point(68, 192);
            this.Account_Type_Label.Name = "Account_Type_Label";
            this.Account_Type_Label.Size = new System.Drawing.Size(103, 16);
            this.Account_Type_Label.TabIndex = 20;
            this.Account_Type_Label.Text = "Account Type";
            // 
            // FName_Box
            // 
            this.FName_Box.Location = new System.Drawing.Point(232, 45);
            this.FName_Box.Name = "FName_Box";
            this.FName_Box.Size = new System.Drawing.Size(121, 20);
            this.FName_Box.TabIndex = 21;
            // 
            // LName_Box
            // 
            this.LName_Box.Location = new System.Drawing.Point(232, 138);
            this.LName_Box.Name = "LName_Box";
            this.LName_Box.Size = new System.Drawing.Size(100, 20);
            this.LName_Box.TabIndex = 22;
            // 
            // AccountType_Box
            // 
            this.AccountType_Box.FormattingEnabled = true;
            this.AccountType_Box.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "Admin",
            "Manager"});
            this.AccountType_Box.Location = new System.Drawing.Point(232, 187);
            this.AccountType_Box.Name = "AccountType_Box";
            this.AccountType_Box.Size = new System.Drawing.Size(121, 21);
            this.AccountType_Box.TabIndex = 23;
            this.AccountType_Box.Text = "Account Type";
            this.AccountType_Box.SelectedIndexChanged += new System.EventHandler(this.IndexChanged_Acc);
            // 
            // MName_Label
            // 
            this.MName_Label.AutoSize = true;
            this.MName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MName_Label.Location = new System.Drawing.Point(68, 93);
            this.MName_Label.Name = "MName_Label";
            this.MName_Label.Size = new System.Drawing.Size(146, 16);
            this.MName_Label.TabIndex = 25;
            this.MName_Label.Text = "Middle Name/ Initial";
            // 
            // MName_Box
            // 
            this.MName_Box.Location = new System.Drawing.Point(232, 88);
            this.MName_Box.Name = "MName_Box";
            this.MName_Box.Size = new System.Drawing.Size(100, 20);
            this.MName_Box.TabIndex = 26;
            // 
            // Select_Advisor_Button
            // 
            this.Select_Advisor_Button.Location = new System.Drawing.Point(232, 238);
            this.Select_Advisor_Button.Name = "Select_Advisor_Button";
            this.Select_Advisor_Button.Size = new System.Drawing.Size(100, 24);
            this.Select_Advisor_Button.TabIndex = 27;
            this.Select_Advisor_Button.Text = "Select Advisor";
            this.Select_Advisor_Button.UseVisualStyleBackColor = true;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(148, 345);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(138, 56);
            this.Add_Button.TabIndex = 28;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 458);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Select_Advisor_Button);
            this.Controls.Add(this.MName_Box);
            this.Controls.Add(this.MName_Label);
            this.Controls.Add(this.AccountType_Box);
            this.Controls.Add(this.LName_Box);
            this.Controls.Add(this.FName_Box);
            this.Controls.Add(this.Account_Type_Label);
            this.Controls.Add(this.Advisor_Label);
            this.Controls.Add(this.LName_Label);
            this.Controls.Add(this.FName_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyrightBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox copyrightBox;
        private System.Windows.Forms.Label FName_Label;
        private System.Windows.Forms.Label LName_Label;
        private System.Windows.Forms.Label Advisor_Label;
        private System.Windows.Forms.Label Account_Type_Label;
        private System.Windows.Forms.TextBox FName_Box;
        private System.Windows.Forms.TextBox LName_Box;
        private System.Windows.Forms.ComboBox AccountType_Box;
        private System.Windows.Forms.Label MName_Label;
        private System.Windows.Forms.TextBox MName_Box;
        private System.Windows.Forms.Button Select_Advisor_Button;
        private System.Windows.Forms.Button Add_Button;
    }
}