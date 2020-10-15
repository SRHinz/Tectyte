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
            this.AdviseeViewGrid = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AdviseeViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdviseeViewGrid
            // 
            this.AdviseeViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdviseeViewGrid.Location = new System.Drawing.Point(13, 13);
            this.AdviseeViewGrid.Name = "AdviseeViewGrid";
            this.AdviseeViewGrid.ReadOnly = true;
            this.AdviseeViewGrid.RowHeadersWidth = 123;
            this.AdviseeViewGrid.RowTemplate.Height = 46;
            this.AdviseeViewGrid.Size = new System.Drawing.Size(941, 680);
            this.AdviseeViewGrid.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1034, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 45);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Current Term";
            // 
            // adviseeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 705);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AdviseeViewGrid);
            this.Name = "adviseeView";
            this.Text = "adviseeView";
            ((System.ComponentModel.ISupportInitialize)(this.AdviseeViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AdviseeViewGrid;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}