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
    public partial class CurrentUsage : Form
    {
        public CurrentUsage()
        {
            InitializeComponent();
            prgBr_Elec.Value = 40;
            lbl_elec_perc.Text = prgBr_Elec.Value.ToString() + "%";
            prgBr_Heating.Value = 35;
            lbl_Heating_perc.Text = prgBr_Heating.Value.ToString() + "%";
            prgBrHtWtr.Value = 20;
            lbl_HtWtr_perc.Text = prgBrHtWtr.Value.ToString() + "%";
            prgBr_Security.Value = 5;
            lbl_Sec_perc.Text = prgBr_Security.Value.ToString() + "%";
            m_mw = new DEACT();
        }
        private DEACT m_mw;

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            m_mw.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            m_mw.Close();
            Application.Exit();
        }
    }
}
