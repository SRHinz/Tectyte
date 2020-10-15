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
    public partial class adviseeViewer : Form
    {
        private Options Menu;
        private Program.Account curAcc;
        private string student;
        public adviseeViewer(ref Program.RegistrationSystem coe, Options menu)
        {
            InitializeComponent();
            Menu = menu;
            foreach (string student in (coe.uData.UDatabase[coe.CurAcc] as Program.FactultyAcc).Advisees)
            {   
                listView1.Items.Add((coe.uData.UDatabase[student].UserName + " | " + coe.uData.UDatabase[student].FName + " " + coe.uData.UDatabase[student].LName));
            }
        }

        private void MenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void ViewStudent_Click(object sender, EventArgs e)
        {
            string selected = listView1.SelectedItems.ToString();
        }
    }
}
