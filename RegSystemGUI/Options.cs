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
    public partial class Options : Form
    {
        private Program.RegistrationSystem COE = new Program.RegistrationSystem();
        private string aType, accountUN, accountPW;
        public Options(ref Program.RegistrationSystem coe, string accountType, string tempUN, string tempPW)
        {
            InitializeComponent();
            COE = coe;
            aType = accountType;
            accountUN = tempUN;
            accountPW = tempPW;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (aType != "student")
                CourseHisButton.Hide();
        }

        private void viewCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseViewer CV = new CourseViewer(ref COE.cData, ref COE.vCourse);
            CV.Show();
        }

        private void CourseHisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseViewer CV = new CourseViewer(ref COE.uData, accountUN, accountPW);
        }
    }
}
