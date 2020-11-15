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
        private Program.RegistrationSystem COE;
        public adviseeViewer(ref Program.RegistrationSystem coe, Options menu)
        {
            InitializeComponent();
            Menu = menu;
            foreach (string student in (coe.uData.UDatabase[coe.CurAcc] as Program.FacultyAcc).Advisees)
            {
                adviseeDatagrid.Rows.Add(coe.uData.UDatabase[student].LName, coe.uData.UDatabase[student].FName, coe.uData.UDatabase[student].UserName);
            }
            COE = coe;
        }

        public adviseeViewer(ref Program.RegistrationSystem coe, Options menu, Program.Account account)
        {
            InitializeComponent();
            Menu = menu;
            foreach (string student in (coe.uData.UDatabase[account.UserName] as Program.FacultyAcc).Advisees)
            {
                adviseeDatagrid.Rows.Add(coe.uData.UDatabase[student].LName, coe.uData.UDatabase[student].FName, coe.uData.UDatabase[student].UserName);
            }
            COE = coe;
        }

        private void MenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu.Show();
        }


        private void ViewStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int stuLoc = adviseeDatagrid.CurrentCell.RowIndex;
                string item = adviseeDatagrid.Rows[stuLoc].Cells[2].Value.ToString();
                adviseeView AD = new adviseeView(item, ref COE, this);
                AD.Show();
                this.Hide();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No advisee selected");
            }
        }
    }
}
