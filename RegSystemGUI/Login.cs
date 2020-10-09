using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegSystemGUI
{
    public partial class Login : Form
    {

        private Program.RegistrationSystem COE = new Program.RegistrationSystem();

        public Login(ref Program.RegistrationSystem coe)
        {
            InitializeComponent();
            COE = coe;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            string tempUN, tempPW;
            tempUN = UsernameInput.Text;
            tempPW = PasswordInput.Text;
            if (COE.uData.authenticateUser(tempUN, tempPW) != "Failed")
            {
                COE.CurAcc = (tempUN, tempPW);
                this.Hide();
                Options options = new Options(ref COE, COE.uData.authenticateUser(tempUN, tempPW), tempUN, tempPW, this);
                UsernameInput.Clear();
                PasswordInput.Clear();
                options.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                UsernameInput.Clear();
                PasswordInput.Clear();
            }
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
