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
        private adviseeViewer returnLoc;
        public adviseeView(string Student, ref Program.RegistrationSystem system, adviseeViewer a)
        {
            InitializeComponent();
            stu = Student;
            coe = system;
            returnLoc = a;
            comboBox1.SelectedIndex = 0;

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
                coe.vCourse.displayStuHist(coe.uData.UDatabase[stu] as Program.StudentAcc, AdviseeViewGrid, "Future", coe.CurTerm, coe.cData);
                try
                {
                    foreach (Program.sHistory course in (coe.uData.UDatabase[stu] as Program.StudentAcc).CHistory)
                    {
                        if (course.Term == coe.NexTerm & course.Grade == "N")
                        {
                            string[] courseTB1 = new string[coe.cData.CDatabase[course.Course.Trim()].NtimeBlocks];
                            for (int i = 0; i < courseTB1.Length; i++)
                            {
                                courseTB1[i] = coe.vCourse.solveTimeblock(coe.cData.CDatabase[course.Course.Trim()].TimeBlockCollection[i]).Trim();
                            }
                            foreach (Program.sHistory course2 in (coe.uData.UDatabase[stu] as Program.StudentAcc).CHistory)
                            {
                                if ((course.Course != course2.Course) & (course2.Term == coe.NexTerm) & (course2.Grade == "N"))
                                {
                                    string[] courseTB2 = new string[coe.cData.CDatabase[course2.Course.Trim()].NtimeBlocks];
                                    for (int i = 0; i < courseTB2.Length; i++)
                                    {
                                        courseTB2[i] = coe.vCourse.solveTimeblock(coe.cData.CDatabase[course2.Course].TimeBlockCollection[i]).Trim();
                                    }
                                    if (coe.vCourse.timeConflict(courseTB1, coe.cData.CDatabase[course.Course].TimeBlockCollection, courseTB2, coe.cData.CDatabase[course2.Course].TimeBlockCollection))
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
                }
            }
        }

        private void return_Button_Click(object sender, EventArgs e)
        {
            returnLoc.Show();
            this.Close();
        }
    }
}
