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
    
    public partial class EditTimeBlock : Form
    {
        private (int, int, bool, int, int, bool, bool[]) TB_New;
        private bool[] days = new bool[5] { false, false, false, false, false };
        DialogResult Response;
        public EditTimeBlock(string TBs)
        {
            InitializeComponent();
            if (TBs != "new")
            {
                
                if (TBs.Contains("Mon"))
                {
                    checkBox1.Checked = true;
                    days[0] = true;
                }
                if (TBs.Contains("Tues"))
                {
                    checkBox2.Checked = true;
                    days[1] = true;
                }
                if (TBs.Contains("Weds"))
                {
                    checkBox3.Checked = true;
                    days[2] = true;
                }
                if (TBs.Contains("Thurs"))
                {
                    checkBox4.Checked = true;
                    days[3] = true;
                }
                if (TBs.Contains("Fri"))
                {
                    checkBox5.Checked = true;
                    days[4] = true;
                }
                string[] dts = TBs.Split(',');
                string time = dts[dts.Length - 1];
                string hStartSubString = time.Trim().Substring(0, 2);
                HourStart.Value = Convert.ToInt32(hStartSubString);
                string mStartSubString = time.Trim().Substring(3, 2);
                MinuteStart.Value = Convert.ToInt32(mStartSubString);
                string sAmOrPm = time.Substring(6, 2);
                if (sAmOrPm == "AM")
                {
                    AMStart.Checked = true;
                    PMStart.Checked = false;
                }
                else
                {
                    AMStart.Checked = false;
                    PMStart.Checked = true;
                }
                string hourSubString = time.Trim().Substring(11, 2);
                HourEnd.Value = Convert.ToInt32(hourSubString);
                string minSubString = time.Trim().Substring(14, 2);
                MinuteEnd.Value = Convert.ToInt32(minSubString);
                string amOrPm = time.Trim().Substring(16, 2);
                if (amOrPm == "AM")
                {
                    AMEnd.Checked = true;
                    PMEnd.Checked = false;
                }
                else
                {
                    AMEnd.Checked = false;
                    PMEnd.Checked = true;
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            days[0] = !days[0];
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            days[1] = !days[1];
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            days[2] = !days[2];
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            days[3] = !days[3];
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            days[4] = !days[4];
        }

        private void AMStart_CheckedChanged(object sender, EventArgs e)
        {
            PMStart.Checked = !AMStart.Checked;
        }

        private void PMStart_CheckedChanged(object sender, EventArgs e)
        {
            AMStart.Checked = !PMStart.Checked;
        }

        private void AMEnd_CheckedChanged(object sender, EventArgs e)
        {
            PMEnd.Checked = !AMEnd.Checked;
        }

        private void PMEnd_CheckedChanged(object sender, EventArgs e)
        {
            AMEnd.Checked = !PMEnd.Checked;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                TB_New = (Convert.ToInt32(HourStart.Value), Convert.ToInt32(MinuteStart.Value), AMStart.Checked, Convert.ToInt32(HourEnd.Value), Convert.ToInt32(MinuteEnd.Value), AMEnd.Checked, days);
                Response = DialogResult.OK;
            }
            catch
            {
                Response = DialogResult.Cancel;
            }
            this.Close();
        }

        public (int, int, bool, int, int, bool, bool[]) getTBNew
        {
            get
            {
                return TB_New;
            }
        }

        public DialogResult getResponse
        {
            get
            {
                return Response;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Response = DialogResult.Cancel;
            this.Close();
        }
    }
}
