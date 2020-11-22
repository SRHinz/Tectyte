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
        Program.CourseDatabase CDATA;
        private string instructor = "staff";
        private int[] TBs = new int[5] { 0, 0, 0, 0, 0 };
        private Program.viewCourses VC = new Program.viewCourses();
        private (string, string, string, string, int, int, int[]) courseInfo;
        private List<string> prereqs;
        private bool PR = false;
        DialogResult Result;
        public AddCourse(ref Program.UserDatabase uData, Program.CourseDatabase cData)
        {
            InitializeComponent();
            UDATA = uData;
            CDATA = cData;
            Prereq.Checked = false;
            Prereq_Display.Hide();
            Add_P_Button.Hide();
            Edit_TB2_Button.Hide();
            checkBox2.Hide();
            TB2.Hide();
            Edit_TB3_Button.Hide();
            checkBox3.Hide();
            TB3.Hide();
            Edit_TB4_Button.Hide();
            checkBox4.Hide();
            TB4.Hide();
            Edit_TB5_Button.Hide();
            checkBox5.Hide();
            TB5.Hide();


        }

        private void Instructor_Button_Click(object sender, EventArgs e)
        {
            AccountSelector AS = new AccountSelector(ref UDATA, "faculty");
            AS.ShowDialog();
            instructor = AS.getAccount();
            Num_TimeBlocks.Value = 1;
            Add_P_Button.Hide();
            Prereq_Display.Hide();

        }

        private void Num_TB_Change(object sender, EventArgs e)
        {
            if (Num_TimeBlocks.Value == 1)
            {
                Edit_TB2_Button.Hide();
                checkBox2.Hide();
                TB2.Hide();
                Edit_TB3_Button.Hide();
                checkBox3.Hide();
                TB3.Hide();
                Edit_TB4_Button.Hide();
                checkBox4.Hide();
                TB4.Hide();
                Edit_TB5_Button.Hide();
                checkBox5.Hide();
                TB5.Hide();
            }
            else if (Num_TimeBlocks.Value == 2)
            {
                Edit_TB2_Button.Show();
                checkBox2.Show();
                TB2.Show();
                Edit_TB3_Button.Hide();
                checkBox3.Hide();
                TB3.Hide();
                Edit_TB4_Button.Hide();
                checkBox4.Hide();
                TB4.Hide();
                Edit_TB5_Button.Hide();
                checkBox5.Hide();
                TB5.Hide();
            }
            else if (Num_TimeBlocks.Value == 3)
            {
                Edit_TB2_Button.Show();
                checkBox2.Show();
                TB2.Show();
                Edit_TB3_Button.Show();
                checkBox3.Show();
                TB3.Show();
                Edit_TB4_Button.Hide();
                checkBox4.Hide();
                TB4.Hide();
                Edit_TB5_Button.Hide();
                checkBox5.Hide();
                TB5.Hide();
            }
            else if (Num_TimeBlocks.Value == 4)
            {
                Edit_TB2_Button.Show();
                checkBox2.Show();
                TB2.Show();
                Edit_TB3_Button.Show();
                checkBox3.Show();
                TB3.Show();
                Edit_TB4_Button.Show();
                checkBox4.Show();
                TB4.Show();
                Edit_TB5_Button.Hide();
                checkBox5.Hide();
                TB5.Hide();
            }
            else if (Num_TimeBlocks.Value == 5)
            {
                Edit_TB2_Button.Show();
                checkBox2.Show();
                TB2.Show();
                Edit_TB3_Button.Show();
                checkBox3.Show();
                TB3.Show();
                Edit_TB4_Button.Show();
                checkBox4.Show();
                TB4.Show();
                Edit_TB5_Button.Show();
                checkBox5.Show();
                TB5.Show();

            }
        }

        private void Edit_TB1_Button_Click(object sender, EventArgs e)
        {
            EditTimeBlock ETB;
            try
            {
                ETB = new EditTimeBlock(VC.solveTimeblock(TBs[0]));
            }
            catch (Exception f)
            {
                ETB = new EditTimeBlock("new");
            }
            ETB.ShowDialog();
            TBs[0] = VC.createTimeblock(ETB.getTBNew.Item1, ETB.getTBNew.Item2, ETB.getTBNew.Item3, ETB.getTBNew.Item4, ETB.getTBNew.Item5, ETB.getTBNew.Item6, ETB.getTBNew.Item7);
            TB1.Text = VC.solveTimeblock(TBs[0]);
            checkBox1.Checked = true;
        }

        private void Edit_TB2_Button_Click(object sender, EventArgs e)
        {
            EditTimeBlock ETB;
            try
            {
                ETB = new EditTimeBlock(VC.solveTimeblock(TBs[1]));
            }
            catch (Exception f)
            {
                ETB = new EditTimeBlock("new");
            }
            ETB.ShowDialog();
            TBs[1] = VC.createTimeblock(ETB.getTBNew.Item1, ETB.getTBNew.Item2, ETB.getTBNew.Item3, ETB.getTBNew.Item4, ETB.getTBNew.Item5, ETB.getTBNew.Item6, ETB.getTBNew.Item7);
            TB2.Text = VC.solveTimeblock(TBs[1]);
            checkBox2.Checked = true;
        }

        private void Edit_TB3_Button_Click(object sender, EventArgs e)
        {
            EditTimeBlock ETB;
            try
            {
                ETB = new EditTimeBlock(VC.solveTimeblock(TBs[2]));
            }
            catch (Exception f)
            {
                ETB = new EditTimeBlock("new");
            }
            ETB.ShowDialog();
            TBs[2] = VC.createTimeblock(ETB.getTBNew.Item1, ETB.getTBNew.Item2, ETB.getTBNew.Item3, ETB.getTBNew.Item4, ETB.getTBNew.Item5, ETB.getTBNew.Item6, ETB.getTBNew.Item7);
            TB3.Text = VC.solveTimeblock(TBs[2]);
            checkBox3.Checked = true;
        }

        private void Edit_TB4_Button_Click(object sender, EventArgs e)
        {
            EditTimeBlock ETB;
            try
            {
                ETB = new EditTimeBlock(VC.solveTimeblock(TBs[3]));
            }
            catch (Exception f)
            {
                ETB = new EditTimeBlock("new");
            }
            ETB.ShowDialog();
            TBs[3] = VC.createTimeblock(ETB.getTBNew.Item1, ETB.getTBNew.Item2, ETB.getTBNew.Item3, ETB.getTBNew.Item4, ETB.getTBNew.Item5, ETB.getTBNew.Item6, ETB.getTBNew.Item7);
            TB4.Text = VC.solveTimeblock(TBs[3]);
            checkBox3.Checked = true;
        }

        private void Edit_TB5_Button_Click(object sender, EventArgs e)
        {
            EditTimeBlock ETB;
            try
            {
                ETB = new EditTimeBlock(VC.solveTimeblock(TBs[4]));
            }
            catch (Exception f)
            {
                ETB = new EditTimeBlock("new");
            }
            ETB.ShowDialog();
            TBs[4] = VC.createTimeblock(ETB.getTBNew.Item1, ETB.getTBNew.Item2, ETB.getTBNew.Item3, ETB.getTBNew.Item4, ETB.getTBNew.Item5, ETB.getTBNew.Item6, ETB.getTBNew.Item7);
            TB5.Text = VC.solveTimeblock(TBs[4]);
            checkBox3.Checked = true;
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            if ((Course_Name_Box.Text.Contains(" ")))
            {
                MessageBox.Show("You have not input a proper Course Name", "Improper Course Name");
            }
            else if (Course_Title_Box.Text == "")
            {
                MessageBox.Show("You have not input a proper Course Title", "Improper Course Title");
            }
            else if (Credit_Box.Text == "None Selected")
            {
                MessageBox.Show("You have not selected a valid number of Credits", "Invalid Credits Selected");
            }
            else if (((Num_TimeBlocks.Value == 1) & (TBs[0] == 0)) | ((Num_TimeBlocks.Value == 2) & ((TBs[0] == 0) | (TBs[1] == 0))) | ((Num_TimeBlocks.Value == 3) & ((TBs[0] == 0) | (TBs[1] == 0) | (TBs[2] == 0))) | ((Num_TimeBlocks.Value == 4) & ((TBs[0] == 0) | (TBs[1] == 0) | (TBs[2] == 0) | (TBs[3] == 0))) | ((Num_TimeBlocks.Value == 5) & ((TBs[0] == 0) | (TBs[1] == 0) | (TBs[2] == 0) | (TBs[3] == 0) | (TBs[4] == 0))))
            {
                MessageBox.Show("Invalid Time Block(s) selected for the chosen number of Time Blocks", "Invalid Time Block(s)");
            }
            else if (instructor == "staff")
            {
                DialogResult result = MessageBox.Show("You have not selected an instructor for this course. This will result in the system defaulting to staff. Is this okay?", "Default Instructor", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    courseInfo = (Course_Name_Box.Text, Course_Title_Box.Text, instructor, Credit_Box.Text, Convert.ToInt32(Num_Seats.Value), Convert.ToInt32(Num_TimeBlocks.Value), TBs);
                    Result = DialogResult.OK;
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    //Nothing happens, messagebox closes
                }
            }
            else
            {
                if (Convert.ToInt32(Num_TimeBlocks.Value) == 1)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        TBs[i] = 0;
                    }
                }
                else if (Convert.ToInt32(Num_TimeBlocks.Value) == 2)
                {
                    for (int i = 2; i <= 4; i++)
                    {
                        TBs[i] = 0;
                    }
                }
                else if (Convert.ToInt32(Num_TimeBlocks.Value) == 3)
                {
                    for (int i = 3; i <= 4; i++)
                    {
                        TBs[i] = 0;
                    }
                }
                else if (Convert.ToInt32(Num_TimeBlocks.Value) == 4)
                {
                    for (int i = 4; i <= 4; i++)
                    {
                        TBs[i] = 0;
                    }
                }
                courseInfo = (Course_Name_Box.Text, Course_Title_Box.Text, instructor, Credit_Box.Text, Convert.ToInt32(Num_Seats.Value), Convert.ToInt32(Num_TimeBlocks.Value), TBs);
                Result = DialogResult.OK;
                this.Close();
            }
        }

        public (string, string, string, string, int, int, int[]) getCourseInfo
        {
            get
            {
                return courseInfo;
            }
        }

        private void Prereq_Click(object sender, EventArgs e)
        {
            if (!Prereq.Checked)
            {
                Prereq_Display.Hide();
                Add_P_Button.Hide();
                PR = true;
            }
            else
            {
                Prereq_Display.Show();
                Add_P_Button.Show();
                PR = false;
            }
        }

        private void Add_P_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Is the prerequisite course being offered next semester?", "Prereq Choice", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CourseSelector CS = new CourseSelector(CDATA);
                CS.ShowDialog();
                Prereq_Display.Text += CS.getCourse.Substring(0, (CS.getCourse.Length - 3)) + "\n";
                prereqs.Add(CS.getCourse.Substring(0, (CS.getCourse.Length - 3)));

            }
            else if (result == DialogResult.No)
            {
                CourseEnter CE = new CourseEnter();
                CE.ShowDialog();
                Prereq_Display.Text += CE.getcourseName + "\n";
                prereqs.Add(CE.getcourseName);
            }
        }
        public List<string> getPrereqs
        {
            get
            {
                return prereqs;
            }
        }

        public bool getPR
        {
            get
            {
                if (!prereqs.Any<string>())
                    PR = false;
                return PR;
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.Close();
        }

        public DialogResult GetResult
        {
            get
            {
                return Result;
            }
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
