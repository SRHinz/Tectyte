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
    public partial class AddCourse : Form
    {
        Program.UserDatabase UDATA;
        public AddCourse(ref Program.UserDatabase uData)
        {
            InitializeComponent();
            UDATA = 
        }

        private void Instructor_Button_Click(object sender, EventArgs e)
        {
            AccountSelector AS = new AccountSelector()
        }
    }
}
