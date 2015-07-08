using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker.Dialogs
{
    public partial class EditTimeRecord : Form
    {
        public EditTimeRecord()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void EditTimeRecord_Load(object sender, EventArgs e)
        {
            //SetFriendlyTime();

            //textBoxTimeAccrued
        }

        private void SetFriendlyTime()
        {
            try
            {
                DateTime dtStart = Convert.ToDateTime(textBoxWorkStartDate.Text);
                DateTime dtEnd = Convert.ToDateTime(textBoxWorkEndTime.Text);

                TimeSpan duration = dtEnd.Subtract(dtStart);

                textBoxFriendlyTime.Text = TimeSpanToFriendlyString(duration);
            }
            catch (Exception ex)
            {
            }
        }

        string TimeSpanToFriendlyString(TimeSpan ts)
        {
            return string.Format("{0}:{1}:{2}", ts.Hours.ToString("00"), ts.Minutes.ToString("00"), ts.Seconds.ToString("00"));
        }

        private void StartOrEndDateModified()
        {
            try
            {
                DateTime dtStart = Convert.ToDateTime(textBoxWorkStartDate.Text);
                DateTime dtEnd = Convert.ToDateTime(textBoxWorkEndTime.Text);

                TimeSpan duration = dtEnd.Subtract(dtStart);

                textBoxTimeAccrued.Text = duration.TotalMinutes.ToString();

                SetFriendlyTime();

                buttonOK.Enabled = true;
            }
            catch (Exception ex)
            {
                buttonOK.Enabled = false;
            }
        }

        private void textBoxWorkStartDate_TextChanged(object sender, EventArgs e)
        {
            StartOrEndDateModified();

        }

        private void textBoxWorkEndTime_TextChanged(object sender, EventArgs e)
        {
            StartOrEndDateModified();

        }

        private void textBoxTimeAccrued_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
