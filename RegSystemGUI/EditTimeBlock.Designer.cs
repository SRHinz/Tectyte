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
            ((System.ComponentModel.ISupportInitialize)(this.HourStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(39, 165);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Monday";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(145, 165);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 20);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Tuesday";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(265, 165);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 20);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Wednesday";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(396, 165);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(84, 20);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Thursday";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(511, 165);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(65, 20);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Friday";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // HourStart
            // 
            this.HourStart.Location = new System.Drawing.Point(76, 61);
            this.HourStart.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.HourStart.Name = "HourStart";
            this.HourStart.Size = new System.Drawing.Size(47, 20);
            this.HourStart.TabIndex = 6;
            // 
            // MinuteStart
            // 
            this.MinuteStart.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MinuteStart.Location = new System.Drawing.Point(130, 60);
            this.MinuteStart.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MinuteStart.Name = "MinuteStart";
            this.MinuteStart.Size = new System.Drawing.Size(40, 20);
            this.MinuteStart.TabIndex = 7;
            // 
            // AMStart
            // 
            this.AMStart.AutoSize = true;
            this.AMStart.Location = new System.Drawing.Point(184, 49);
            this.AMStart.Name = "AMStart";
            this.AMStart.Size = new System.Drawing.Size(42, 17);
            this.AMStart.TabIndex = 8;
            this.AMStart.Text = "AM";
            this.AMStart.UseVisualStyleBackColor = true;
            // 
            // PMStart
            // 
            this.PMStart.AutoSize = true;
            this.PMStart.Location = new System.Drawing.Point(184, 73);
            this.PMStart.Name = "PMStart";
            this.PMStart.Size = new System.Drawing.Size(42, 17);
            this.PMStart.TabIndex = 9;
            this.PMStart.Text = "PM";
            this.PMStart.UseVisualStyleBackColor = true;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.Location = new System.Drawing.Point(272, 63);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(37, 24);
            this.to.TabIndex = 10;
            this.to.Text = "TO";
            // 
            // HourEnd
            // 
            this.HourEnd.Location = new System.Drawing.Point(385, 60);
            this.HourEnd.Name = "HourEnd";
            this.HourEnd.Size = new System.Drawing.Size(47, 20);
            this.HourEnd.TabIndex = 11;
            // 
            // EditTimeBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 250);
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
            this.Name = "EditTimeBlock";
            this.Text = "EditTimeBlock";
            ((System.ComponentModel.ISupportInitialize)(this.HourStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourEnd)).EndInit();
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
    }
}