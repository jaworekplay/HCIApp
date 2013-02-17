using System;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Hot_Water : Form
    {
        private DEACT mainWnd;
        private Pages m_page= new Pages();
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
        public Hot_Water()
        {
            InitializeComponent();
            mainWnd = new DEACT();
            lbl_CurrentPage.Text = m_page.PageNameCallback((int)EPageNumbers.HotWater);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (rdbtn_ON.Checked)
            {
                mainCnt.Panel1.BackColor = System.Drawing.Color.PaleGreen;
                trckbr.Enabled = true;
                lbl_tempIndicator.ForeColor = System.Drawing.Color.White;
                txtBx1.ForeColor = System.Drawing.Color.White;
                txtBx2.ForeColor = System.Drawing.Color.White;
                txtBx1.Enabled = true;
                txtBx2.Enabled = true;
            }
            else
            {
                mainCnt.Panel1.BackColor = System.Drawing.Color.IndianRed;
                trckbr.Enabled = false;
                lbl_tempIndicator.ForeColor = System.Drawing.Color.Gray;
                txtBx1.ForeColor = System.Drawing.Color.Gray;
                txtBx2.ForeColor = System.Drawing.Color.Gray;
                txtBx1.Enabled = false;
                txtBx2.Enabled = false;
            }
        }

        private void trckbr_Scroll(object sender, EventArgs e)
        {
            lbl_tempIndicator.Text = (trckbr.Value + 40).ToString() + "°";
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
