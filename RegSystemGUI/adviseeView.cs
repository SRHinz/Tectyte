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
    public partial class adviseeView : Form
    {
        private string stu;
        Program.RegistrationSystem coe;
        public adviseeView(string Student, ref Program.RegistrationSystem system)
        {
            InitializeComponent();
            stu = Student;
            coe = system;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Current Courses")
            {
                AdviseeViewGrid.Rows.Clear();
                coe.vCourse.displayStuHist(coe.uData.UDatabase[stu] as Program.StudentAcc, AdviseeViewGrid, "Current"

            }
        }
    }
}
