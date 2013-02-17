using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Prototype
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            mainWnd = new DEACT();
            StartTheMusicPlayer();
        }
        private
        DEACT mainWnd;
        SoundPlayer player;
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWnd.Show();
        }
        private void StartTheMusicPlayer()
        {
            player = new SoundPlayer(Environment.CurrentDirectory + "\\Audio\\turret.wav");
            player.LoadAsync();
        }

        private void trBar_VolumeCtrl_Scroll(object sender, EventArgs e)
        {
            if (trBar_VolumeCtrl.Value <= 30 && trBar_VolumeCtrl.Value > 0)
                pctrBx_Volume.Image = global::Prototype.Properties.Resources.Status_audio_volume_low_icon;
            else if (trBar_VolumeCtrl.Value > 30 && trBar_VolumeCtrl.Value <= 60)
                pctrBx_Volume.Image = global::Prototype.Properties.Resources.Status_audio_volume_medium_icon;
            else if (trBar_VolumeCtrl.Value > 60)
                pctrBx_Volume.Image = global::Prototype.Properties.Resources.Status_audio_volume_high_icon;
            else
                pctrBx_Volume.Image = global::Prototype.Properties.Resources.Status_audio_volume_muted_icon;
        }

        private void trBar_VolumeCtrl_MouseUp(object sender, MouseEventArgs e)
        {
            player.Play();
        }
    }
}
