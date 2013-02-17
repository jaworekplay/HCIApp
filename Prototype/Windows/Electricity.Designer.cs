namespace Prototype
{
    partial class Electricity
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
            this.rdbtn_StatusOFF = new System.Windows.Forms.RadioButton();
            this.rdbtn_StatusON = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.mskdTxtBx_Electricity_OFF_time = new System.Windows.Forms.MaskedTextBox();
            this.mskdTxtBx_Electricity_ON_time = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBx_Lights = new System.Windows.Forms.GroupBox();
            this.rdBtn_L_OFF = new System.Windows.Forms.RadioButton();
            this.rdBtn_L_ON = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBx_WashingMachine = new System.Windows.Forms.GroupBox();
            this.rdBtn_WM_OFF = new System.Windows.Forms.RadioButton();
            this.rdBtn_WM_ON = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx2 = new System.Windows.Forms.MaskedTextBox();
            this.txtxBx1 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_SwitchOFF = new System.Windows.Forms.Label();
            this.lbl_SwitchON = new System.Windows.Forms.Label();
            this.lbl_UsagePerc = new System.Windows.Forms.Label();
            this.lbl_PageName = new System.Windows.Forms.Label();
            this.prgbr = new System.Windows.Forms.ProgressBar();
            this.lbl_CurrentUsage = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splCtn)).BeginInit();
            this.splCtn.Panel1.SuspendLayout();
            this.splCtn.Panel2.SuspendLayout();
            this.splCtn.SuspendLayout();
            this.grpBx_Lights.SuspendLayout();
            this.grpBx_WashingMachine.SuspendLayout();
            this.SuspendLayout();
            // 
            // splCtn
            // 
            this.splCtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCtn.Location = new System.Drawing.Point(0, 0);
            this.splCtn.Name = "splCtn";
            this.splCtn.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splCtn.Panel1
            // 
            this.splCtn.Panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.splCtn.Panel1.Controls.Add(this.rdbtn_StatusOFF);
            this.splCtn.Panel1.Controls.Add(this.rdbtn_StatusON);
            this.splCtn.Panel1.Controls.Add(this.lbl_Status);
            this.splCtn.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splCtn.Panel2
            // 
            this.splCtn.Panel2.AccessibleDescription = "Washing Machine on button";
            this.splCtn.Panel2.AccessibleName = "Washing Machine On";
            this.splCtn.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splCtn.Panel2.Controls.Add(this.btn_Home);
            this.splCtn.Panel2.Controls.Add(this.btn_Exit);
            this.splCtn.Panel2.Controls.Add(this.mskdTxtBx_Electricity_OFF_time);
            this.splCtn.Panel2.Controls.Add(this.mskdTxtBx_Electricity_ON_time);
            this.splCtn.Panel2.Controls.Add(this.label5);
            this.splCtn.Panel2.Controls.Add(this.label6);
            this.splCtn.Panel2.Controls.Add(this.grpBx_Lights);
            this.splCtn.Panel2.Controls.Add(this.grpBx_WashingMachine);
            this.splCtn.Panel2.Controls.Add(this.lbl_UsagePerc);
            this.splCtn.Panel2.Controls.Add(this.lbl_PageName);
            this.splCtn.Panel2.Controls.Add(this.prgbr);
            this.splCtn.Panel2.Controls.Add(this.lbl_CurrentUsage);
            this.splCtn.Size = new System.Drawing.Size(1133, 548);
            this.splCtn.SplitterDistance = 71;
            this.splCtn.TabIndex = 0;
            // 
            // rdbtn_StatusOFF
            // 
            this.rdbtn_StatusOFF.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_StatusOFF.AutoSize = true;
            this.rdbtn_StatusOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_StatusOFF.Location = new System.Drawing.Point(939, 12);
            this.rdbtn_StatusOFF.Name = "rdbtn_StatusOFF";
            this.rdbtn_StatusOFF.Size = new System.Drawing.Size(92, 47);
            this.rdbtn_StatusOFF.TabIndex = 2;
            this.rdbtn_StatusOFF.Text = "O&FF";
            this.rdbtn_StatusOFF.UseVisualStyleBackColor = true;
            // 
            // rdbtn_StatusON
            // 
            this.rdbtn_StatusON.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_StatusON.AutoSize = true;
            this.rdbtn_StatusON.Checked = true;
            this.rdbtn_StatusON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_StatusON.Location = new System.Drawing.Point(488, 12);
            this.rdbtn_StatusON.Name = "rdbtn_StatusON";
            this.rdbtn_StatusON.Size = new System.Drawing.Size(76, 47);
            this.rdbtn_StatusON.TabIndex = 1;
            this.rdbtn_StatusON.TabStop = true;
            this.rdbtn_StatusON.Text = "&ON";
            this.rdbtn_StatusON.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(18, 22);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(108, 37);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "Status";
            // 
            // mskdTxtBx_Electricity_OFF_time
            // 
            this.mskdTxtBx_Electricity_OFF_time.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mskdTxtBx_Electricity_OFF_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdTxtBx_Electricity_OFF_time.ForeColor = System.Drawing.SystemColors.Window;
            this.mskdTxtBx_Electricity_OFF_time.Location = new System.Drawing.Point(411, 119);
            this.mskdTxtBx_Electricity_OFF_time.Mask = "00:00";
            this.mskdTxtBx_Electricity_OFF_time.Name = "mskdTxtBx_Electricity_OFF_time";
            this.mskdTxtBx_Electricity_OFF_time.Size = new System.Drawing.Size(88, 44);
            this.mskdTxtBx_Electricity_OFF_time.TabIndex = 20;
            this.mskdTxtBx_Electricity_OFF_time.ValidatingType = typeof(System.DateTime);
            // 
            // mskdTxtBx_Electricity_ON_time
            // 
            this.mskdTxtBx_Electricity_ON_time.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mskdTxtBx_Electricity_ON_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdTxtBx_Electricity_ON_time.ForeColor = System.Drawing.SystemColors.Window;
            this.mskdTxtBx_Electricity_ON_time.Location = new System.Drawing.Point(411, 57);
            this.mskdTxtBx_Electricity_ON_time.Mask = "00:00";
            this.mskdTxtBx_Electricity_ON_time.Name = "mskdTxtBx_Electricity_ON_time";
            this.mskdTxtBx_Electricity_ON_time.Size = new System.Drawing.Size(87, 44);
            this.mskdTxtBx_Electricity_ON_time.TabIndex = 19;
            this.mskdTxtBx_Electricity_ON_time.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(18, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "Switch OFF time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(18, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Switch ON time";
            // 
            // grpBx_Lights
            // 
            this.grpBx_Lights.Controls.Add(this.rdBtn_L_OFF);
            this.grpBx_Lights.Controls.Add(this.rdBtn_L_ON);
            this.grpBx_Lights.Controls.Add(this.label2);
            this.grpBx_Lights.Controls.Add(this.maskedTextBox1);
            this.grpBx_Lights.Controls.Add(this.maskedTextBox2);
            this.grpBx_Lights.Controls.Add(this.label3);
            this.grpBx_Lights.Controls.Add(this.label4);
            this.grpBx_Lights.Location = new System.Drawing.Point(570, 162);
            this.grpBx_Lights.Name = "grpBx_Lights";
            this.grpBx_Lights.Size = new System.Drawing.Size(551, 210);
            this.grpBx_Lights.TabIndex = 16;
            this.grpBx_Lights.TabStop = false;
            // 
            // rdBtn_L_OFF
            // 
            this.rdBtn_L_OFF.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBtn_L_OFF.AutoSize = true;
            this.rdBtn_L_OFF.Checked = true;
            this.rdBtn_L_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_L_OFF.Location = new System.Drawing.Point(453, 11);
            this.rdBtn_L_OFF.Name = "rdBtn_L_OFF";
            this.rdBtn_L_OFF.Size = new System.Drawing.Size(92, 47);
            this.rdBtn_L_OFF.TabIndex = 15;
            this.rdBtn_L_OFF.TabStop = true;
            this.rdBtn_L_OFF.Text = "OFF";
            this.rdBtn_L_OFF.UseVisualStyleBackColor = true;
            // 
            // rdBtn_L_ON
            // 
            this.rdBtn_L_ON.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBtn_L_ON.AutoSize = true;
            this.rdBtn_L_ON.Checked = true;
            this.rdBtn_L_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_L_ON.Location = new System.Drawing.Point(334, 11);
            this.rdBtn_L_ON.Name = "rdBtn_L_ON";
            this.rdBtn_L_ON.Size = new System.Drawing.Size(76, 47);
            this.rdBtn_L_ON.TabIndex = 14;
            this.rdBtn_L_ON.TabStop = true;
            this.rdBtn_L_ON.Text = "ON";
            this.rdBtn_L_ON.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lights";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox1.Location = new System.Drawing.Point(398, 154);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(88, 44);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox2.Location = new System.Drawing.Point(399, 92);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(87, 44);
            this.maskedTextBox2.TabIndex = 10;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Switch OFF time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Switch ON time";
            // 
            // grpBx_WashingMachine
            // 
            this.grpBx_WashingMachine.Controls.Add(this.rdBtn_WM_OFF);
            this.grpBx_WashingMachine.Controls.Add(this.rdBtn_WM_ON);
            this.grpBx_WashingMachine.Controls.Add(this.label1);
            this.grpBx_WashingMachine.Controls.Add(this.txtBx2);
            this.grpBx_WashingMachine.Controls.Add(this.txtxBx1);
            this.grpBx_WashingMachine.Controls.Add(this.lbl_SwitchOFF);
            this.grpBx_WashingMachine.Controls.Add(this.lbl_SwitchON);
            this.grpBx_WashingMachine.Location = new System.Drawing.Point(3, 162);
            this.grpBx_WashingMachine.Name = "grpBx_WashingMachine";
            this.grpBx_WashingMachine.Size = new System.Drawing.Size(552, 210);
            this.grpBx_WashingMachine.TabIndex = 15;
            this.grpBx_WashingMachine.TabStop = false;
            // 
            // rdBtn_WM_OFF
            // 
            this.rdBtn_WM_OFF.AccessibleDescription = "Washing Machine OFF switch";
            this.rdBtn_WM_OFF.AccessibleName = "Washing Machine Off";
            this.rdBtn_WM_OFF.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBtn_WM_OFF.AutoSize = true;
            this.rdBtn_WM_OFF.Checked = true;
            this.rdBtn_WM_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_WM_OFF.Location = new System.Drawing.Point(454, 11);
            this.rdBtn_WM_OFF.Name = "rdBtn_WM_OFF";
            this.rdBtn_WM_OFF.Size = new System.Drawing.Size(92, 47);
            this.rdBtn_WM_OFF.TabIndex = 14;
            this.rdBtn_WM_OFF.TabStop = true;
            this.rdBtn_WM_OFF.Text = "OFF";
            this.rdBtn_WM_OFF.UseVisualStyleBackColor = true;
            // 
            // rdBtn_WM_ON
            // 
            this.rdBtn_WM_ON.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBtn_WM_ON.AutoSize = true;
            this.rdBtn_WM_ON.Checked = true;
            this.rdBtn_WM_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtn_WM_ON.Location = new System.Drawing.Point(335, 11);
            this.rdBtn_WM_ON.Name = "rdBtn_WM_ON";
            this.rdBtn_WM_ON.Size = new System.Drawing.Size(76, 47);
            this.rdBtn_WM_ON.TabIndex = 3;
            this.rdBtn_WM_ON.TabStop = true;
            this.rdBtn_WM_ON.Text = "ON";
            this.rdBtn_WM_ON.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Washing Machine";
            // 
            // txtBx2
            // 
            this.txtBx2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBx2.Location = new System.Drawing.Point(399, 154);
            this.txtBx2.Mask = "00:00";
            this.txtBx2.Name = "txtBx2";
            this.txtBx2.Size = new System.Drawing.Size(88, 44);
            this.txtBx2.TabIndex = 11;
            this.txtBx2.ValidatingType = typeof(System.DateTime);
            // 
            // txtxBx1
            // 
            this.txtxBx1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtxBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxBx1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtxBx1.Location = new System.Drawing.Point(399, 92);
            this.txtxBx1.Mask = "00:00";
            this.txtxBx1.Name = "txtxBx1";
            this.txtxBx1.Size = new System.Drawing.Size(87, 44);
            this.txtxBx1.TabIndex = 10;
            this.txtxBx1.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_SwitchOFF
            // 
            this.lbl_SwitchOFF.AutoSize = true;
            this.lbl_SwitchOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SwitchOFF.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_SwitchOFF.Location = new System.Drawing.Point(6, 157);
            this.lbl_SwitchOFF.Name = "lbl_SwitchOFF";
            this.lbl_SwitchOFF.Size = new System.Drawing.Size(254, 37);
            this.lbl_SwitchOFF.TabIndex = 4;
            this.lbl_SwitchOFF.Text = "Switch OFF time";
            // 
            // lbl_SwitchON
            // 
            this.lbl_SwitchON.AutoSize = true;
            this.lbl_SwitchON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SwitchON.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_SwitchON.Location = new System.Drawing.Point(6, 95);
            this.lbl_SwitchON.Name = "lbl_SwitchON";
            this.lbl_SwitchON.Size = new System.Drawing.Size(238, 37);
            this.lbl_SwitchON.TabIndex = 3;
            this.lbl_SwitchON.Text = "Switch ON time";
            // 
            // lbl_UsagePerc
            // 
            this.lbl_UsagePerc.AutoSize = true;
            this.lbl_UsagePerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsagePerc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_UsagePerc.Location = new System.Drawing.Point(1054, 17);
            this.lbl_UsagePerc.Name = "lbl_UsagePerc";
            this.lbl_UsagePerc.Size = new System.Drawing.Size(51, 20);
            this.lbl_UsagePerc.TabIndex = 12;
            this.lbl_UsagePerc.Text = "label1";
            // 
            // lbl_PageName
            // 
            this.lbl_PageName.AutoSize = true;
            this.lbl_PageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PageName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_PageName.Location = new System.Drawing.Point(481, 427);
            this.lbl_PageName.Name = "lbl_PageName";
            this.lbl_PageName.Size = new System.Drawing.Size(100, 37);
            this.lbl_PageName.TabIndex = 6;
            this.lbl_PageName.Text = "label1";
            // 
            // prgbr
            // 
            this.prgbr.Location = new System.Drawing.Point(411, 4);
            this.prgbr.Name = "prgbr";
            this.prgbr.Size = new System.Drawing.Size(620, 37);
            this.prgbr.TabIndex = 5;
            this.prgbr.Value = 80;
            // 
            // lbl_CurrentUsage
            // 
            this.lbl_CurrentUsage.AutoSize = true;
            this.lbl_CurrentUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentUsage.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_CurrentUsage.Location = new System.Drawing.Point(18, 4);
            this.lbl_CurrentUsage.Name = "lbl_CurrentUsage";
            this.lbl_CurrentUsage.Size = new System.Drawing.Size(225, 37);
            this.lbl_CurrentUsage.TabIndex = 1;
            this.lbl_CurrentUsage.Text = "Current Usage";
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
            this.btn_Exit.TabIndex = 21;
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
            this.btn_Home.TabIndex = 22;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // Electricity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1133, 548);
            this.ControlBox = false;
            this.Controls.Add(this.splCtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Electricity";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electricity";
            this.Load += new System.EventHandler(this.Electricity_Load);
            this.splCtn.Panel1.ResumeLayout(false);
            this.splCtn.Panel1.PerformLayout();
            this.splCtn.Panel2.ResumeLayout(false);
            this.splCtn.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splCtn)).EndInit();
            this.splCtn.ResumeLayout(false);
            this.grpBx_Lights.ResumeLayout(false);
            this.grpBx_Lights.PerformLayout();
            this.grpBx_WashingMachine.ResumeLayout(false);
            this.grpBx_WashingMachine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splCtn;
        private System.Windows.Forms.RadioButton rdbtn_StatusOFF;
        private System.Windows.Forms.RadioButton rdbtn_StatusON;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ProgressBar prgbr;
        private System.Windows.Forms.Label lbl_SwitchOFF;
        private System.Windows.Forms.Label lbl_SwitchON;
        private System.Windows.Forms.Label lbl_CurrentUsage;
        private System.Windows.Forms.Label lbl_PageName;
        private System.Windows.Forms.MaskedTextBox txtBx2;
        private System.Windows.Forms.MaskedTextBox txtxBx1;
        private System.Windows.Forms.Label lbl_UsagePerc;
        private System.Windows.Forms.GroupBox grpBx_Lights;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBx_WashingMachine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtn_L_OFF;
        private System.Windows.Forms.RadioButton rdBtn_L_ON;
        private System.Windows.Forms.RadioButton rdBtn_WM_OFF;
        private System.Windows.Forms.RadioButton rdBtn_WM_ON;
        private System.Windows.Forms.MaskedTextBox mskdTxtBx_Electricity_OFF_time;
        private System.Windows.Forms.MaskedTextBox mskdTxtBx_Electricity_ON_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Home;
    }
}