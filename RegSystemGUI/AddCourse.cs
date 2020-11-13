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
        private string instructor;
        private int[] TBs = new int[5] { 0, 0, 0, 0, 0 };
        private Program.viewCourses VC = new Program.viewCourses();
        public AddCourse(ref Program.UserDatabase uData)
        {
            InitializeComponent();
            UDATA = uData;
        }

        private void Instructor_Button_Click(object sender, EventArgs e)
        {
            AccountSelector AS = new AccountSelector(ref UDATA, "faculty");
            AS.ShowDialog();
            instructor = AS.getAccount();

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
            EditTimeBlock ETB = new EditTimeBlock("new");
            ETB.ShowDialog();
            TB
        }
    }
}
