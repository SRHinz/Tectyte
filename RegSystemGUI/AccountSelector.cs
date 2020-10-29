using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegSystemGUI
{
    public partial class AccountSelector : Form
    {

        private Program.UserDatabase coeData;
        private string accountType, username;
        private bool accountChosen = false;


        public AccountSelector(ref Program.UserDatabase uData, string type)
        {
            coeData = uData;
            accountType = type;
            InitializeComponent();
        }


        private void AccountSelector_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, Program.Account> account in coeData.UDatabase)
            {
                if (accountType == "S" && account.Value is Program.StudentAcc)
                    AccountDataGrid.Rows.Add(account.Value.LName, account.Value.FName, account.Key);
                else if (accountType == "F" && account.Value is Program.FacultyAcc)
                    AccountDataGrid.Rows.Add(account.Value.LName, account.Value.FName, account.Key);

            }

        }

        public string getAccount()
        {
            return username;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AccountDataGrid.Rows.Clear();
            int length = textBox1.Text.Length;
            foreach (KeyValuePair<string, Program.Account> account in coeData.UDatabase)
            {
                if (length <= account.Value.LName.Length)
                {
                    if (accountType == "S" && account.Value is Program.StudentAcc)
                    {
                        if (textBox1.Text == account.Value.LName.Substring(0, length))
                            AccountDataGrid.Rows.Add(account.Value.LName, account.Value.FName, account.Key);
                    }
                    else if (accountType == "F" && account.Value is Program.FacultyAcc)
                    {
                        if (textBox1.Text == account.Value.LName.Substring(0, length))
                            AccountDataGrid.Rows.Add(account.Value.LName, account.Value.FName, account.Key);
                    }
                }

            }
        }

        private void AccountDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            username = AccountDataGrid.Rows[AccountDataGrid.CurrentCell.RowIndex].Cells[2].Value.ToString().Trim();
            this.Close();
        }
    }
}
