using ConsoleTest;
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
    public partial class LoginForm : Form
    {
        private CourseDatabase cDatabase;
        private UserDatabase uDatabase;
        public LoginForm(UserDatabase userDatabase, CourseDatabase courseDatabase)
        {
            InitializeComponent();
            cDatabase = courseDatabase;
            uDatabase = userDatabase;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text;
            string password = textBox1.Text;
            if(uDatabase.authenticateUser(username, password) != "Failed")
            {
                this.Hide();
                Form2 options = new Form2();
                options.Show();
            }
        }

    }
}
