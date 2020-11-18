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
    public partial class EditCourse : Form
    {
        Program.CourseDatabase CDATA;
        Program.Course Course;
        string cN;
        Program.viewCourses VC = new Program.viewCourses();
        Program.UserDatabase UD;
        private string Instructor_New;
        private int[] TBs_New;
        DialogResult Response;
        public EditCourse(ref Program.CourseDatabase cData, ref Program.UserDatabase U, string cName)
        {
            InitializeComponent();
            CDATA = cData;
            Course = CDATA.CDatabase[cName];
            cN = cName;
            UD = U;
            TBs_New = new int[Course.NtimeBlocks];
            TBs_New = Course.TimeBlockCollection;
            Instructor_Box.Text = Course.Instructor;
            Instructor_New = Course.Instructor;
            TB1_Box.Text = VC.solveTimeblock(Course.TimeBlockCollection[0]);
            if (Course.TimeBlockCollection[1] == 0)
            {
                EditTB2Button.Hide();
            }
            TB2_Box.Text = VC.solveTimeblock(Course.TimeBlockCollection[1]);
            if (Course.TimeBlockCollection[2] == 0)
            {
                EditTB3Button.Hide();
            }
            TB3_Box.Text = VC.solveTimeblock(Course.TimeBlockCollection[2]);
            if (Course.TimeBlockCollection[3] == 0)
            {
                EditTB4Button.Hide();
            }
            TB4_Box.Text = VC.solveTimeblock(Course.TimeBlockCollection[3]);
            if (Course.TimeBlockCollection[4] == 0)
            {
                EditTB5Button.Hide();
            }
            TB5_Box.Text = VC.solveTimeblock(Course.TimeBlockCollection[4]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EditInstructorButton_Click(object sender, EventArgs e)
        {
            AccountSelector AS = new AccountSelector(ref UD, "F");
            AS.ShowDialog();
            Instructor_Box.Text = AS.getAccount();
            Instructor_New = AS.getAccount();
        }

        private void EditTB1Button_Click(object sender, EventArgs e)
        {
            EditTimeBlock ETB = new EditTimeBlock(TB1_Box.Text);
            ETB.ShowDialog();
            TBs_New[0] = VC.createTimeblock(ETB.getTBNew.Item1, ETB.getTBNew.Item2, ETB.getTBNew.Item3, ETB.getTBNew.Item4, ETB.getTBNew.Item5, ETB.getTBNew.Item6, ETB.getTBNew.Item7);
            TB1_Box.Text = VC.solveTimeblock(TBs_New[0]);
        }

        private void EditTB2Button_Click(object sender, EventArgs e)
        {
            EditTimeBlock ETB = new EditTimeBlock(TB2_Box.Text);
            ETB.ShowDialog();
            TBs_New[1] = VC.createTimeblock(ETB.getTBNew.Item1, ETB.getTBNew.Item2, ETB.getTBNew.Item3, ETB.getTBNew.Item4, ETB.getTBNew.Item5, ETB.getTBNew.Item6, ETB.getTBNew.Item7);
            TB2_Box.Text = VC.solveTimeblock(TBs_New[1]);
        }

        private void EditTB3Button_Click(object sender, EventArgs e)
        {
            EditTimeBlock ETB = new EditTimeBlock(TB3_Box.Text);
            ETB.ShowDialog();
            TBs_New[2] = VC.createTimeblock(ETB.getTBNew.Item1, ETB.getTBNew.Item2, ETB.getTBNew.Item3, ETB.getTBNew.Item4, ETB.getTBNew.Item5, ETB.getTBNew.Item6, ETB.getTBNew.Item7);
            TB3_Box.Text = VC.solveTimeblock(TBs_New[2]);
        }

        private void EditTB4Button_Click(object sender, EventArgs e)
        {
            EditTimeBlock ETB = new EditTimeBlock(TB4_Box.Text);
            ETB.ShowDialog();
            TBs_New[3] = VC.createTimeblock(ETB.getTBNew.Item1, ETB.getTBNew.Item2, ETB.getTBNew.Item3, ETB.getTBNew.Item4, ETB.getTBNew.Item5, ETB.getTBNew.Item6, ETB.getTBNew.Item7);
            TB4_Box.Text = VC.solveTimeblock(TBs_New[3]);
        }

        private void EditTB5Button_Click(object sender, EventArgs e)
        {
            EditTimeBlock ETB = new EditTimeBlock(TB5_Box.Text);
            ETB.ShowDialog();
            TBs_New[4] = VC.createTimeblock(ETB.getTBNew.Item1, ETB.getTBNew.Item2, ETB.getTBNew.Item3, ETB.getTBNew.Item4, ETB.getTBNew.Item5, ETB.getTBNew.Item6, ETB.getTBNew.Item7);
            TB5_Box.Text = VC.solveTimeblock(TBs_New[4]);
        }

        public int[] getTBs_new
        {
            get
            {
                return TBs_New;
            }
        }

        public DialogResult getResponse
        {
            get
            {
                return Response;
            }
        }

        public string getNewInstruct
        {
            get
            {
                return Instructor_New;
            }
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Time_String1 = new string[Course.NtimeBlocks];
            for (int i = 0; i < Course.NtimeBlocks; i++)
            {
                Time_String1[i] = VC.solveTimeblock(Course.TimeBlockCollection[i]);
            }
            string[] Time_String2 = new string[Course.NtimeBlocks];
            for (int i = 0; i < Course.NtimeBlocks; i++)
            {
                Time_String2[i] = VC.solveTimeblock(TBs_New[i]);
            }
            if (!VC.timeConflict(Time_String1, Course.TimeBlockCollection, Time_String2, TBs_New, true))
            {
                Response = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("There is a conflict with one or more of your chosen timeblocks. Please check your desired changes once more, or cancel.", "Edit Error", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Response = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Response = DialogResult.Cancel;
            this.Close();
        }
    }
}
