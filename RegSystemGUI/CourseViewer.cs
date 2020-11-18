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
        private Program.RegistrationSystem COE;

        public CourseViewer(ref Program.RegistrationSystem coe, Options menu)     //By passing in these two variables, we should be able to display the courses to the readonly textbox upon creation of this form.
        {
            InitializeComponent();
            Menu = menu;
            coeC = coe.cData;
            regC = coe.registerC;
            COE = coe;
            CourseDataGrid.ColumnCount = 11;
            curAcc = coe.uData.UDatabase[coe.CurAcc];
            FacultyCourseSelector.SelectedItem = "All Courses";
            studentsEnrolled.Hide();
            searchBox.Clear();
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
                //FacultyCourseSelector.Show();
            }
            else if (curAcc is Program.AdminAcc)
            {
                AddCourseButton.Show();

            }
            term = coe.NexTerm;
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
                searchBox.Visible = false;
                searchLabel.Visible = false;
                AddCourseButton.Visible = false;
                if (curAcc is Program.FacultyAcc)
                {
                    regC.displayFacultyCourses(coeC, CourseDataGrid, curAcc.UserName);
                    studentsEnrolled.Show();
                }
                else
                {
                    AccountSelector AS = new AccountSelector(ref COE.uData);
                    AS.DisplayFacultyAccounts();
                    CourseDataGrid.Rows.Clear();
                    AS.ShowDialog();
                    if (AS.getAccount() != null)
                    {
                        regC.displayFacultyCourses(coeC, CourseDataGrid, AS.getAccount());
                        studentsEnrolled.Show();
                    }
                    else
                    {
                        FacultyCourseSelector.SelectedIndex = 0;
                    }
                }
                
            }    
        }

        private void studentsEnrolled_Click(object sender, EventArgs e)
        {
            int rowIndex = CourseDataGrid.CurrentCell.RowIndex;
            DataGridViewCellCollection row = CourseDataGrid.Rows[rowIndex].Cells;
            DataGridViewCell cell = row[0];
            course = cell.Value.ToString().Trim();
            stuEnrolled = new studentsEnrolled(ref COE, ref coeC, this, Menu, course);
            stuEnrolled.Show();
            this.Hide();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (curAcc is Program.AdminAcc)
            {
                AccountSelector AS = new AccountSelector(ref COE.uData);
                AS.DisplayStudentAccounts();
                AS.ShowDialog();
                if (COE.uData.UDatabase[AS.getAccount()] is Program.StudentAcc)
                {
                    CourseAdd(COE.uData.UDatabase[AS.getAccount()] as Program.StudentAcc, true);
                }
                else
                {
                    MessageBox.Show("No student account with that username exists.");
                }
            }
            else if (curAcc is Program.StudentAcc)
            {
                CourseAdd(curStuAcc, false);
            }
        }

        private void CourseViewer_Load(object sender, EventArgs e)
        {

        }


        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            CourseDataGrid.Rows.Clear();
            foreach (string course in coeC.CDatabase.Keys)
            {
                if (course.Contains(searchBox.Text.ToUpper()))
                {
                    regC.displaySearchCourses(coeC, CourseDataGrid, course);
                }
            }
        }


        private void CourseAdd(Program.StudentAcc student, bool admin)
        {
            int rowIndex = CourseDataGrid.CurrentCell.RowIndex;
            DataGridViewCellCollection row = CourseDataGrid.Rows[rowIndex].Cells;
            DataGridViewCell cell = row[0];
            course = cell.Value.ToString().Trim();
            int error = 100;
            try
            {
                if (!admin)
                {
                    error = regC.stuRegister(student, coeC.CDatabase[course], course.Trim(), term.Trim(), false);
                }
                else if (curAcc is Program.AdminAcc)
                {
                    error = regC.stuRegister(student, coeC.CDatabase[course], course.Trim(), term.Trim(), true);
                }
                coeC.CDatabase[course.Trim()].enrollStudent(student.UserName);
                CourseDataGrid.Rows.Clear();
                regC.displayCourses(coeC, CourseDataGrid);
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
                else if (eMsg.Contains("prereqs"))
                {
                    MessageBox.Show("Have not taken required prerequisites");
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
