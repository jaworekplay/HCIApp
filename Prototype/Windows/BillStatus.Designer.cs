namespace Prototype
{
    partial class CurrentUsage
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
            this.lbl_CurrentUsage = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.grpBx_Bill = new System.Windows.Forms.GroupBox();
            this.lbl_BillValue = new System.Windows.Forms.Label();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.frame = new System.Windows.Forms.GroupBox();
            this.lbl_Sec_perc = new System.Windows.Forms.Label();
            this.lbl_Heating_perc = new System.Windows.Forms.Label();
            this.lbl_HtWtr_perc = new System.Windows.Forms.Label();
            this.lbl_elec_perc = new System.Windows.Forms.Label();
            this.prgBr_Security = new System.Windows.Forms.ProgressBar();
            this.prgBr_Heating = new System.Windows.Forms.ProgressBar();
            this.prgBrHtWtr = new System.Windows.Forms.ProgressBar();
            this.prgBr_Elec = new System.Windows.Forms.ProgressBar();
            this.lbl_Heating = new System.Windows.Forms.Label();
            this.lbl_HotWater = new System.Windows.Forms.Label();
            this.lbl_Electricity = new System.Windows.Forms.Label();
            this.lbl_Security = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splCtn)).BeginInit();
            this.splCtn.Panel1.SuspendLayout();
            this.splCtn.Panel2.SuspendLayout();
            this.splCtn.SuspendLayout();
            this.grpBx_Bill.SuspendLayout();
            this.frame.SuspendLayout();
            this.SuspendLayout();
            // 
            // splCtn
            // 
            this.splCtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splCtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCtn.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splCtn.IsSplitterFixed = true;
            this.splCtn.Location = new System.Drawing.Point(0, 0);
            this.splCtn.Name = "splCtn";
            this.splCtn.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splCtn.Panel1
            // 
            this.splCtn.Panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.splCtn.Panel1.Controls.Add(this.lbl_CurrentUsage);
            // 
            // splCtn.Panel2
            // 
            this.splCtn.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splCtn.Panel2.Controls.Add(this.btn_Exit);
            this.splCtn.Panel2.Controls.Add(this.btn_Home);
            this.splCtn.Panel2.Controls.Add(this.grpBx_Bill);
            this.splCtn.Panel2.Controls.Add(this.frame);
            this.splCtn.Size = new System.Drawing.Size(1133, 548);
            this.splCtn.SplitterDistance = 76;
            this.splCtn.TabIndex = 0;
            // 
            // lbl_CurrentUsage
            // 
            this.lbl_CurrentUsage.AutoSize = true;
            this.lbl_CurrentUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentUsage.Location = new System.Drawing.Point(426, 17);
            this.lbl_CurrentUsage.Name = "lbl_CurrentUsage";
            this.lbl_CurrentUsage.Size = new System.Drawing.Size(159, 37);
            this.lbl_CurrentUsage.TabIndex = 0;
            this.lbl_CurrentUsage.Text = "Bill Status";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Location = new System.Drawing.Point(936, 374);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(184, 81);
            this.btn_Exit.TabIndex = 17;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Home.Location = new System.Drawing.Point(11, 374);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(184, 81);
            this.btn_Home.TabIndex = 16;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // grpBx_Bill
            // 
            this.grpBx_Bill.Controls.Add(this.lbl_BillValue);
            this.grpBx_Bill.Controls.Add(this.lbl_Bill);
            this.grpBx_Bill.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBx_Bill.Location = new System.Drawing.Point(7, 4);
            this.grpBx_Bill.Name = "grpBx_Bill";
            this.grpBx_Bill.Size = new System.Drawing.Size(1116, 57);
            this.grpBx_Bill.TabIndex = 15;
            this.grpBx_Bill.TabStop = false;
            // 
            // lbl_BillValue
            // 
            this.lbl_BillValue.AutoSize = true;
            this.lbl_BillValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BillValue.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_BillValue.Location = new System.Drawing.Point(983, 11);
            this.lbl_BillValue.Name = "lbl_BillValue";
            this.lbl_BillValue.Size = new System.Drawing.Size(130, 37);
            this.lbl_BillValue.TabIndex = 5;
            this.lbl_BillValue.Text = "£110.83";
            // 
            // lbl_Bill
            // 
            this.lbl_Bill.AutoSize = true;
            this.lbl_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Bill.Location = new System.Drawing.Point(5, 11);
            this.lbl_Bill.Name = "lbl_Bill";
            this.lbl_Bill.Size = new System.Drawing.Size(175, 37);
            this.lbl_Bill.TabIndex = 0;
            this.lbl_Bill.Text = "Current Bill";
            // 
            // frame
            // 
            this.frame.Controls.Add(this.lbl_Sec_perc);
            this.frame.Controls.Add(this.lbl_Heating_perc);
            this.frame.Controls.Add(this.lbl_HtWtr_perc);
            this.frame.Controls.Add(this.lbl_elec_perc);
            this.frame.Controls.Add(this.prgBr_Security);
            this.frame.Controls.Add(this.prgBr_Heating);
            this.frame.Controls.Add(this.prgBrHtWtr);
            this.frame.Controls.Add(this.prgBr_Elec);
            this.frame.Controls.Add(this.lbl_Heating);
            this.frame.Controls.Add(this.lbl_HotWater);
            this.frame.Controls.Add(this.lbl_Electricity);
            this.frame.Controls.Add(this.lbl_Security);
            this.frame.Location = new System.Drawing.Point(7, 103);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(1116, 216);
            this.frame.TabIndex = 14;
            this.frame.TabStop = false;
            // 
            // lbl_Sec_perc
            // 
            this.lbl_Sec_perc.AutoSize = true;
            this.lbl_Sec_perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sec_perc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Sec_perc.Location = new System.Drawing.Point(1062, 178);
            this.lbl_Sec_perc.Name = "lbl_Sec_perc";
            this.lbl_Sec_perc.Size = new System.Drawing.Size(51, 20);
            this.lbl_Sec_perc.TabIndex = 13;
            this.lbl_Sec_perc.Text = "label4";
            // 
            // lbl_Heating_perc
            // 
            this.lbl_Heating_perc.AutoSize = true;
            this.lbl_Heating_perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heating_perc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Heating_perc.Location = new System.Drawing.Point(1062, 129);
            this.lbl_Heating_perc.Name = "lbl_Heating_perc";
            this.lbl_Heating_perc.Size = new System.Drawing.Size(51, 20);
            this.lbl_Heating_perc.TabIndex = 12;
            this.lbl_Heating_perc.Text = "label3";
            // 
            // lbl_HtWtr_perc
            // 
            this.lbl_HtWtr_perc.AutoSize = true;
            this.lbl_HtWtr_perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HtWtr_perc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_HtWtr_perc.Location = new System.Drawing.Point(1062, 76);
            this.lbl_HtWtr_perc.Name = "lbl_HtWtr_perc";
            this.lbl_HtWtr_perc.Size = new System.Drawing.Size(51, 20);
            this.lbl_HtWtr_perc.TabIndex = 11;
            this.lbl_HtWtr_perc.Text = "label2";
            // 
            // lbl_elec_perc
            // 
            this.lbl_elec_perc.AutoSize = true;
            this.lbl_elec_perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_elec_perc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_elec_perc.Location = new System.Drawing.Point(1062, 30);
            this.lbl_elec_perc.Name = "lbl_elec_perc";
            this.lbl_elec_perc.Size = new System.Drawing.Size(51, 20);
            this.lbl_elec_perc.TabIndex = 10;
            this.lbl_elec_perc.Text = "label1";
            // 
            // prgBr_Security
            // 
            this.prgBr_Security.Location = new System.Drawing.Point(244, 165);
            this.prgBr_Security.Name = "prgBr_Security";
            this.prgBr_Security.Size = new System.Drawing.Size(812, 37);
            this.prgBr_Security.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBr_Security.TabIndex = 9;
            // 
            // prgBr_Heating
            // 
            this.prgBr_Heating.Location = new System.Drawing.Point(244, 116);
            this.prgBr_Heating.Name = "prgBr_Heating";
            this.prgBr_Heating.Size = new System.Drawing.Size(812, 37);
            this.prgBr_Heating.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBr_Heating.TabIndex = 8;
            // 
            // prgBrHtWtr
            // 
            this.prgBrHtWtr.Location = new System.Drawing.Point(247, 63);
            this.prgBrHtWtr.Name = "prgBrHtWtr";
            this.prgBrHtWtr.Size = new System.Drawing.Size(809, 37);
            this.prgBrHtWtr.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBrHtWtr.TabIndex = 7;
            // 
            // prgBr_Elec
            // 
            this.prgBr_Elec.Location = new System.Drawing.Point(247, 17);
            this.prgBr_Elec.Name = "prgBr_Elec";
            this.prgBr_Elec.Size = new System.Drawing.Size(809, 37);
            this.prgBr_Elec.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBr_Elec.TabIndex = 6;
            // 
            // lbl_Heating
            // 
            this.lbl_Heating.AutoSize = true;
            this.lbl_Heating.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heating.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Heating.Location = new System.Drawing.Point(4, 116);
            this.lbl_Heating.Name = "lbl_Heating";
            this.lbl_Heating.Size = new System.Drawing.Size(127, 37);
            this.lbl_Heating.TabIndex = 4;
            this.lbl_Heating.Text = "Heating";
            // 
            // lbl_HotWater
            // 
            this.lbl_HotWater.AutoSize = true;
            this.lbl_HotWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HotWater.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_HotWater.Location = new System.Drawing.Point(4, 63);
            this.lbl_HotWater.Name = "lbl_HotWater";
            this.lbl_HotWater.Size = new System.Drawing.Size(162, 37);
            this.lbl_HotWater.TabIndex = 3;
            this.lbl_HotWater.Text = "Hot Water";
            // 
            // lbl_Electricity
            // 
            this.lbl_Electricity.AutoSize = true;
            this.lbl_Electricity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Electricity.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Electricity.Location = new System.Drawing.Point(4, 17);
            this.lbl_Electricity.Name = "lbl_Electricity";
            this.lbl_Electricity.Size = new System.Drawing.Size(152, 37);
            this.lbl_Electricity.TabIndex = 2;
            this.lbl_Electricity.Text = "Electricity";
            // 
            // lbl_Security
            // 
            this.lbl_Security.AutoSize = true;
            this.lbl_Security.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Security.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Security.Location = new System.Drawing.Point(4, 165);
            this.lbl_Security.Name = "lbl_Security";
            this.lbl_Security.Size = new System.Drawing.Size(131, 37);
            this.lbl_Security.TabIndex = 1;
            this.lbl_Security.Text = "Security";
            // 
            // CurrentUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 548);
            this.ControlBox = false;
            this.Controls.Add(this.splCtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CurrentUsage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Status";
            this.splCtn.Panel1.ResumeLayout(false);
            this.splCtn.Panel1.PerformLayout();
            this.splCtn.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splCtn)).EndInit();
            this.splCtn.ResumeLayout(false);
            this.grpBx_Bill.ResumeLayout(false);
            this.grpBx_Bill.PerformLayout();
            this.frame.ResumeLayout(false);
            this.frame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splCtn;
        private System.Windows.Forms.Label lbl_CurrentUsage;
        private System.Windows.Forms.Label lbl_Heating;
        private System.Windows.Forms.Label lbl_HotWater;
        private System.Windows.Forms.Label lbl_Electricity;
        private System.Windows.Forms.Label lbl_Security;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.Label lbl_BillValue;
        private System.Windows.Forms.ProgressBar prgBr_Security;
        private System.Windows.Forms.ProgressBar prgBr_Heating;
        private System.Windows.Forms.ProgressBar prgBrHtWtr;
        private System.Windows.Forms.ProgressBar prgBr_Elec;
        private System.Windows.Forms.Label lbl_Sec_perc;
        private System.Windows.Forms.Label lbl_Heating_perc;
        private System.Windows.Forms.Label lbl_HtWtr_perc;
        private System.Windows.Forms.Label lbl_elec_perc;
        private System.Windows.Forms.GroupBox frame;
        private System.Windows.Forms.GroupBox grpBx_Bill;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Exit;
    }
}