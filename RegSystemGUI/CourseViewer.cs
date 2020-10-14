﻿using System;
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
        private Program.Account curAcc;
        private Program.StudentAcc curStuAcc;
        private Program.FactultyAcc curFacAcc;

        public CourseViewer(ref Program.RegistrationSystem coe, Options menu)     //By passing in these two variables, we should be able to display the courses to the readonly textbox upon creation of this form.
        {
            InitializeComponent();
            Menu = menu;
            coeC = coe.cData;
            regC = coe.registerC;
            CourseDataGrid.ColumnCount = 11;
            //CoursesGridBuild();
            curAcc = coe.uData.UDatabase[coe.CurAcc];
            if (curAcc is Program.StudentAcc)
            {
                curStuAcc = coe.uData.UDatabase[coe.CurAcc] as Program.StudentAcc;
                AddCourseButton.Show();
                FacCourseViewer.Hide();
                Back2Courses.Hide();
            }
            else if (curAcc is Program.FactultyAcc)
            {
                curFacAcc = coe.uData.UDatabase[coe.CurAcc] as Program.FactultyAcc;
                AddCourseButton.Hide();
                Back2Courses.Hide();
            }
            term = coe.NexTerm;
            regC.displayCourses(coeC, CourseDataGrid);
        }

        public void CourseViewerLoad()
        {

        }


        private void CoursesGridBuild()
        {
            CourseDataGrid.Columns[0].Name = "Course Number";
            CourseDataGrid.Columns[1].Name = "Course Name";
            CourseDataGrid.Columns[2].Name = "Instructor";
            CourseDataGrid.Columns[3].Name = "Total Seals";
            CourseDataGrid.Columns[4].Name = "Open Seats";
            CourseDataGrid.Columns[5].Name = "Credits";
            CourseDataGrid.Columns[6].Name = "Time Block 1";
            CourseDataGrid.Columns[7].Name = "Time Block 2";
            CourseDataGrid.Columns[8].Name = "Time Block 3";
            CourseDataGrid.Columns[9].Name = "Time Block 4";
            CourseDataGrid.Columns[10].Name = "Time Block 5";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void FacCourseView_Click(object sender, EventArgs e)
        {
            CourseDataGrid.Rows.Clear();
            regC.displayFacultyCourses(coeC, CourseDataGrid, curFacAcc.UserName);
            Back2Courses.Show();
            FacCourseViewer.Hide();
        }

        private void Back2Courses_Click(object sender, EventArgs e)
        {
            CourseDataGrid.Rows.Clear();
            regC.displayCourses(coeC, CourseDataGrid);
            FacCourseViewer.Show();
            Back2Courses.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {

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
                coeC.CDatabase[course.Trim()].enrollStudent(curStuAcc);
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
