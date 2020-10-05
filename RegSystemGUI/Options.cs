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
        private Form[] forms = new Form[10];
        Login login;
        public Options(ref Program.RegistrationSystem coe, string accountType, string tempUN, string tempPW, Login loginform)
        {
            InitializeComponent();
            login = loginform;
            COE = coe;
            aType = accountType;
            accountUN = tempUN;
            accountPW = tempPW;
            forms[0] = this;
            forms[1] = new CourseViewer(ref COE.cData, ref COE.vCourse, this);
            if (aType == "student")
            {
                Program.StudentAcc curACC = COE.uData.UDatabase[(tempUN, tempPW)] as Program.StudentAcc;
                forms[2] = new stuCourseHist(curACC, ref COE.cData, COE.vCourse, COE.CurTerm, this);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (aType != "student")
                CourseHisButton.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in forms)
            {
                if (form != null)
                {
                    form.Close();
                }
            }
            login.Show();

        }

        private void viewCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
           // forms[1].CourseViewerLoad(this);
            forms[1].Show();
        }

        private void CourseHisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            forms[2].Show();
        }
    }
}
