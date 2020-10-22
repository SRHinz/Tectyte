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
       
        public studentsEnrolled(ref Program.RegistrationSystem coe, ref Program.CourseDatabase courseData, CourseViewer courseViewer, Options Menu, string course)
        {
            InitializeComponent();
            cV = courseViewer;
            menu = Menu;
            noEnrolledBox.Hide();
            foreach (string student in courseData.CDatabase[course].EnrolledStudents)
            {
                enrolledStudentList.Items.Add((coe.uData.UDatabase[student].UserName + " | " + coe.uData.UDatabase[student].FName + " " + coe.uData.UDatabase[student].LName));
            }
            if (enrolledStudentList.Items.Count == 0)
            {
                noEnrolledBox.Show();
            }
            courseBox.Text = course;
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
