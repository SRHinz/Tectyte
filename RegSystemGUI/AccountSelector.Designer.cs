namespace RegSystemGUI
{
    partial class AccountSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSelector));
            this.AccountDataGrid = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyrightBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountDataGrid
            // 
            this.AccountDataGrid.AllowUserToAddRows = false;
            this.AccountDataGrid.AllowUserToDeleteRows = false;
            this.AccountDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AccountDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Username});
            this.AccountDataGrid.Location = new System.Drawing.Point(19, 51);
            this.AccountDataGrid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AccountDataGrid.Name = "AccountDataGrid";
            this.AccountDataGrid.ReadOnly = true;
            this.AccountDataGrid.RowHeadersWidth = 10;
            this.AccountDataGrid.RowTemplate.Height = 24;
            this.AccountDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountDataGrid.Size = new System.Drawing.Size(696, 630);
            this.AccountDataGrid.TabIndex = 0;
            this.AccountDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountDataGrid_CellContentClick);
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1037, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(790, 56);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(224, 25);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search by Last Name:";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(1094, 152);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(154, 59);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 808);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // copyrightBox
            // 
            this.copyrightBox.BackColor = System.Drawing.SystemColors.Control;
            this.copyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyrightBox.Location = new System.Drawing.Point(451, 816);
            this.copyrightBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.copyrightBox.Name = "copyrightBox";
            this.copyrightBox.Size = new System.Drawing.Size(443, 24);
            this.copyrightBox.TabIndex = 14;
            this.copyrightBox.Text = "this software is property of tectyte ©2020";
            this.copyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(920, 538);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(288, 82);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select An Account";
            // 
            // AccountSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1314, 854);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyrightBox);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AccountDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AccountSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Selector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountDataGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox copyrightBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
    }
}