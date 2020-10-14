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
        private Program.RegistrationSystem COE;
        private string aType, accountUN, accountPW;
        Login login;
        private Program.StudentAcc curAcc;
        private CourseViewer cV;
        private adviseeViewer adView;
        public Options(ref Program.RegistrationSystem coe, string accountType, string tempUN, string tempPW, Login loginform)
        {
            InitializeComponent();
            login = loginform;
            COE = coe;
            aType = accountType;
            accountUN = tempUN;
            accountPW = tempPW;
            COE.registerC = new Program.Register(ref COE.cData);
            if (aType == "student")
            {
                curAcc = COE.uData.UDatabase[tempUN] as Program.StudentAcc;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (aType == "student")
            {
                CourseHisButton.Show();
                viewAdvisees.Hide();
            }
            else if (aType == "faculty")
            {
                CourseHisButton.Hide();
                viewAdvisees.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();

        }

        private void viewAdvisees_Click(object sender, EventArgs e)
        {
            this.Hide();
            adView = new adviseeViewer(ref COE, this);
            adView.Show();
        }

        private void viewCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            // forms[1].CourseViewerLoad(this);
            cV = new CourseViewer(ref COE, this);
            cV.Show();
        }


        private void CourseHisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            stuCourseHist cH = new stuCourseHist(ref curAcc, ref COE.cData, COE.vCourse, COE.CurTerm, this );
            cH.Show();
        }
    }
}
