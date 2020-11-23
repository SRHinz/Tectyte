namespace RegSystemGUI
{
    partial class EditTimeBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTimeBlock));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.HourStart = new System.Windows.Forms.NumericUpDown();
            this.MinuteStart = new System.Windows.Forms.NumericUpDown();
            this.AMStart = new System.Windows.Forms.CheckBox();
            this.PMStart = new System.Windows.Forms.CheckBox();
            this.to = new System.Windows.Forms.Label();
            this.HourEnd = new System.Windows.Forms.NumericUpDown();
            this.MinuteEnd = new System.Windows.Forms.NumericUpDown();
            this.AMEnd = new System.Windows.Forms.CheckBox();
            this.PMEnd = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit_Changes_Button = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HourStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(52, 204);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Monday";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(193, 204);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 24);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Tuesday";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(353, 204);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(118, 24);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Wednesday";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(528, 204);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 24);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Thursday";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(681, 204);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(77, 24);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Friday";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // HourStart
            // 
            this.HourStart.Location = new System.Drawing.Point(101, 76);
            this.HourStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HourStart.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.HourStart.Name = "HourStart";
            this.HourStart.Size = new System.Drawing.Size(63, 22);
            this.HourStart.TabIndex = 6;
            // 
            // MinuteStart
            // 
            this.MinuteStart.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MinuteStart.Location = new System.Drawing.Point(173, 76);
            this.MinuteStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinuteStart.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MinuteStart.Name = "MinuteStart";
            this.MinuteStart.Size = new System.Drawing.Size(63, 22);
            this.MinuteStart.TabIndex = 7;
            // 
            // AMStart
            // 
            this.AMStart.AutoSize = true;
            this.AMStart.Location = new System.Drawing.Point(245, 60);
            this.AMStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AMStart.Name = "AMStart";
            this.AMStart.Size = new System.Drawing.Size(50, 21);
            this.AMStart.TabIndex = 8;
            this.AMStart.Text = "AM";
            this.AMStart.UseVisualStyleBackColor = true;
            this.AMStart.CheckedChanged += new System.EventHandler(this.AMStart_CheckedChanged);
            // 
            // PMStart
            // 
            this.PMStart.AutoSize = true;
            this.PMStart.Location = new System.Drawing.Point(245, 90);
            this.PMStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PMStart.Name = "PMStart";
            this.PMStart.Size = new System.Drawing.Size(50, 21);
            this.PMStart.TabIndex = 9;
            this.PMStart.Text = "PM";
            this.PMStart.UseVisualStyleBackColor = true;
            this.PMStart.CheckedChanged += new System.EventHandler(this.PMStart_CheckedChanged);
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.Location = new System.Drawing.Point(389, 66);
            this.to.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(48, 29);
            this.to.TabIndex = 10;
            this.to.Text = "TO";
            // 
            // HourEnd
            // 
            this.HourEnd.Location = new System.Drawing.Point(513, 74);
            this.HourEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HourEnd.Name = "HourEnd";
            this.HourEnd.Size = new System.Drawing.Size(63, 22);
            this.HourEnd.TabIndex = 11;
            // 
            // MinuteEnd
            // 
            this.MinuteEnd.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MinuteEnd.Location = new System.Drawing.Point(581, 74);
            this.MinuteEnd.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MinuteEnd.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MinuteEnd.Name = "MinuteEnd";
            this.MinuteEnd.Size = new System.Drawing.Size(63, 22);
            this.MinuteEnd.TabIndex = 12;
            // 
            // AMEnd
            // 
            this.AMEnd.AutoSize = true;
            this.AMEnd.Location = new System.Drawing.Point(655, 60);
            this.AMEnd.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.AMEnd.Name = "AMEnd";
            this.AMEnd.Size = new System.Drawing.Size(50, 21);
            this.AMEnd.TabIndex = 13;
            this.AMEnd.Text = "AM";
            this.AMEnd.UseVisualStyleBackColor = true;
            this.AMEnd.CheckedChanged += new System.EventHandler(this.AMEnd_CheckedChanged);
            // 
            // PMEnd
            // 
            this.PMEnd.AutoSize = true;
            this.PMEnd.Location = new System.Drawing.Point(655, 90);
            this.PMEnd.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PMEnd.Name = "PMEnd";
            this.PMEnd.Size = new System.Drawing.Size(50, 21);
            this.PMEnd.TabIndex = 14;
            this.PMEnd.Text = "PM";
            this.PMEnd.UseVisualStyleBackColor = true;
            this.PMEnd.CheckedChanged += new System.EventHandler(this.PMEnd_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(533, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ending Time";
            // 
            // Submit_Changes_Button
            // 
            this.Submit_Changes_Button.Location = new System.Drawing.Point(294, 272);
            this.Submit_Changes_Button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Submit_Changes_Button.Name = "Submit_Changes_Button";
            this.Submit_Changes_Button.Size = new System.Drawing.Size(89, 46);
            this.Submit_Changes_Button.TabIndex = 16;
            this.Submit_Changes_Button.Text = "Submit";
            this.Submit_Changes_Button.UseVisualStyleBackColor = true;
            this.Submit_Changes_Button.Click += new System.EventHandler(this.Submit_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(458, 272);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 46);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditTimeBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 335);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.Submit_Changes_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PMEnd);
            this.Controls.Add(this.AMEnd);
            this.Controls.Add(this.MinuteEnd);
            this.Controls.Add(this.HourEnd);
            this.Controls.Add(this.to);
            this.Controls.Add(this.PMStart);
            this.Controls.Add(this.AMStart);
            this.Controls.Add(this.MinuteStart);
            this.Controls.Add(this.HourStart);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditTimeBlock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Time Block";
            ((System.ComponentModel.ISupportInitialize)(this.HourStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.NumericUpDown HourStart;
        private System.Windows.Forms.NumericUpDown MinuteStart;
        private System.Windows.Forms.CheckBox AMStart;
        private System.Windows.Forms.CheckBox PMStart;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.NumericUpDown HourEnd;
        private System.Windows.Forms.NumericUpDown MinuteEnd;
        private System.Windows.Forms.CheckBox AMEnd;
        private System.Windows.Forms.CheckBox PMEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submit_Changes_Button;
        private System.Windows.Forms.Button cancelButton;
    }
}