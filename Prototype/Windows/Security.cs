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
    public partial class Security : Form
    {
        public Security()
        {
            InitializeComponent();
            mainWnd = new DEACT();
        }
        private DEACT mainWnd;

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWnd.Show();
        }
    }
}
