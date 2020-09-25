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
    public partial class CourseViewer : Form
    {
        private Program.CourseDatabase coeC = new Program.CourseDatabase();
        private Program.viewCourses viewC = new Program.viewCourses();
        public CourseViewer(ref Program.CourseDatabase courseD, ref Program.viewCourses vC)     //By passing in these two variables, we should be able to display the courses to the readonly textbox upon creation of this form.
        {
            InitializeComponent();
            coeC = courseD;
            viewC = vC;
            CourseDataGrid.ColumnCount = 11;
            GridBuild();
            vC.displayCourses(coeC, CourseDataGrid);
        }

        private void GridBuild()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CourseDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
