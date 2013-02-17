using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
            mainWnd = new DEACT();
            randomNr = new Random();
        }
        DEACT mainWnd;
        Random randomNr;

        private void Weather_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWnd.Show();
        }

        private void Weather_Load(object sender, EventArgs e)
        {
            #region Temperatures for days of week
            lblDay1.Text = randomNr.Next(12).ToString() + "°";
            lblDay2.Text = randomNr.Next(12).ToString() + "°";
            lblDay3.Text = randomNr.Next(12).ToString() + "°";
            lblDay4.Text = randomNr.Next(12).ToString() + "°";
            lblDay5.Text = randomNr.Next(12).ToString() + "°";
            lblDay6.Text = randomNr.Next(12).ToString() + "°";
            #endregion
            #region Dates Display
            lblDay1Date.Text = dtPick.Value.DayOfWeek.ToString();
            lblDay2Date.Text = dtPick.Value.AddDays(1).DayOfWeek.ToString();
            lblDay3Date.Text = dtPick.Value.AddDays(2).DayOfWeek.ToString();
            lblDay4Date.Text = dtPick.Value.AddDays(3).DayOfWeek.ToString();
            lblDay5Date.Text = dtPick.Value.AddDays(4).DayOfWeek.ToString();
            lblDay6Date.Text = dtPick.Value.AddDays(5).DayOfWeek.ToString();
            #endregion
            lblTodayDate.Text = dtPick.Value.ToLongDateString();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWnd.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWnd.Close();
            Application.Exit();
        }
    }
}
