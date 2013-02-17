namespace Prototype.Dialogs
{
    partial class PIN
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
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nr1 = new System.Windows.Forms.ListBox();
            this.nr2 = new System.Windows.Forms.ListBox();
            this.nr3 = new System.Windows.Forms.ListBox();
            this.nr4 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Msg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Msg.Location = new System.Drawing.Point(5, 27);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(260, 37);
            this.lbl_Msg.TabIndex = 0;
            this.lbl_Msg.Text = "Please Enter PIN";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOK.Location = new System.Drawing.Point(12, 86);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(174, 74);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(392, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 74);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nr1
            // 
            this.nr1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr1.ForeColor = System.Drawing.SystemColors.Window;
            this.nr1.FormattingEnabled = true;
            this.nr1.ItemHeight = 37;
            this.nr1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.nr1.Location = new System.Drawing.Point(312, 27);
            this.nr1.Name = "nr1";
            this.nr1.Size = new System.Drawing.Size(46, 39);
            this.nr1.TabIndex = 11;
            // 
            // nr2
            // 
            this.nr2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr2.ForeColor = System.Drawing.SystemColors.Window;
            this.nr2.FormattingEnabled = true;
            this.nr2.ItemHeight = 37;
            this.nr2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.nr2.Location = new System.Drawing.Point(362, 27);
            this.nr2.Name = "nr2";
            this.nr2.Size = new System.Drawing.Size(46, 39);
            this.nr2.TabIndex = 12;
            // 
            // nr3
            // 
            this.nr3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nr3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr3.ForeColor = System.Drawing.SystemColors.Window;
            this.nr3.FormattingEnabled = true;
            this.nr3.ItemHeight = 37;
            this.nr3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.nr3.Location = new System.Drawing.Point(412, 27);
            this.nr3.Name = "nr3";
            this.nr3.Size = new System.Drawing.Size(46, 39);
            this.nr3.TabIndex = 13;
            // 
            // nr4
            // 
            this.nr4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nr4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr4.ForeColor = System.Drawing.SystemColors.Window;
            this.nr4.FormattingEnabled = true;
            this.nr4.ItemHeight = 37;
            this.nr4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.nr4.Location = new System.Drawing.Point(462, 27);
            this.nr4.Name = "nr4";
            this.nr4.Size = new System.Drawing.Size(46, 39);
            this.nr4.TabIndex = 14;
            // 
            // PIN
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(578, 172);
            this.ControlBox = false;
            this.Controls.Add(this.nr4);
            this.Controls.Add(this.nr3);
            this.Controls.Add(this.nr2);
            this.Controls.Add(this.nr1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbl_Msg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox nr1;
        private System.Windows.Forms.ListBox nr2;
        private System.Windows.Forms.ListBox nr3;
        private System.Windows.Forms.ListBox nr4;
    }
}