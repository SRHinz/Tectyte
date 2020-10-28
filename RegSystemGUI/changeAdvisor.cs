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
    public partial class changeAdvisor : Form
    {
        private Options Menu;
        private Program.RegistrationSystem COE;
        public changeAdvisor(ref Program.RegistrationSystem coe, Options menu)
        {
            InitializeComponent();
            Menu = menu;
            COE = coe;
            foreach (string acc in COE.uData.UDatabase.Keys)
            {
                if (COE.uData.UDatabase[acc].Status != "faculty" && COE.uData.UDatabase[acc].Status != "admin")
                {
                    studentList.Items.Add((COE.uData.UDatabase[acc].UserName + " | " + COE.uData.UDatabase[acc].FName + " " + COE.uData.UDatabase[acc].LName));
                }
                else if (COE.uData.UDatabase[acc].Status == "faculty")
                {
                    facultyList.Items.Add((COE.uData.UDatabase[acc].UserName + " | " + COE.uData.UDatabase[acc].FName + " " + COE.uData.UDatabase[acc].LName));
                }
            }
            studentSearchBox.Clear();
            facultySearchBox.Clear();
        }

        private void changeAdvisor_Load(object sender, EventArgs e)
        {

        }

        private void MenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.Show();
        }

        private void studentSearchBox_TextChanged(object sender, EventArgs e)
        {
            studentList.Items.Clear();
            foreach (string acc in COE.uData.UDatabase.Keys)
            {
                if (COE.uData.UDatabase[acc].Status != "faculty" && COE.uData.UDatabase[acc].Status != "admin")
                {
                    string accLName = COE.uData.UDatabase[acc].LName.ToLower();
                    if (accLName.Contains(studentSearchBox.Text.ToLower()))
                    {
                        studentList.Items.Add((COE.uData.UDatabase[acc].UserName + " | " + COE.uData.UDatabase[acc].FName + " " + COE.uData.UDatabase[acc].LName));
                    }
                    
                }
            }

        }

        private void facultySearchBox_TextChanged(object sender, EventArgs e)
        {
            facultyList.Items.Clear();
            foreach (string acc in COE.uData.UDatabase.Keys)
            {
                if (COE.uData.UDatabase[acc].Status == "faculty")
                {
                    string accLName = COE.uData.UDatabase[acc].LName.ToLower();
                    if (accLName.Contains(facultySearchBox.Text.ToLower()))
                    {
                        facultyList.Items.Add((COE.uData.UDatabase[acc].UserName + " | " + COE.uData.UDatabase[acc].FName + " " + COE.uData.UDatabase[acc].LName));
                    }

                }
            }
        }
    }
}
