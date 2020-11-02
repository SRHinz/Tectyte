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
        public CourseSelector(ref Program.RegistrationSystem iSys)
        {
            InitializeComponent();
            COE = iSys;
            COE.vCourse.displayCourses(COE.cData, courseModifierView);
        }

        public (string, string) getOptionandCourse
        {
            get
            {
                return (option, course);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DelCourseClick(object sender, EventArgs e)
        {
            int rowIndex = courseModifierView.CurrentCell.RowIndex;
            DataGridViewCellCollection row = courseModifierView.Rows[rowIndex].Cells;
            DataGridViewCell cell = row[0];
            course = cell.Value.ToString().Trim();
            option = "D";
            this.Close();
        }

        private void EditCourseClick(object sender, EventArgs e)
        {
            int rowIndex = courseModifierView.CurrentCell.RowIndex;
            DataGridViewCellCollection row = courseModifierView.Rows[rowIndex].Cells;
            DataGridViewCell cell = row[0];
            course = cell.Value.ToString().Trim();
            option = "E";
            this.Close();
        }
    }
}
