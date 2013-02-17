using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype.Dialogs
{
    public partial class PIN : Form
    {
        public PIN(bool bSettings)
        {
            InitializeComponent();
            stngs = new Settings();
            scrt = new Security();
            mainWnd = new DEACT();
            m_bSettings = bSettings;
        }
        bool m_bSettings;
        DEACT mainWnd;
        Settings stngs;
        Security scrt;
        string[] pin = {"1","2","3","4"};

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (m_bSettings)
            {
                if (nr1.SelectedItem.ToString() == pin[0] && nr2.SelectedItem.ToString() == pin[1] && nr3.SelectedItem.ToString() == pin[2] && nr4.SelectedItem.ToString() == pin[3])
                {
                    stngs.Show();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Incorrect PIN !!!", "VALIDATION FAILED", MessageBoxButtons.OK);
                    this.Close();
                    mainWnd.Show();
                }
            }
            else
            {
                if (nr1.Text == pin[0] && nr2.Text == pin[1] && nr3.Text == pin[2] && nr4.Text == pin[3])
                {
                    scrt.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect PIN !!!", "VALIDATION FAILED", MessageBoxButtons.OK);
                    this.Close();
                    mainWnd.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWnd.Show();
        }
    }
}
