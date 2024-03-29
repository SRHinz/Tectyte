﻿using System;
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
        private int locX = 101;
        private int locY = 61;
        private int rowCount = 1;
        public Options(ref Program.RegistrationSystem coe, string accountType, string tempUN, string tempPW, Login loginform)
        {
            InitializeComponent();
            AS = new AccountSelector(ref coe.uData);
            login = loginform;
            COE = coe;
            aType = accountType.Trim();
            accountUN = tempUN;
            accountPW = tempPW;
            COE.registerC = new Program.Register(ref COE.cData);
            SysModButton.Hide();
            if (aType == "student")
            {
                curAcc = COE.uData.UDatabase[tempUN] as Program.StudentAcc;
            }
            else if (aType == "admin" | aType == "manager")
            {
                if (aType == "manager")
                {
                    SysModButton.Show();
                    AddCourse_Button.Show();
                    AddUser_Button.Show();
                }
                else
                {
                    AddUser_Button.Hide();
                    AddCourse_Button.Hide();
                }
                CourseHisButton.Hide();
                AdminStuHisButton.Show();
                changeAdvisorButton.Show();

            }
            //setButtonPositions();
        }

        private void setButtonPositions()
        {
            int wStart = (this.Width / 2) - 220;
            int hStart = (this.Height / 2) - 120;
            int colCount = 0;
            int rowCount = 0;
            int widthMod = 140;
            int heightMod = 55;
            Point point = new Point();
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Width = 135;
                button.Height = 50;

                if (button.Text == "Log Out")
                    button.Location = new Point(wStart + widthMod, hStart + heightMod * 3);
                if (button.Visible && button.Text != "Log Out")
                {
                    point.X = wStart + (colCount * widthMod);
                    point.Y = hStart + (rowCount * heightMod);
                    button.Location = point;
                    if (colCount == 2)
                    {
                        rowCount++;
                        colCount = 0;
                    }
                    else
                        colCount++;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SysModButton.Hide();
            AddUser_Button.Hide();
            AddCourse_Button.Hide();
            if (aType == "student")
            {
                CourseHisButton.Show();
                viewAdvisees.Hide();
                changeAdvisorButton.Hide();
            }
            else if (aType == "faculty")
            {
                CourseHisButton.Hide();
                viewAdvisees.Show();
                changeAdvisorButton.Hide();
            }
            else if (aType == "admin" | aType == "manager")
            {
                if (aType == "manager")
                {
                    SysModButton.Show();
                    AddCourse_Button.Show();
                    AddUser_Button.Show();
                }
                else
                {
                    AddUser_Button.Hide();
                    AddCourse_Button.Hide();
                }
                AdminStuHisButton.Show();
                changeAdvisorButton.Show();

            }
            setButtonPositions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes)
            {
                this.Close();
                login.Show();
            }
            else if (logout == DialogResult.No)
            {
                //Nothing is done :D
            }
            

        }

        private void viewAdvisees_Click(object sender, EventArgs e)
        {
            if ((aType == "admin") | (aType == "manager"))
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

        private void SysMod_Click(object sender, EventArgs e)
        {
            DatabaseMod DM = new DatabaseMod(ref COE);
            DM.ShowDialog();
            DialogResult result = DM.getResult;
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Modification Successful");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Modification Aborted");
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

        private void AddCourse_Button_Click(object sender, EventArgs e)
        {
            AddCourse AC = new AddCourse(ref COE.uData, COE.cData);
            AC.ShowDialog();
            if (AC.GetResult == DialogResult.OK)
            {
                COE.cData.AddCourse(AC.getCourseInfo.Item1, AC.getCourseInfo.Item2, AC.getCourseInfo.Item3, AC.getCourseInfo.Item4, AC.getCourseInfo.Item5, AC.getCourseInfo.Item6, AC.getCourseInfo.Item7, AC.getPR, AC.getPrereqs);
            }
            else if (AC.GetResult == DialogResult.Cancel)
            {
                MessageBox.Show("Course Add Cancelled", "Abort CourseAdd");
            }
        }

        private void AdminStuHisButton_Click(object sender, EventArgs e)
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

        private void viewCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            // forms[1].CourseViewerLoad(this);
            cV = new CourseViewer(ref COE, this);
            cV.Show();
        }


        private void CourseHisButton_Click(object sender, EventArgs e)
        {
            if ((aType == "admin") | (aType == "manager"))
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
