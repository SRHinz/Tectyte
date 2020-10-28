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
        private string accountType;


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
                    AccountDataGrid.Rows.Add(account.Value.FName, account.Value.LName, account.Key);
                else if (accountType == "F" && account.Value is Program.FacultyAcc)
                    AccountDataGrid.Rows.Add(account.Value.FName, account.Value.LName, account.Key);

            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
