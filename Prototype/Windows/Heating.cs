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
    public partial class Heating : Form
    {
        private DEACT m_mainWnd;
        public Heating()
        {
            InitializeComponent();
            lbl_CurrentPage.Location = new Point((this.Width / 2) - 51, 430);
            m_mainWnd = new DEACT();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (rdbtn_ON.Checked)
            {
                splCtn.Panel1.BackColor = System.Drawing.Color.PaleGreen;
                lbl_tempIndicator.ForeColor = System.Drawing.Color.White;
                trckbr.Enabled = true;
                txtBx1.Enabled = true;
                txtBx2.Enabled = true;
            }
            else
            {
                splCtn.Panel1.BackColor = System.Drawing.Color.IndianRed;
                lbl_tempIndicator.ForeColor = System.Drawing.Color.Gray;
                trckbr.Enabled = false;
                txtBx1.Enabled = false;
                txtBx2.Enabled = false;
            }
        }

        private void trckbr_Scroll(object sender, EventArgs e)
        {
            lbl_tempIndicator.Text = trckbr.Value.ToString() + "°";
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            m_mainWnd.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            m_mainWnd.Close();
            Application.Exit();
        }
    }
}
