﻿using System;
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
    public partial class changeAdvisor : Form
    {
        private Options Menu;
        public changeAdvisor(ref Program.RegistrationSystem coe, Options menu)
        {
            InitializeComponent();
            Menu = menu;
        }

        private void changeAdvisor_Load(object sender, EventArgs e)
        {

        }

        private void MenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.Show();
        }
    }
}