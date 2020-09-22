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
        public Options(ref Program.RegistrationSystem coe)
        {
            InitializeComponent();
            COE = coe;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void viewCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseViewer CV = new CourseViewer(ref COE.cData, ref COE.vCourse);
            CV.Show();
        }

    }
}
