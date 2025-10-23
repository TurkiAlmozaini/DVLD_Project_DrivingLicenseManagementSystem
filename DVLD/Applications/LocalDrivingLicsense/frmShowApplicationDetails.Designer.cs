namespace DVLD
{
    partial class frmShowApplicationDetails
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
            this.ctrLocalAppLicenseInfo1 = new DVLD.ctrLocalAppLicenseInfo();
            this.ctrApplicationBasicInfo1 = new DVLD.ctrApplicationBasicInfo();
            this.SuspendLayout();
            // 
            // ctrLocalAppLicenseInfo1
            // 
            this.ctrLocalAppLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrLocalAppLicenseInfo1.Location = new System.Drawing.Point(22, 12);
            this.ctrLocalAppLicenseInfo1.Name = "ctrLocalAppLicenseInfo1";
            this.ctrLocalAppLicenseInfo1.Size = new System.Drawing.Size(808, 113);
            this.ctrLocalAppLicenseInfo1.TabIndex = 0;
            // 
            // ctrApplicationBasicInfo1
            // 
            this.ctrApplicationBasicInfo1.BackColor = System.Drawing.Color.White;
            this.ctrApplicationBasicInfo1.Location = new System.Drawing.Point(12, 131);
            this.ctrApplicationBasicInfo1.Name = "ctrApplicationBasicInfo1";
            this.ctrApplicationBasicInfo1.Size = new System.Drawing.Size(849, 253);
            this.ctrApplicationBasicInfo1.TabIndex = 1;
            // 
            // frmShowApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 387);
            this.Controls.Add(this.ctrApplicationBasicInfo1);
            this.Controls.Add(this.ctrLocalAppLicenseInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowApplicationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Application Details";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrLocalAppLicenseInfo ctrLocalAppLicenseInfo1;
        private ctrApplicationBasicInfo ctrApplicationBasicInfo1;
    }
}