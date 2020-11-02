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
                    //call the remove course function of the courseDatabase
                }
                else if (ret.Item1 == "E")
                {
                    //create a new instance of the editCourse form, and then show dialog of that. 
                }
            }
            else if (type == "S" | type == "F")
            {
                AccountSelector AS = new AccountSelector(ref COE.uData, type);
                AS.ShowDialog();
                string selected = AS.getAccount();
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + selected + "from the system?", "Confirm Selection", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (type == "S")
                    {
                        COE.uData.RemoveUser(ref COE.cData, COE.uData.UDatabase[selected] as Program.StudentAcc, COE.NexTerm);
                    }
                    else
                    {
                        COE.uData.RemoveUser(ref COE.cData, COE.uData.UDatabase[selected] as Program.FacultyAcc, COE.NexTerm);
                    }
                    status = DialogResult.OK;
                }
                else
                {
                    status = DialogResult.Cancel;
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
            Selection("S");
        }

        private void FacultyButtonClick(object sender, EventArgs e)
        {
            Selection("F");
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
