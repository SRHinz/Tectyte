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
    public partial class DatabaseMod : Form         //This form serves as both the screen to choose what item the admin is trying to modify, and then calling the selector needed. 
    {
        Program.RegistrationSystem COE;
        DialogResult status;                        //This is what will be returned to the Options form to indicate if a modification/deletion has successfully gone through.
        public DatabaseMod(ref Program.RegistrationSystem inputSys)
        {
            InitializeComponent();
            COE = inputSys;
        }

        private void Selection(string type)
        {
            if (type == "C")
            {
                CourseSelector CS = new CourseSelector(ref COE);
                CS.ShowDialog();
                (string, string) ret = CS.getOptionandCourse;
                if (ret.Item1 == "D")
                {
                    COE.cData.RemoveCourse(ret.Item2, ref COE.uData, COE.NexTerm);
                    MessageBox.Show("Course Deletion Successful");
                }
                else if (ret.Item1 == "E")
                {
                    EditCourse EC = new EditCourse(ref COE.cData, ref COE.uData, ret.Item2);
                    EC.ShowDialog();
                    if (EC.getResponse == DialogResult.Cancel)
                    {
                        MessageBox.Show("Edit Canceled", "Edit Cancelation");
                    }
                    else if (EC.getResponse == DialogResult.OK)
                    {
                        COE.cData.changeCourseTime(EC.getTBs_new, ret.Item2);
                        COE.cData.CDatabase[ret.Item2].changeInstructor(EC.getNewInstruct);
                        MessageBox.Show("Course Modification Successful!", "Success");
                    }

                }

            }
            else if (type == "student" | type == "faculty")
            {
                AccountSelector AS = new AccountSelector(ref COE.uData, type);
                AS.ShowDialog();
                string selected = AS.getAccount();
                if (selected != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + selected + "from the system?", "Confirm Selection", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (type == "student")
                        {
                            COE.uData.RemoveUser(ref COE.cData, COE.uData.UDatabase[selected.Trim()] as Program.StudentAcc, COE.NexTerm);
                        }
                        else
                        {
                            COE.uData.RemoveUser(ref COE.cData, COE.uData.UDatabase[selected.Trim()] as Program.FacultyAcc, COE.NexTerm);
                        }
                        status = DialogResult.OK;
                    }
                    else
                    {
                        status = DialogResult.Cancel;
                    }
                }

            }
            DialogResult repeat = MessageBox.Show("Would you like to modify something else?", "Continue?", MessageBoxButtons.YesNo);
            if (repeat == DialogResult.No)
            {
                this.Close();               //This will exit out of the form and return focus to the options form. 
            }
            
        }

        private void CourseButtonClick(object sender, EventArgs e)
        {
            Selection("C");
        }

        private void StudentButtonClick(object sender, EventArgs e)
        {
            Selection("student");
        }

        private void FacultyButtonClick(object sender, EventArgs e)
        {
            Selection("faculty");
        }

        public DialogResult getResult
        {
            get
            {
                return status;
            }
        }
    }
}
