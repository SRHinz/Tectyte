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
    public partial class StudentSelector : Form
    {
        private string studentUser;
        public StudentSelector()
        {
            InitializeComponent();
            textBox1.Clear();
        }

        public string button1_Click(object Sender, EventArgs e)
        {
            return this.textBox1.Text;
            this.Hide();
        }

        public string getStudent
        {
            get
            {
                return this.textBox1.Text;
            }
        }
    }
}
