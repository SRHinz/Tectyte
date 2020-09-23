﻿using System;
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
                this.Hide();
                Options options = new Options(ref COE);
                options.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}