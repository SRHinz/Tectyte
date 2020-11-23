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
    public partial class CourseEnter2 : Form
    {
        private string courseName;
        public CourseEnter2()
        {
            InitializeComponent();
        }

        private void CourseEnter_Load(object sender, EventArgs e)
        {

        }

        public string getcourseName
        {
            get
            {
                return courseName;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.TextLength > 7) | !((textBox1.Text.ElementAt(2).Equals('-')) | (textBox1.Text.ElementAt(3).Equals('-'))))
            {
                try
                {
                    Convert.ToInt32((textBox1.Text.Substring(textBox1.TextLength - 3)));
                    courseName = textBox1.Text;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("You have entered an improper course name", "Improper Course Name");
                }
            }
        }
    }
}
