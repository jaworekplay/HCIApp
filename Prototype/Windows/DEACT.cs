using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prototype
{
    public partial class DEACT : Form
    {
        public DEACT()
        {
            InitializeComponent();
            billValue = new Bill();
            location = new Point(this.Width / 2 - 40, this.Height / 2 + 200);
            g_Location = location;
            g_nHeight = this.Height;
            g_nWidth = this.Width;
        }
        #region Pages enum and Bill stuff
        public int g_nHeight;
        public int g_nWidth;
        public Point g_Location;
        private Bill billValue;
        private enum EPageNumbers
        {
            Electricity = 0,
            HotWater,
            Heating,
            CurrentUsage,
            BillStatus,
            Monitor,
            Weather,
            Security,
            Settings,
            count
        };
        private int m_nCurrentPage;
        private Pages pageNames = new Pages();
        private System.Drawing.Point location;
        #endregion
        #region Buttons Declarations
        private CurrentUsage cU;
        private Electricity elc;
        private Heating htng;
        private Hot_Water htWtr;
        private Monitor mntr;
        private Weather wthr;
        private Prototype.Dialogs.PIN SecurityPIN;
        #endregion
        #region Loading and Closing
            private void DEACT_Load(object sender, EventArgs e)
        {
            m_nCurrentPage = (int)EPageNumbers.count;
            this.lbl_Main_CurrentPageDisplay.Text = pageNames.PageNameCallback(m_nCurrentPage);
            this.lbl_Main_CurrentPageDisplay.Location = location;
        }

        private void CleanUP(object sender, EventArgs e)
        {
            elc.Close();
            this.Close();
            Application.Exit();
        }

        private void DEACT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
#endregion
        #region Buttons Clicks
        private void btn_Electricity_Click(object sender, EventArgs e)
        {
            this.Hide();
            elc = new Electricity();
            elc.Height = g_nHeight;
            elc.Width = g_nWidth;
            elc.Show();
        }

        private void btn_HotWater_Click(object sender, EventArgs e)
        {
            htWtr = new Hot_Water();
            this.Hide();
            htWtr.Height = g_nHeight;
            htWtr.Width = g_nWidth;
            htWtr.Show();
        }

        private void btn_Heating_Click(object sender, EventArgs e)
        {
            htng = new Heating();
            this.Hide();
            htng.Height = g_nHeight;
            htng.Width = g_nWidth;
            htng.Show();
        }

        private void btn_Monitor_Click(object sender, EventArgs e)
        {
            mntr = new Monitor();
            this.Hide();
            mntr.Show();
        }

        private void btn_Weather_Click(object sender, EventArgs e)
        {
            wthr = new Weather();
            this.Hide();
            wthr.Show();
        }

        private void btn_Security_Click(object sender, EventArgs e)
        {
            SecurityPIN = new Dialogs.PIN(false);
            SecurityPIN.Show();
            this.Hide();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecurityPIN = new Dialogs.PIN(true);
            SecurityPIN.Show();
        }

        private void btn_BillStatus_Click(object sender, EventArgs e)
        {
            cU = new CurrentUsage();
            this.Hide();
            cU.Height = g_nHeight;
            cU.Width = g_nWidth;
            cU.Show();
        }
        #endregion
    }
}
