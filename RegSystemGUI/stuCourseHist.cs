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
        public stuCourseHist(Program.StudentAcc studentAcc, ref Program.CourseDatabase courseData, Program.viewCourses viewC, string cTerm, Options menu)
        {
            
            InitializeComponent();
            DropButton.Hide();
            CourseDataGrid.ColumnCount = 4;
            CourseHistoryGridBuild();
            cData = courseData;
            account = studentAcc;
            vCourses = viewC;
            Menu = menu;
            currentTerm = cTerm;
            TermSelectorBox.SelectedIndex = 0;
        }

        private void CourseHistoryGridBuild()
        {
            CourseDataGrid.Columns[0].Name = "Course";
            CourseDataGrid.Columns[1].Name = "Term";
            CourseDataGrid.Columns[2].Name = "Credits";
            CourseDataGrid.Columns[3].Name = "Grade";
        }



        private void MenuReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Show();
        }

        private void TermSelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TermSelectorBox.SelectedItem == "--select--")
            {
                if (DropButton.Visible) // checks to see if drop button is already displayed and hides it if not
                    DropButton.Hide();
                CourseDataGrid.Rows.Clear();
            }
            else if (TermSelectorBox.SelectedItem == "Course History")
            {
                if (DropButton.Visible)
                    DropButton.Hide();
                CourseDataGrid.Rows.Clear();
                vCourses.displayStuHist(account, CourseDataGrid, "History", currentTerm);
            }

            else if(TermSelectorBox.SelectedItem == "Current Courses")
            {
                if (!DropButton.Visible)
                    DropButton.Show();
                CourseDataGrid.Rows.Clear();
                vCourses.displayStuHist(account, CourseDataGrid, "Current", currentTerm);
            }

            else if (TermSelectorBox.SelectedItem == "Future Courses")
            {
                if (!DropButton.Visible) // checks to see if drop button is displayed and displays it if not
                    DropButton.Show();
                CourseDataGrid.Rows.Clear();
                vCourses.displayStuHist(account, CourseDataGrid, "Future", currentTerm);
            }
        }
    }
}
