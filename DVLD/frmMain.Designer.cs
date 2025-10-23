namespace DVLD
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForLostOrDamagedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsTypsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestsTaypsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicToolStripMenuItem
            // 
            this.applicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationsTypsToolStripMenuItem,
            this.manageTestsTaypsToolStripMenuItem});
            this.applicToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicToolStripMenuItem.Image = global::DVLD.Properties.Resources.Applications_64;
            this.applicToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.applicToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicToolStripMenuItem.Name = "applicToolStripMenuItem";
            this.applicToolStripMenuItem.Size = new System.Drawing.Size(171, 68);
            this.applicToolStripMenuItem.Text = "Applications";
            // 
            // drivingToolStripMenuItem
            // 
            this.drivingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replacementForLostOrDamagedToolStripMenuItem,
            this.releaceToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.drivingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivingToolStripMenuItem.Name = "drivingToolStripMenuItem";
            this.drivingToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.drivingToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internToolStripMenuItem
            // 
            this.internToolStripMenuItem.Name = "internToolStripMenuItem";
            this.internToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.internToolStripMenuItem.Text = "International License";
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // replacementForLostOrDamagedToolStripMenuItem
            // 
            this.replacementForLostOrDamagedToolStripMenuItem.Name = "replacementForLostOrDamagedToolStripMenuItem";
            this.replacementForLostOrDamagedToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.replacementForLostOrDamagedToolStripMenuItem.Text = "Replacement For Lost or Damaged";
            // 
            // releaceToolStripMenuItem
            // 
            this.releaceToolStripMenuItem.Name = "releaceToolStripMenuItem";
            this.releaceToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.releaceToolStripMenuItem.Text = "Releace Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Manage_Applications_641;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            this.manageApplicationsToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_64;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // releaseToolStripMenuItem
            // 
            this.releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            this.releaseToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.releaseToolStripMenuItem.Text = "Release Detained License";
            // 
            // manageApplicationsTypsToolStripMenuItem
            // 
            this.manageApplicationsTypsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Application_Types_5121;
            this.manageApplicationsTypsToolStripMenuItem.Name = "manageApplicationsTypsToolStripMenuItem";
            this.manageApplicationsTypsToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.manageApplicationsTypsToolStripMenuItem.Text = "Manage Applications Types";
            this.manageApplicationsTypsToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsTypsToolStripMenuItem_Click);
            // 
            // manageTestsTaypsToolStripMenuItem
            // 
            this.manageTestsTaypsToolStripMenuItem.Image = global::DVLD.Properties.Resources.TestType_512;
            this.manageTestsTaypsToolStripMenuItem.Name = "manageTestsTaypsToolStripMenuItem";
            this.manageTestsTaypsToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
            this.manageTestsTaypsToolStripMenuItem.Text = "Manage Tests Types";
            this.manageTestsTaypsToolStripMenuItem.Click += new System.EventHandler(this.manageTestsTaypsToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleToolStripMenuItem.Image = global::DVLD.Properties.Resources.People_64;
            this.peopleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(132, 68);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversToolStripMenuItem.Image = global::DVLD.Properties.Resources.Drivers_64;
            this.driversToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(136, 68);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = global::DVLD.Properties.Resources.Users_2_64;
            this.usersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(125, 68);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSitToolStripMenuItem
            // 
            this.accountSitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signToolStripMenuItem});
            this.accountSitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSitToolStripMenuItem.Image = global::DVLD.Properties.Resources.account_settings_64;
            this.accountSitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.accountSitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSitToolStripMenuItem.Name = "accountSitToolStripMenuItem";
            this.accountSitToolStripMenuItem.Size = new System.Drawing.Size(197, 68);
            this.accountSitToolStripMenuItem.Text = "Account Setings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_321;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.currentUserInfoToolStripMenuItem.Text = "Current User info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DVLD.Properties.Resources.Password_322;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signToolStripMenuItem
            // 
            this.signToolStripMenuItem.Image = global::DVLD.Properties.Resources.sign_out_32__2;
            this.signToolStripMenuItem.Name = "signToolStripMenuItem";
            this.signToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.signToolStripMenuItem.Text = "Sign Out";
            this.signToolStripMenuItem.Click += new System.EventHandler(this.signToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsTypsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestsTaypsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signToolStripMenuItem;
    }
}

