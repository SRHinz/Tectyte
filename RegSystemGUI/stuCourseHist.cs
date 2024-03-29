﻿using System;
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
    public partial class stuCourseHist : Form
    {
        private Options Menu;
        private Program.StudentAcc account;
        private Program.viewCourses vCourses;
        private Program.CourseDatabase cData;
        private string currentTerm;
        private string nextTerm;
        private int rowIndex;
        public stuCourseHist(ref Program.StudentAcc studentAcc, ref Program.CourseDatabase courseData, Program.viewCourses viewC, string cTerm, string nTerm, Options menu)
        {

            InitializeComponent();
            DropButton.Hide();
            warningBox.Hide();
            warningBox2.Hide();
            GPABox.Hide();
            CreditsEarnedBox.Hide();
            GPALabel.Hide();
            NumCreditsEarnedLabel.Hide();
            courseSchedule.Hide();
            CourseDataGrid.ColumnCount = 4;
            cData = courseData;
            account = studentAcc;
            vCourses = viewC;
            Menu = menu;
            currentTerm = cTerm;
            nextTerm = nTerm;
            TermSelectorBox.SelectedIndex = 0;
            
        }


        private void MenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.Show();
        }

        private void TermSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TermSelectorBox.SelectedItem.ToString() == "Course History")
            {
                DropButton.Visible = false;
                warningBox.Visible = false;
                warningBox2.Visible = false;
                courseSchedule.Visible = false;
                CourseDataGrid.Visible = true;
                GPABox.Visible = true;
                CreditsEarnedBox.Visible = true;
                GPALabel.Visible = true;
                NumCreditsEarnedLabel.Visible = true;
                CourseDataGrid.Rows.Clear();
                vCourses.displayStuHist(account, CourseDataGrid, "History", currentTerm, cData);
                if (CourseDataGrid.Rows.Count == 0)
                {
                    warningBox.Show();
                }
                CreditsEarnedBox.Text = account.totalCredits.ToString();
                GPABox.Text = account.GPA.ToString();
            }

            else if (TermSelectorBox.SelectedItem.ToString() == "Current Courses")
            {
                DropButton.Visible = false;
                warningBox.Visible = false;
                warningBox2.Visible = false;
                courseSchedule.Visible = false;
                CourseDataGrid.Visible = true;
                GPABox.Visible = false;
                CreditsEarnedBox.Visible = false;
                GPALabel.Visible = false;
                NumCreditsEarnedLabel.Visible = false;
                CourseDataGrid.Rows.Clear();
                vCourses.displayStuHist(account, CourseDataGrid, "Current", currentTerm, cData);
                if (CourseDataGrid.Rows.Count == 0)
                {
                    warningBox.Show();
                    DropButton.Hide();
                }
            }

            else if (TermSelectorBox.SelectedItem.ToString() == "Future Courses")
            {
                DropButton.Visible = true;
                warningBox.Visible = false;
                warningBox2.Visible = false;
                courseSchedule.Visible = true;
                CourseDataGrid.Visible = false;
                GPABox.Visible = false;
                CreditsEarnedBox.Visible = false;
                GPALabel.Visible = false;
                NumCreditsEarnedLabel.Visible = false;
                courseSchedule.Rows.Clear();
                vCourses.displayStuHist(account, courseSchedule, "Future", currentTerm, cData);
                if (courseSchedule.Rows.Count == 0)
                {
                    warningBox.Show();
                    DropButton.Hide();
                }
                try
                {
                    foreach (Program.sHistory course in (account.CHistory))
                    {
                        if (course.Term == nextTerm & course.Grade == "N")
                        {
                            string[] courseTB1 = new string[cData.CDatabase[course.Course.Trim()].NtimeBlocks];
                            for (int i = 0; i < courseTB1.Length; i++)
                            {
                                courseTB1[i] = vCourses.solveTimeblock(cData.CDatabase[course.Course.Trim()].TimeBlockCollection[i]).Trim();
                            }
                            foreach (Program.sHistory course2 in (account).CHistory)
                            {
                                if ((course.Course != course2.Course) & (course2.Term == nextTerm) & (course2.Grade == "N"))
                                {
                                    string[] courseTB2 = new string[cData.CDatabase[course2.Course.Trim()].NtimeBlocks];
                                    for (int i = 0; i < courseTB2.Length; i++)
                                    {
                                        courseTB2[i] = vCourses.solveTimeblock(cData.CDatabase[course2.Course].TimeBlockCollection[i]).Trim();
                                    }
                                    if (vCourses.timeConflict(courseTB1, cData.CDatabase[course.Course].TimeBlockCollection, courseTB2, cData.CDatabase[course2.Course].TimeBlockCollection, false))
                                    {
                                        throw new Program.regConflictException();
                                    }
                                }
                            }
                        }

                    }
                }
                catch (Program.regConflictException alpha)
                {
                    MessageBox.Show("There is a time conflict between one or more courses");
                    warningBox2.Show();
                }

            }
        }

        private void DropButton_Click(object sender, EventArgs e)
        {
            rowIndex = courseSchedule.CurrentCell.RowIndex;
            DataGridViewCellCollection row = courseSchedule.Rows[rowIndex].Cells;
            DataGridViewCell cell = row[0];
            String courseName = cell.Value.ToString().Trim();
            cell = row[1];
            String courseTerm = cell.Value.ToString().Trim();
            Console.WriteLine(courseName);
            bool success = account.delCourse(courseName, nextTerm);
            if (success)
            {
                MessageBox.Show("Course successfully dropped.");
                TermSelectorBox_SelectedIndexChanged(sender, e);
                if (courseTerm != currentTerm)
                {
                    cData.CDatabase[courseName].unenrollStudent(account.UserName);
                }             
            }
            else
            {
                MessageBox.Show("There was an error in dropping the course.");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void creditsEarnedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
