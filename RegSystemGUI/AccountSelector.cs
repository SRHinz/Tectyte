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
        private string accountType = "student";
        private string username;


        public AccountSelector(ref Program.UserDatabase uData)
        {
            coeData = uData;
            InitializeComponent();
            DisplayAccounts();
        }

        public AccountSelector(ref Program.UserDatabase uData, string type)
        {
            coeData = uData;
            accountType = type;
            InitializeComponent();
            DisplayAccounts();
        }


        private void DisplayAccounts()
        {
            foreach (string acc in coeData.UDatabase.Keys)
            {
                if (accountType == "student")
                {
                    if (coeData.UDatabase[acc].Status != "faculty" && coeData.UDatabase[acc].Status != "admin")
                    {
                        AccountDataGrid.Rows.Add(coeData.UDatabase[acc].LName, coeData.UDatabase[acc].FName, coeData.UDatabase[acc].UserName);
                    }
                }
                else if (coeData.UDatabase[acc].Status == accountType)
                {
                    AccountDataGrid.Rows.Add(coeData.UDatabase[acc].LName, coeData.UDatabase[acc].FName, coeData.UDatabase[acc].UserName);
                }
            }
            //foreach (KeyValuePair<string, Program.Account> account in coeData.UDatabase)
            //{
            //    if (accountType == "S" && account.Value is Program.StudentAcc)
            //        AccountDataGrid.Rows.Add(account.Value.LName, account.Value.FName, account.Key);
            //    else if (accountType == "F" && account.Value is Program.FacultyAcc)
            //        AccountDataGrid.Rows.Add(account.Value.LName, account.Value.FName, account.Key);

            //}

        }

        public void DisplayStudentAccounts()
        {
            AccountDataGrid.Rows.Clear();
            accountType = "student";
            DisplayAccounts();
        }

        public void DisplayFacultyAccounts()
        {
            AccountDataGrid.Rows.Clear();
            accountType = "faculty";
            DisplayAccounts();
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
                        if (textBox1.Text.ToLower() == account.Value.LName.Substring(0, length).ToLower())
                            AccountDataGrid.Rows.Add(account.Value.LName, account.Value.FName, account.Key);
                    }
                    else if (accountType == "F" && account.Value is Program.FacultyAcc)
                    {
                        if (textBox1.Text.ToLower() == account.Value.LName.Substring(0, length).ToLower())
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
