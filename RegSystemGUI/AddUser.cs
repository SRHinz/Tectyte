using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegSystemGUI
{
    public partial class AddUser : Form
    {
        Program.UserDatabase uData;
        private string Advisor;
        private (string, string, string, string, string) UserData;
        private DialogResult status;

        public AddUser(ref Program.UserDatabase userDatabase)
        {
            InitializeComponent();
            uData = userDatabase;
        }

        private void IndexChanged_Acc(object sender, EventArgs e)
        {
            if (AccountType_Box.Text == "Student")
            {
                Advisor_Label.Show();
                Select_Advisor_Button.Show();
            }
            else
            {
                Advisor_Label.Hide();
                Select_Advisor_Button.Hide();
                Advisor = "N/A";
            }
        }

        private void Select_Advisor_Button_Click(object sender, EventArgs e)
        {
            AccountSelector AS = new AccountSelector(ref uData);
            AS.ShowDialog();
            Advisor = AS.getAccount();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if ((FName_Box.Text != " ") & (LName_Box.Text != " "))
            {
                if ((AccountType_Box.Text == "Student") & (Advisor == "N/A" ))
                {
                    DialogResult result = MessageBox.Show("Please select an advisor for the student, or click OK to set student advisor to staff", "Student Advisor not selected", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        UserData = (FName_Box.Text, MName_Box.Text, LName_Box.Text, AccountType_Box.Text.ToLower(), "staff");
                        status = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        //Nothing happenes, and the messagebox closes
                    }
                }
                else
                {
                    UserData = (FName_Box.Text, MName_Box.Text, LName_Box.Text, AccountType_Box.Text, Advisor);
                    status = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You have not input a first and/or last name for the user. Please do so before trying to add again.", "Missing First or Last Name");
            }
            
        }

        public (string, string, string, string, string) getUserData
        {
            get
            {
                return UserData;
            }
        }

        public DialogResult returnStatus
        {
            get
            {
                return status;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            status = DialogResult.Cancel;
            this.Close();
        }
    }
}
