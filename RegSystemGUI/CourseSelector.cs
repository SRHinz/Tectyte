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

    public partial class CourseSelector : Form
    {
        string option;
        string course;
        Program.RegistrationSystem COE;
        private Program.Register regC;
        private Program.viewCourses VC = new Program.viewCourses();
        public CourseSelector(ref Program.RegistrationSystem iSys)
        {
            InitializeComponent();
            COE = iSys;
            regC = iSys.registerC;
            delCourse.Show();
            editCourse.Show();
            Add_Preq_Button.Hide();
            searchBox.Clear();
            CourseDataGrid.Rows.Clear();
            VC.displayCourses(COE.cData, CourseDataGrid);
        }
        public CourseSelector(Program.CourseDatabase courseDatabase)
        {
            delCourse.Hide();
            editCourse.Hide();
            Add_Preq_Button.Show();
            VC.displayCourses(courseDatabase, CourseDataGrid);
        }

        

        public (string, string) getOptionandCourse
        {
            get
            {
                return (option, course);
            }
        }

        public string getCourse
        {
            get
            {
                return course;
            }
        }


        private void DelCourseClick(object sender, EventArgs e)
        {
            int rowIndex = CourseDataGrid.CurrentCell.RowIndex;
            DataGridViewCellCollection row = CourseDataGrid.Rows[rowIndex].Cells;
            DataGridViewCell cell = row[0];
            course = cell.Value.ToString().Trim();
            option = "D";
            this.Close();
        }

        private void EditCourseClick(object sender, EventArgs e)
        {
            int rowIndex = CourseDataGrid.CurrentCell.RowIndex;
            DataGridViewCellCollection row = CourseDataGrid.Rows[rowIndex].Cells;
            DataGridViewCell cell = row[0];
            course = cell.Value.ToString().Trim();
            option = "E";
            this.Close();
        }

        private void Add_Preq_Button_Click(object sender, EventArgs e)
        {
            int rowIndex = CourseDataGrid.CurrentCell.RowIndex;
            DataGridViewCellCollection row = CourseDataGrid.Rows[rowIndex].Cells;
            DataGridViewCell cell = row[0];
            course = cell.Value.ToString().Trim();
            this.Close();
        }

        private void CourseSelector_Load(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            CourseDataGrid.Rows.Clear();
            foreach (string course in COE.cData.CDatabase.Keys)
            {
                if (course.Contains(searchBox.Text.ToUpper()))
                {
                    regC.displaySearchCourses(COE.cData, CourseDataGrid, course);
                }
            }
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
