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
    public partial class FacultySelector : Form
    {
        private string studentUser;
        public FacultySelector()
        {
            InitializeComponent();
            FacultyBox.Clear();
        }

        public string getFaculty
        {
            get
            {
                return this.FacultyBox.Text;
            }
        }

        private void FacultyConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
