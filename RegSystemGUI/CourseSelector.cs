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
    public partial class CourseSelector : Form
    {
        Program.RegistrationSystem COE;
        public CourseSelector(ref Program.RegistrationSystem iSys)
        {
            InitializeComponent();
            COE = iSys;
            COE.vCourse.displayCourses(COE.cData, courseModifierView);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
