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
    public partial class studentsEnrolled : Form
    {
        private CourseViewer cV;
        private Options menu;
        public studentsEnrolled(ref Program.FacultyAcc facultyAcc, ref Program.CourseDatabase courseData, CourseViewer courseViewer, Options Menu)
        {
            InitializeComponent();
            cV = courseViewer;
            menu = Menu;
        }

        private void studentsEnrolled_Load(object sender, EventArgs e)
        {

        }

        private void MenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void courseReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            cV.Show();
        }
    }
}
