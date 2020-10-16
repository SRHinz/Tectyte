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
                AdviseeViewGrid.Columns[4].Visible = false;
                AdviseeViewGrid.Columns[5].Visible = false;
                AdviseeViewGrid.Columns[6].Visible = false;
                AdviseeViewGrid.Columns[7].Visible = false;
                AdviseeViewGrid.Columns[8].Visible = false;
                coe.vCourse.displayStuHist(coe.uData.UDatabase[stu] as Program.StudentAcc, AdviseeViewGrid, "Current", coe.CurTerm, coe.cData);

            }
            else if (comboBox1.SelectedItem.ToString() == "Future Courses")
            {
                AdviseeViewGrid.Rows.Clear();
                AdviseeViewGrid.Columns[4].Visible = true;
                AdviseeViewGrid.Columns[5].Visible = true;
                AdviseeViewGrid.Columns[6].Visible = true;
                AdviseeViewGrid.Columns[7].Visible = true;
                AdviseeViewGrid.Columns[8].Visible = true;
                coe.vCourse.displayStuHist(coe.uData.UDatabase[stu] as Program.StudentAcc, AdviseeViewGrid, "Future", coe.NexTerm, coe.cData);
            }
        }
    }
}
