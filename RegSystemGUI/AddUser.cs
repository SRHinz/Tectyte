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
    public partial class AddUser : Form
    {
        Program.UserDatabase uData;
        public AddUser(ref Program.UserDatabase userDatabase)
        {
            InitializeComponent();
            uData = userDatabase;
        }

        private void IndexChanged_Acc(object sender, EventArgs e)
        {
            if (AccountType_Box.Text == "Student")
            {
                Advisor_Label.Show();
                Select_Advisor_Button.Show();
            }
            else
            {
                Advisor_Label.Hide();
                Select_Advisor_Button.Hide();
            }
        }
    }
}
