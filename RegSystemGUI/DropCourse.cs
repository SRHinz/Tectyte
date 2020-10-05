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
    public partial class DropCourse : Form
    {
        private stuCourseHist StuHist;
        private Program.StudentAcc account;
        private Program.viewCourses vCourses;
        private Program.CourseDatabase cData;
        private string currentTerm;

        public DropCourse(Program.StudentAcc studentAcc, ref Program.CourseDatabase courseData, Program.viewCourses viewC, string cTerm, stuCourseHist stuHis)
        {
            InitializeComponent();
            StuHist = stuHis;
            cData = courseData;
            account = studentAcc;
            vCourses = viewC;
            currentTerm = cTerm;
        }

        private void DropCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StuHist.Show();
        }
    }
}
