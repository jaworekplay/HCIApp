using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Prototype
{
    public partial class Electricity : Form
    {
        public Electricity()
        {
            InitializeComponent();
            pageNames = new Pages();
            bill = new Bill();
            MainWindow = new DEACT();
            //-------------------------------
            lbl_UsagePerc.Text = "80%";
            clrBtn = Color.LightGray;
        }
        Color clrBtn;

        //these are main window controls
        private DEACT MainWindow;
        private Pages pageNames;
        private Bill bill;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            #region Electricity ON
            if (rdbtn_StatusON.Checked)
            {
                splCtn.Panel1.BackColor = System.Drawing.Color.PaleGreen;
                prgbr.Value = 80;
                lbl_UsagePerc.Text = "80%";
                mskdTxtBx_Electricity_ON_time.Enabled = true;
                mskdTxtBx_Electricity_OFF_time.Enabled = true;
                grpBx_WashingMachine.Enabled = true;
                grpBx_Lights.Enabled = true;
                rdBtn_WM_ON.Enabled = true;
                rdBtn_WM_OFF.Enabled = true;
                rdBtn_L_ON.Enabled = true;
                rdBtn_L_OFF.Enabled = true;
            }
            else
            {
                splCtn.Panel1.BackColor = System.Drawing.Color.IndianRed;
                prgbr.Value = 0;
                lbl_UsagePerc.Text = "0%";
                mskdTxtBx_Electricity_ON_time.Enabled = false;
                mskdTxtBx_Electricity_OFF_time.Enabled = false;
                grpBx_WashingMachine.Enabled = false;
                grpBx_Lights.Enabled = false;
                rdBtn_WM_ON.Enabled = false;
                rdBtn_WM_OFF.Enabled = false;
                rdBtn_L_ON.Enabled = false;
                rdBtn_L_OFF.Enabled = false;
            }
            #endregion
            if (rdBtn_L_ON.Checked && rdBtn_L_ON.Enabled)
            {
                rdBtn_L_ON.BackColor = System.Drawing.Color.SpringGreen;
                rdBtn_L_OFF.BackColor = clrBtn;
            }
            else
            {
                rdBtn_L_OFF.BackColor = System.Drawing.Color.IndianRed;
                rdBtn_L_ON.BackColor = clrBtn;
            }

            if (rdBtn_WM_ON.Checked && rdBtn_WM_ON.Enabled)
            {
                rdBtn_WM_ON.BackColor = System.Drawing.Color.SpringGreen;
                rdBtn_WM_OFF.BackColor = clrBtn;
            }
            else
            {
                rdBtn_WM_OFF.BackColor = System.Drawing.Color.IndianRed;
                rdBtn_WM_ON.BackColor = clrBtn;
            }
        }

        private void Electricity_Load(object sender, EventArgs e)
        {
            lbl_PageName.Text = pageNames.PageNameCallback(0);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.Close();
            Application.Exit();
        }
    }
}
