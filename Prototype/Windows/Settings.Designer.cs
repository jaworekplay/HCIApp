namespace Prototype
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splCtn = new System.Windows.Forms.SplitContainer();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pctrBx_Volume = new System.Windows.Forms.PictureBox();
            this.trBar_VolumeCtrl = new System.Windows.Forms.TrackBar();
            this.lblVolumeValue = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splCtn)).BeginInit();
            this.splCtn.Panel1.SuspendLayout();
            this.splCtn.Panel2.SuspendLayout();
            this.splCtn.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBar_VolumeCtrl)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splCtn
            // 
            this.splCtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splCtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCtn.IsSplitterFixed = true;
            this.splCtn.Location = new System.Drawing.Point(0, 0);
            this.splCtn.Name = "splCtn";
            this.splCtn.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splCtn.Panel1
            // 
            this.splCtn.Panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.splCtn.Panel1.Controls.Add(this.lblMessage);
            // 
            // splCtn.Panel2
            // 
            this.splCtn.Panel2.Controls.Add(this.tabControl1);
            this.splCtn.Size = new System.Drawing.Size(1123, 538);
            this.splCtn.SplitterDistance = 76;
            this.splCtn.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(502, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(132, 37);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Settings";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 458);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.lbl_Volume);
            this.tabPage1.Controls.Add(this.btn_Home);
            this.tabPage1.Controls.Add(this.pctrBx_Volume);
            this.tabPage1.Controls.Add(this.trBar_VolumeCtrl);
            this.tabPage1.Controls.Add(this.lblVolumeValue);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1115, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Audio";
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Volume.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Volume.Location = new System.Drawing.Point(8, 43);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(63, 20);
            this.lbl_Volume.TabIndex = 16;
            this.lbl_Volume.Text = "Volume";
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Home.Location = new System.Drawing.Point(505, 322);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(184, 81);
            this.btn_Home.TabIndex = 15;
            this.btn_Home.Text = "OK";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // pctrBx_Volume
            // 
            this.pctrBx_Volume.Image = global::Prototype.Properties.Resources.Status_audio_volume_low_icon;
            this.pctrBx_Volume.ImageLocation = "";
            this.pctrBx_Volume.InitialImage = global::Prototype.Properties.Resources.Status_audio_volume_low_icon;
            this.pctrBx_Volume.Location = new System.Drawing.Point(128, 67);
            this.pctrBx_Volume.Name = "pctrBx_Volume";
            this.pctrBx_Volume.Size = new System.Drawing.Size(40, 40);
            this.pctrBx_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBx_Volume.TabIndex = 20;
            this.pctrBx_Volume.TabStop = false;
            // 
            // trBar_VolumeCtrl
            // 
            this.trBar_VolumeCtrl.Location = new System.Drawing.Point(77, 3);
            this.trBar_VolumeCtrl.Maximum = 100;
            this.trBar_VolumeCtrl.Name = "trBar_VolumeCtrl";
            this.trBar_VolumeCtrl.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trBar_VolumeCtrl.Size = new System.Drawing.Size(45, 104);
            this.trBar_VolumeCtrl.TabIndex = 17;
            this.trBar_VolumeCtrl.TickFrequency = 10;
            this.trBar_VolumeCtrl.Value = 25;
            this.trBar_VolumeCtrl.Scroll += new System.EventHandler(this.trBar_VolumeCtrl_Scroll);
            this.trBar_VolumeCtrl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trBar_VolumeCtrl_MouseUp);
            // 
            // lblVolumeValue
            // 
            this.lblVolumeValue.AutoSize = true;
            this.lblVolumeValue.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVolumeValue.Location = new System.Drawing.Point(138, 43);
            this.lblVolumeValue.Name = "lblVolumeValue";
            this.lblVolumeValue.Size = new System.Drawing.Size(19, 13);
            this.lblVolumeValue.TabIndex = 19;
            this.lblVolumeValue.Text = "25";
            this.lblVolumeValue.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1115, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1115, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(113, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(208, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lukasz Banach";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(113, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(208, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "JaworekP1ay Ltd.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(114, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(178, 22);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.jaworekp1ay.co.uk";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 538);
            this.ControlBox = false;
            this.Controls.Add(this.splCtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.splCtn.Panel1.ResumeLayout(false);
            this.splCtn.Panel1.PerformLayout();
            this.splCtn.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splCtn)).EndInit();
            this.splCtn.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBar_VolumeCtrl)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splCtn;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label lbl_Volume;
        private System.Windows.Forms.TrackBar trBar_VolumeCtrl;
        private System.Windows.Forms.Label lblVolumeValue;
        private System.Windows.Forms.PictureBox pctrBx_Volume;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}