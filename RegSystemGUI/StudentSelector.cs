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
    public partial class StudentSelector : Form
    {
        public StudentSelector()
        {
            InitializeComponent();
            textBox1.Clear();
        }

        public string getStudent
        {
            get
            {
                return this.textBox1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentSelector_Load(object sender, EventArgs e)
        {

        }
    }
}