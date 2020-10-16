using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegSystemGUI
{
    public partial class CourseViewer : Form
    {
        private Program.CourseDatabase coeC;
        private Program.Register regC;
        private string course, term, grade;
        private float credits;
        private Options Menu;
        private studentsEnrolled stuEnrolled;
        private Program.Account curAcc;
        private Program.StudentAcc curStuAcc;
        private Program.FacultyAcc curFacAcc;

        public CourseViewer(ref Program.RegistrationSystem coe, Options menu)     //By passing in these two variables, we should be able to display the courses to the readonly textbox upon creation of this form.
        {
            InitializeComponent();
            Menu = menu;
            coeC = coe.cData;
            regC = coe.registerC;
            CourseDataGrid.ColumnCount = 11;
            //CoursesGridBuild();
            curAcc = coe.uData.UDatabase[coe.CurAcc];
            FacultyCourseSelector.SelectedItem = "All Courses";
            studentsEnrolled.Hide();
            if (curAcc is Program.StudentAcc)
            {
                curStuAcc = coe.uData.UDatabase[coe.CurAcc] as Program.StudentAcc;
                AddCourseButton.Show();
                FacultyCourseSelector.Hide();
            }
            else if (curAcc is Program.FacultyAcc)
            {
                curFacAcc = coe.uData.UDatabase[coe.CurAcc] as Program.FacultyAcc;
                AddCourseButton.Hide();
                FacultyCourseSelector.Show();
            }
            term = coe.NexTerm;
            regC.displayCourses(coeC, CourseDataGrid);
        }

        public void CourseViewerLoad()
        {

        }



        private void FacultyCourseSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FacultyCourseSelector.SelectedItem.ToString() == "All Courses")
            {
                CourseDataGrid.Rows.Clear();
                regC.displayCourses(coeC, CourseDataGrid);
                studentsEnrolled.Hide();
            }
            else if (FacultyCourseSelector.SelectedItem.ToString() == "My Courses")
            {
                CourseDataGrid.Rows.Clear();
                regC.displayFacultyCourses(coeC, CourseDataGrid, curFacAcc.UserName);
                studentsEnrolled.Show();
            }    
        }

        private void studentsEnrolled_Click(object sender, EventArgs e)
        {
            stuEnrolled = new studentsEnrolled(ref curFacAcc, ref coeC);
            stuEnrolled.Show();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            int rowIndex = CourseDataGrid.CurrentCell.RowIndex;
            DataGridViewCellCollection row = CourseDataGrid.Rows[rowIndex].Cells;
            DataGridViewCell cell = row[0];
            course = cell.Value.ToString().Trim();
            int error = 100;
            try
            {
                error = regC.stuRegister(curStuAcc, coeC.CDatabase[course], course.Trim(), term.Trim());
                coeC.CDatabase[course.Trim()].enrollStudent(curAcc.UserName);
            }
            catch (Program.regConflictException f)         //If one of the three issues throws and error in stuRegister, the student won't be registered for the course. 
            { 
                string eMsg = f.ToString();
                if (eMsg.Contains("duplicate"))
                {
                    MessageBox.Show("Cannot add duplicate course.");
                }
                else if (eMsg.Contains("credits"))
                {
                    MessageBox.Show("You are registered for too many credits.");
               }
                else if (eMsg.Contains("seats"))
                {
                    MessageBox.Show("No available seats.");
                }
                else
                    MessageBox.Show(eMsg);
            }

            if (error == 0)
            {
                MessageBox.Show("Course added successfully.");
            }

            else if (error == 1)
            {
                MessageBox.Show("Course added. Please note: there is a time conflict with this course and one or more courses you are registered for.");

            }
            else if (error == 2)
            {
                MessageBox.Show("Course added. Please note: You have already previously taken this course.");
            }
            else if (error == 3)
            {
                MessageBox.Show("Course added. Please note: there is a time conflict between this course and one or more courses you are registered for. In addition, you have already previously completed this course.");
            }
        }

        private void MenuReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Menu.Show();
        }


    }
}
