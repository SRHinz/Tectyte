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
    public partial class CourseViewer : Form
    {
        private Program.CourseDatabase coeC = new Program.CourseDatabase();
        private Program.viewCourses viewC = new Program.viewCourses();
        public CourseViewer(ref Program.CourseDatabase courseD, ref Program.viewCourses vC)     //By passing in these two variables, we should be able to display the courses to the readonly textbox upon creation of this form.
        {
            InitializeComponent();
            coeC = courseD;
            viewC = vC;
            vC.displayCourses(coeC, CourseDisplays);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
