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
        public studentsEnrolled(ref Program.FacultyAcc facultyAcc, ref Program.CourseDatabase courseData)
        {
            InitializeComponent();
        }

        private void studentsEnrolled_Load(object sender, EventArgs e)
        {

        }
    }
}
