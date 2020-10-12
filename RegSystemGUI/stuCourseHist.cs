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
    public partial class stuCourseHist : Form
    {
        private Options Menu;
        private Program.StudentAcc account;
        private Program.viewCourses vCourses;
        private Program.CourseDatabase cData;
        private string currentTerm;
        private int rowIndex;
        public stuCourseHist(ref Program.StudentAcc studentAcc, ref Program.CourseDatabase courseData, Program.viewCourses viewC, string cTerm, Options menu)
        {
            
            InitializeComponent();
            DropButton.Hide();
            warningBox.Hide();
            warningBox2.Hide();
            creditsEarnedBox.Hide();
            GPAbox.Hide();
            courseSchedule.Hide();
            CourseDataGrid.ColumnCount = 4;
            cData = courseData;
            account = studentAcc;
            vCourses = viewC;
            Menu = menu;
            currentTerm = cTerm;
            TermSelectorBox.SelectedIndex = 0;
        }


        private void MenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.Show();
        }

        private void TermSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TermSelectorBox.SelectedItem.ToString() == "--select--")
            {
                if (DropButton.Visible) // checks to see if drop button is already displayed and hides it if not
                    DropButton.Hide();
                if (warningBox.Visible)
                    warningBox.Hide();
                if (warningBox2.Visible)
                    warningBox2.Hide();
                if (courseSchedule.Visible)
                    courseSchedule.Hide();
                if (!CourseDataGrid.Visible)
                    CourseDataGrid.Show();
                if (GPAbox.Visible)
                    GPAbox.Hide();
                if (creditsEarnedBox.Visible)
                    creditsEarnedBox.Hide();
                CourseDataGrid.Rows.Clear();
            }
            else if (TermSelectorBox.SelectedItem.ToString() == "Course History")
            {
                if (DropButton.Visible)
                    DropButton.Hide();
                if (warningBox.Visible)
                    warningBox.Hide();
                if (warningBox2.Visible)
                    warningBox2.Hide();
                if (courseSchedule.Visible)
                    courseSchedule.Hide();
                if (!CourseDataGrid.Visible)
                    CourseDataGrid.Show();
                if (!GPAbox.Visible)
                    GPAbox.Show();
                if (!creditsEarnedBox.Visible)
                    creditsEarnedBox.Show();
                CourseDataGrid.Rows.Clear();
                vCourses.displayStuHist(account, CourseDataGrid, "History", currentTerm, cData);
                if (CourseDataGrid.Rows.Count == 0)
                {
                    warningBox.Show();
                    DropButton.Hide();
                }
                creditsEarnedBox.Text += account.totalCredits.ToString();
                GPAbox.Text += account.GPA.ToString();
            }

            else if(TermSelectorBox.SelectedItem.ToString() == "Current Courses")
            {
                if (!DropButton.Visible)
                    DropButton.Show();
                if (warningBox.Visible)
                    warningBox.Hide();
                if (warningBox2.Visible)
                    warningBox2.Hide();
                if (!courseSchedule.Visible)
                    courseSchedule.Show();
                if (CourseDataGrid.Visible)
                    CourseDataGrid.Hide();
                if (GPAbox.Visible)
                    GPAbox.Hide();
                if (creditsEarnedBox.Visible)
                    creditsEarnedBox.Hide();
                courseSchedule.Rows.Clear();
                vCourses.displayStuHist(account, courseSchedule, "Current", currentTerm, cData);
                if (courseSchedule.Rows.Count == 0)
                {
                    warningBox.Show();
                    DropButton.Hide();
                }
            }

            else if (TermSelectorBox.SelectedItem.ToString() == "Future Courses")
            {
                if (!DropButton.Visible) // checks to see if drop button is displayed and displays it if not
                    DropButton.Show();
                if (warningBox.Visible)
                    warningBox.Hide();
                if (warningBox2.Visible)
                    warningBox2.Hide();
                if (!courseSchedule.Visible)
                    courseSchedule.Show();
                if (CourseDataGrid.Visible)
                    CourseDataGrid.Hide();
                if (GPAbox.Visible)
                    GPAbox.Hide();
                if (creditsEarnedBox.Visible)
                    creditsEarnedBox.Hide();
                courseSchedule.Rows.Clear();
                vCourses.displayStuHist(account, courseSchedule, "Future", currentTerm, cData);
                if (courseSchedule.Rows.Count == 0)
                {
                    warningBox.Show();
                    DropButton.Hide();
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
            bool success = account.delCourse(courseName);
            if (success)
            {
                MessageBox.Show("Course successfully dropped.");
                TermSelectorBox_SelectedIndexChanged(sender, e);
                if (courseTerm != currentTerm)
                {
                    cData.CDatabase[courseName].unenrollStudent(account);
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
    }
}
