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
    public partial class Form1 : Form
    {
        private Program.RegistrationSystem COE = new Program.RegistrationSystem();
        public Form1(Program.RegistrationSystem coe)
        {
            InitializeComponent();
            COE = coe;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string tempUN, tempPW;
            tempUN = UsernameInput.Text;
            tempPW = PasswordText.Text;
            if (COE.uData.authenticateUser(tempUN, tempPW) != "Failed")
            {
                this.Hide();
                Form2 options = new Form2();
                options.Show();
            }
        }
    }
}
