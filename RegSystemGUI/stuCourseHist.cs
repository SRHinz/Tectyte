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
        public stuCourseHist(Program.StudentAcc studentAcc, ref Program.CourseDatabase courseData, Program.viewCourses viewC, string cTerm, Options menu)
        {
            
            InitializeComponent();
            DropButton.Hide();
            warningBox.Hide();
            warningBox2.Hide();
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
            if (TermSelectorBox.SelectedItem == "--select--")
            {
                if (DropButton.Visible) // checks to see if drop button is already displayed and hides it if not
                    DropButton.Hide();
                if (warningBox.Visible)
                    warningBox.Hide();
                if (warningBox2.Visible)
                    warningBox2.Hide();
                CourseDataGrid.Rows.Clear();
            }
            else if (TermSelectorBox.SelectedItem == "Course History")
            {
                if (DropButton.Visible)
                    DropButton.Hide();
                if (warningBox.Visible)
                    warningBox.Hide();
                if (warningBox2.Visible)
                    warningBox2.Hide();
                CourseDataGrid.Rows.Clear();
                vCourses.displayStuHist(account, CourseDataGrid, "History", currentTerm);
                if (CourseDataGrid.Rows.Count == 0)
                {
                    warningBox.Show();
                    DropButton.Hide();
                }
            }

            else if(TermSelectorBox.SelectedItem == "Current Courses")
            {
                if (!DropButton.Visible)
                    DropButton.Show();
                if (warningBox.Visible)
                    warningBox.Hide();
                if (warningBox2.Visible)
                    warningBox2.Hide();
                CourseDataGrid.Rows.Clear();
                vCourses.displayStuHist(account, CourseDataGrid, "Current", currentTerm);
                if (CourseDataGrid.Rows.Count == 0)
                {
                    warningBox.Show();
                    DropButton.Hide();
                }
            }

            else if (TermSelectorBox.SelectedItem == "Future Courses")
            {
                if (!DropButton.Visible) // checks to see if drop button is displayed and displays it if not
                    DropButton.Show();
                if (warningBox.Visible)
                    warningBox.Hide();
                if (warningBox2.Visible)
                    warningBox2.Hide();
                CourseDataGrid.Rows.Clear();
                vCourses.displayStuHist(account, CourseDataGrid, "Future", currentTerm);
                if (CourseDataGrid.Rows.Count == 0)
                {
                    warningBox.Show();
                    DropButton.Hide();
                }
                
            }
        }

        private void DropButton_Click(object sender, EventArgs e)
        {
            rowIndex = CourseDataGrid.CurrentCell.RowIndex;
            DataGridViewCellCollection row = CourseDataGrid.Rows[rowIndex].Cells;
            DataGridViewCell cell = row[0];
            String courseName = cell.Value.ToString();
            Console.WriteLine(courseName);
            bool success = account.delCourse(courseName);
            courseName = courseName.Trim();
            cData.CDatabase[courseName].AvailableSeats++; //Adds seat to course in courseDatabase
            if (success)
                MessageBox.Show("Course successfully dropped.");
            else
            {
                MessageBox.Show("There was an error in dropping the course.");
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
