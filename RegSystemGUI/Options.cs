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
        private changeAdvisor adChange;
        private AccountSelector AS;
        public Options(ref Program.RegistrationSystem coe, string accountType, string tempUN, string tempPW, Login loginform)
        {
            InitializeComponent();
            AS = new AccountSelector(ref coe.uData);
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
            else if (aType == "admin" | aType == "manager")
            {
                if (aType == "manager")
                {
                    SysModButton.Show();
                }
                else
                {
                    SysModButton.Hide();
                }
                AdminStuHisButton.Show();
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (aType == "student")
            {
                CourseHisButton.Show();
                viewAdvisees.Hide();
                changeAdvisorButton.Hide();
                SysModButton.Hide();
            }
            else if (aType == "faculty")
            {
                CourseHisButton.Hide();
                viewAdvisees.Show();
                changeAdvisorButton.Hide();
                SysModButton.Hide();
            }
            else if (aType == "admin" | aType == "manager")
            {
                if (aType == "manager")
                {
                    SysModButton.Show();
                }
                else
                {
                    SysModButton.Hide();
                }
                AdminStuHisButton.Show();
                changeAdvisorButton.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();

        }

        private void viewAdvisees_Click(object sender, EventArgs e)
        {
            if (aType == "admin")
            {
                AS.DisplayFacultyAccounts();
                AS.ShowDialog();
                if (AS.getAccount() != null)
                {
                    Program.FacultyAcc facultyAcc = (Program.FacultyAcc)COE.uData.UDatabase[AS.getAccount()];
                    this.Hide();
                    adView = new adviseeViewer(ref COE, this, facultyAcc);
                    adView.Show();
                }
            }
            else
            {
                this.Hide();
                adView = new adviseeViewer(ref COE, this);
                adView.Show();
            }
        }

        private void changeAdvisor_Click(object sender, EventArgs e)
        {
            this.Hide();
            adChange = new changeAdvisor(ref COE, this);
            adChange.Show();
        }

        private void AdminStuHis_Click(object sender, EventArgs e)
        {
            AS.DisplayStudentAccounts();
            AS.ShowDialog();
            if (AS.getAccount() != null)
            {
                Program.StudentAcc stuAccount = (Program.StudentAcc)COE.uData.UDatabase[AS.getAccount()];
                stuCourseHist cH = new stuCourseHist(ref stuAccount, ref COE.cData, COE.vCourse, COE.CurTerm, COE.NexTerm, this);
                this.Hide();
                cH.Show();
            }
        }

        private void SysMod_Click(object sender, EventArgs e)
        {
            DatabaseMod DM = new DatabaseMod(ref COE);
            DM.ShowDialog();
            DialogResult result = DM.getResult;
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Modification Sucessful");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Modificaiton Aborted");
            }
        }

        private void AddUser_Button_Click(object sender, EventArgs e)
        {
            AddUser AU = new AddUser(ref COE.uData);
            AU.ShowDialog();
            if (AU.returnStatus == DialogResult.Cancel)
            {
                MessageBox.Show("User add aborted.", "Add Aborted");
            }
            else if (AU.returnStatus == DialogResult.OK)
            {
                COE.uData.AddUser(AU.getUserData);
                MessageBox.Show(AU.getUserData.Item1 + " " + AU.getUserData.Item2 + " " + AU.getUserData.Item3 + " added as a " + AU.getUserData.Item4 + " account.");
            }
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
            if (aType == "admin")
            {
                AS.DisplayStudentAccounts();
                AS.ShowDialog();
                if (AS.getAccount() != null)
                {
                    Program.StudentAcc stuAccount = (Program.StudentAcc)COE.uData.UDatabase[AS.getAccount()];
                    this.Hide();
                    stuCourseHist cH = new stuCourseHist(ref stuAccount, ref COE.cData, COE.vCourse, COE.CurTerm, COE.NexTerm, this);
                    cH.Show();
                }
            }
            else
            {
                this.Hide();
                stuCourseHist cH = new stuCourseHist(ref curAcc, ref COE.cData, COE.vCourse, COE.CurTerm, COE.NexTerm, this);
                cH.Show();
            }
        }
    }
}
