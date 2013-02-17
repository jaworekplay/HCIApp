namespace Prototype
{
    partial class Hot_Water
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
            this.mainCnt = new System.Windows.Forms.SplitContainer();
            this.rdbtn_OFF = new System.Windows.Forms.RadioButton();
            this.rdbtn_ON = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_CurrentPage = new System.Windows.Forms.Label();
            this.txtBx2 = new System.Windows.Forms.MaskedTextBox();
            this.txtBx1 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_OFF = new System.Windows.Forms.Label();
            this.lbl_ON = new System.Windows.Forms.Label();
            this.lbl_tempIndicator = new System.Windows.Forms.Label();
            this.trckbr = new System.Windows.Forms.TrackBar();
            this.lbl_temp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainCnt)).BeginInit();
            this.mainCnt.Panel1.SuspendLayout();
            this.mainCnt.Panel2.SuspendLayout();
            this.mainCnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbr)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCnt
            // 
            this.mainCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainCnt.Location = new System.Drawing.Point(0, 0);
            this.mainCnt.Name = "mainCnt";
            this.mainCnt.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainCnt.Panel1
            // 
            this.mainCnt.Panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.mainCnt.Panel1.Controls.Add(this.rdbtn_OFF);
            this.mainCnt.Panel1.Controls.Add(this.rdbtn_ON);
            this.mainCnt.Panel1.Controls.Add(this.lbl_Status);
            this.mainCnt.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // mainCnt.Panel2
            // 
            this.mainCnt.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mainCnt.Panel2.Controls.Add(this.btn_Exit);
            this.mainCnt.Panel2.Controls.Add(this.btn_Home);
            this.mainCnt.Panel2.Controls.Add(this.lbl_CurrentPage);
            this.mainCnt.Panel2.Controls.Add(this.txtBx2);
            this.mainCnt.Panel2.Controls.Add(this.txtBx1);
            this.mainCnt.Panel2.Controls.Add(this.lbl_OFF);
            this.mainCnt.Panel2.Controls.Add(this.lbl_ON);
            this.mainCnt.Panel2.Controls.Add(this.lbl_tempIndicator);
            this.mainCnt.Panel2.Controls.Add(this.trckbr);
            this.mainCnt.Panel2.Controls.Add(this.lbl_temp);
            this.mainCnt.Size = new System.Drawing.Size(1133, 548);
            this.mainCnt.SplitterDistance = 71;
            this.mainCnt.TabIndex = 0;
            // 
            // rdbtn_OFF
            // 
            this.rdbtn_OFF.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_OFF.AutoSize = true;
            this.rdbtn_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_OFF.Location = new System.Drawing.Point(940, 12);
            this.rdbtn_OFF.Name = "rdbtn_OFF";
            this.rdbtn_OFF.Size = new System.Drawing.Size(92, 47);
            this.rdbtn_OFF.TabIndex = 2;
            this.rdbtn_OFF.Text = "OFF";
            this.rdbtn_OFF.UseVisualStyleBackColor = true;
            // 
            // rdbtn_ON
            // 
            this.rdbtn_ON.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_ON.AutoSize = true;
            this.rdbtn_ON.Checked = true;
            this.rdbtn_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_ON.Location = new System.Drawing.Point(485, 12);
            this.rdbtn_ON.Name = "rdbtn_ON";
            this.rdbtn_ON.Size = new System.Drawing.Size(76, 47);
            this.rdbtn_ON.TabIndex = 1;
            this.rdbtn_ON.TabStop = true;
            this.rdbtn_ON.Text = "ON";
            this.rdbtn_ON.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(12, 24);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(108, 37);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "Status";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Location = new System.Drawing.Point(937, 380);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(184, 81);
            this.btn_Exit.TabIndex = 18;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Home.Location = new System.Drawing.Point(12, 380);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(184, 81);
            this.btn_Home.TabIndex = 17;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lbl_CurrentPage
            // 
            this.lbl_CurrentPage.AutoSize = true;
            this.lbl_CurrentPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_CurrentPage.Location = new System.Drawing.Point(478, 427);
            this.lbl_CurrentPage.Name = "lbl_CurrentPage";
            this.lbl_CurrentPage.Size = new System.Drawing.Size(100, 37);
            this.lbl_CurrentPage.TabIndex = 16;
            this.lbl_CurrentPage.Text = "label1";
            // 
            // txtBx2
            // 
            this.txtBx2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBx2.Location = new System.Drawing.Point(328, 206);
            this.txtBx2.Mask = "00:00";
            this.txtBx2.Name = "txtBx2";
            this.txtBx2.Size = new System.Drawing.Size(88, 44);
            this.txtBx2.TabIndex = 15;
            this.txtBx2.ValidatingType = typeof(System.DateTime);
            // 
            // txtBx1
            // 
            this.txtBx1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBx1.Location = new System.Drawing.Point(326, 144);
            this.txtBx1.Mask = "00:00";
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.Size = new System.Drawing.Size(88, 44);
            this.txtBx1.TabIndex = 14;
            this.txtBx1.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_OFF
            // 
            this.lbl_OFF.AutoSize = true;
            this.lbl_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OFF.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_OFF.Location = new System.Drawing.Point(12, 209);
            this.lbl_OFF.Name = "lbl_OFF";
            this.lbl_OFF.Size = new System.Drawing.Size(254, 37);
            this.lbl_OFF.TabIndex = 13;
            this.lbl_OFF.Text = "Switch OFF time";
            // 
            // lbl_ON
            // 
            this.lbl_ON.AutoSize = true;
            this.lbl_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ON.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ON.Location = new System.Drawing.Point(12, 147);
            this.lbl_ON.Name = "lbl_ON";
            this.lbl_ON.Size = new System.Drawing.Size(238, 37);
            this.lbl_ON.TabIndex = 12;
            this.lbl_ON.Text = "Switch ON time";
            // 
            // lbl_tempIndicator
            // 
            this.lbl_tempIndicator.AutoSize = true;
            this.lbl_tempIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempIndicator.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tempIndicator.Location = new System.Drawing.Point(472, 45);
            this.lbl_tempIndicator.Name = "lbl_tempIndicator";
            this.lbl_tempIndicator.Size = new System.Drawing.Size(130, 73);
            this.lbl_tempIndicator.TabIndex = 11;
            this.lbl_tempIndicator.Text = "40°";
            // 
            // trckbr
            // 
            this.trckbr.LargeChange = 10;
            this.trckbr.Location = new System.Drawing.Point(940, 3);
            this.trckbr.Maximum = 50;
            this.trckbr.Name = "trckbr";
            this.trckbr.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckbr.Size = new System.Drawing.Size(45, 181);
            this.trckbr.TabIndex = 10;
            this.trckbr.TickFrequency = 10;
            this.trckbr.Scroll += new System.EventHandler(this.trckbr_Scroll);
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_temp.Location = new System.Drawing.Point(12, 75);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(200, 37);
            this.lbl_temp.TabIndex = 0;
            this.lbl_temp.Text = "Temperature";
            // 
            // Hot_Water
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 548);
            this.ControlBox = false;
            this.Controls.Add(this.mainCnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Hot_Water";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hot Water";
            this.mainCnt.Panel1.ResumeLayout(false);
            this.mainCnt.Panel1.PerformLayout();
            this.mainCnt.Panel2.ResumeLayout(false);
            this.mainCnt.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCnt)).EndInit();
            this.mainCnt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trckbr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainCnt;
        private System.Windows.Forms.RadioButton rdbtn_OFF;
        private System.Windows.Forms.RadioButton rdbtn_ON;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.TrackBar trckbr;
        private System.Windows.Forms.Label lbl_tempIndicator;
        private System.Windows.Forms.Label lbl_OFF;
        private System.Windows.Forms.Label lbl_ON;
        private System.Windows.Forms.MaskedTextBox txtBx2;
        private System.Windows.Forms.MaskedTextBox txtBx1;
        private System.Windows.Forms.Label lbl_CurrentPage;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Exit;
    }
}