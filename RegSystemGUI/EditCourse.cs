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
    public partial class EditCourse : Form
    {
        Program.CourseDatabase CDATA;
        Program.Course Course;
        string cN;
        Program.viewCourses VC = new Program.viewCourses();
        Program.UserDatabase UD;
        public EditCourse(ref Program.CourseDatabase cData, ref Program.UserDatabase U, string cName)
        {
            InitializeComponent();
            CDATA = cData;
            Course = CDATA.CDatabase[cName];
            cN = cName;
            UD = U;
            Instructor_Box.Text = Course.Instructor;
            TB1_Box.Text = VC.solveTimeblock(Course.TimeBlock1);
            if (Course.TimeBlock2 == 0)
            {
                EditTB2Button.Hide();
            }
            TB2_Box.Text = VC.solveTimeblock(Course.TimeBlock2);
            if (Course.TimeBlock3 == 0)
            {
                EditTB3Button.Hide();
            }
            TB3_Box.Text = VC.solveTimeblock(Course.TimeBlock3);
            if (Course.TimeBlock4 == 0)
            {
                EditTB4Button.Hide();
            }
            TB4_Box.Text = VC.solveTimeblock(Course.TimeBlock4);
            if (Course.TimeBlock5 == 0)
            {
                EditTB5Button.Hide();
            }
            TB5_Box.Text = VC.solveTimeblock(Course.TimeBlock5);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EditInstructorButton_Click(object sender, EventArgs e)
        {
            AccountSelector AS = new AccountSelector(ref UD, "F");
            AS.ShowDialog();
            Instructor_Box.Text = AS.getAccount();
            CDATA.CDatabase[cN].changeInstructor(AS.getAccount());
        }

        private void EditTB1Button_Click(object sender, EventArgs e)
        {

        }
    }
}
