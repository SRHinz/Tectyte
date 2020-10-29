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
            this.AccountDataGrid = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountDataGrid
            // 
            this.AccountDataGrid.AllowUserToAddRows = false;
            this.AccountDataGrid.AllowUserToDeleteRows = false;
            this.AccountDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AccountDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AccountDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Username});
            this.AccountDataGrid.Location = new System.Drawing.Point(12, 12);
            this.AccountDataGrid.Name = "AccountDataGrid";
            this.AccountDataGrid.ReadOnly = true;
            this.AccountDataGrid.RowHeadersWidth = 51;
            this.AccountDataGrid.RowTemplate.Height = 24;
            this.AccountDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountDataGrid.Size = new System.Drawing.Size(435, 394);
            this.AccountDataGrid.TabIndex = 0;
            this.AccountDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountDataGrid_CellContentClick);
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 105;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 105;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 102;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(648, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(494, 35);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(148, 17);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search by Last Name:";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(684, 95);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(96, 37);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // AccountSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(988, 534);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AccountDataGrid);
            this.Name = "AccountSelector";
            this.Text = "Account Selector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccountSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataGrid)).EndInit();
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
    }
}