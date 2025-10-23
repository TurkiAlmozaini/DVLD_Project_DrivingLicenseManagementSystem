namespace DVLD
{
    partial class frmManageLocalDrivingLicensens
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.textFilterValue = new System.Windows.Forms.TextBox();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgAllLocalDrivingLicenseApplications = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowApplicationDeatils_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditApplication_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApplication_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelApplication_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SechduleTests_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueDrivingLicenseForFirstTime_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicense_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistory_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewLocalDrivingLicenseApplication = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllLocalDrivingLicenseApplications)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRecordsCount.Location = new System.Drawing.Point(100, 414);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(19, 19);
            this.lbRecordsCount.TabIndex = 20;
            this.lbRecordsCount.Text = "0";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lable2.Location = new System.Drawing.Point(1, 414);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(103, 19);
            this.lable2.TabIndex = 19;
            this.lable2.Text = "#  Records:";
            // 
            // textFilterValue
            // 
            this.textFilterValue.Location = new System.Drawing.Point(233, 184);
            this.textFilterValue.Name = "textFilterValue";
            this.textFilterValue.Size = new System.Drawing.Size(167, 20);
            this.textFilterValue.TabIndex = 18;
            this.textFilterValue.Visible = false;
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.FormattingEnabled = true;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Gendor",
            "Date Of Birth",
            "Nationality",
            "Phone ",
            "Email"});
            this.CbFilterBy.Location = new System.Drawing.Point(90, 183);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(137, 21);
            this.CbFilterBy.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filter By:";
            // 
            // dvgAllLocalDrivingLicenseApplications
            // 
            this.dvgAllLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            this.dvgAllLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            this.dvgAllLocalDrivingLicenseApplications.AllowUserToResizeColumns = false;
            this.dvgAllLocalDrivingLicenseApplications.AllowUserToResizeRows = false;
            this.dvgAllLocalDrivingLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgAllLocalDrivingLicenseApplications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgAllLocalDrivingLicenseApplications.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgAllLocalDrivingLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgAllLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgAllLocalDrivingLicenseApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dvgAllLocalDrivingLicenseApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dvgAllLocalDrivingLicenseApplications.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dvgAllLocalDrivingLicenseApplications.Location = new System.Drawing.Point(5, 208);
            this.dvgAllLocalDrivingLicenseApplications.Name = "dvgAllLocalDrivingLicenseApplications";
            this.dvgAllLocalDrivingLicenseApplications.ReadOnly = true;
            this.dvgAllLocalDrivingLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAllLocalDrivingLicenseApplications.Size = new System.Drawing.Size(1253, 200);
            this.dvgAllLocalDrivingLicenseApplications.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowApplicationDeatils_toolStripMenuItem,
            this.EditApplication_toolStripMenuItem,
            this.DeleteApplication_toolStripMenuItem,
            this.CancelApplication_toolStripMenuItem,
            this.SechduleTests_toolStripMenuItem,
            this.IssueDrivingLicenseForFirstTime_toolStripMenuItem,
            this.ShowLicense_toolStripMenuItem,
            this.ShowPersonLicenseHistory_toolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 180);
            // 
            // ShowApplicationDeatils_toolStripMenuItem
            // 
            this.ShowApplicationDeatils_toolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_323;
            this.ShowApplicationDeatils_toolStripMenuItem.Name = "ShowApplicationDeatils_toolStripMenuItem";
            this.ShowApplicationDeatils_toolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.ShowApplicationDeatils_toolStripMenuItem.Text = "Show Application Deatils";
            this.ShowApplicationDeatils_toolStripMenuItem.Click += new System.EventHandler(this.ShowApplicationDeatils_toolStripMenuItem_Click);
            // 
            // EditApplication_toolStripMenuItem
            // 
            this.EditApplication_toolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_323;
            this.EditApplication_toolStripMenuItem.Name = "EditApplication_toolStripMenuItem";
            this.EditApplication_toolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.EditApplication_toolStripMenuItem.Text = "Edit Application";
            this.EditApplication_toolStripMenuItem.Click += new System.EventHandler(this.EditApplication_toolStripMenuItem_Click);
            // 
            // DeleteApplication_toolStripMenuItem
            // 
            this.DeleteApplication_toolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32_2;
            this.DeleteApplication_toolStripMenuItem.Name = "DeleteApplication_toolStripMenuItem";
            this.DeleteApplication_toolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.DeleteApplication_toolStripMenuItem.Text = "Delete Application";
            this.DeleteApplication_toolStripMenuItem.Click += new System.EventHandler(this.DeleteApplication_toolStripMenuItem_Click);
            // 
            // CancelApplication_toolStripMenuItem
            // 
            this.CancelApplication_toolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_321;
            this.CancelApplication_toolStripMenuItem.Name = "CancelApplication_toolStripMenuItem";
            this.CancelApplication_toolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.CancelApplication_toolStripMenuItem.Text = "Cancel Application";
            this.CancelApplication_toolStripMenuItem.Click += new System.EventHandler(this.CancelApplication_toolStripMenuItem_Click);
            // 
            // SechduleTests_toolStripMenuItem
            // 
            this.SechduleTests_toolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_32;
            this.SechduleTests_toolStripMenuItem.Name = "SechduleTests_toolStripMenuItem";
            this.SechduleTests_toolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.SechduleTests_toolStripMenuItem.Text = "Sechdule Tests";
            this.SechduleTests_toolStripMenuItem.Click += new System.EventHandler(this.SechduleTests_toolStripMenuItem_Click);
            // 
            // IssueDrivingLicenseForFirstTime_toolStripMenuItem
            // 
            this.IssueDrivingLicenseForFirstTime_toolStripMenuItem.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.IssueDrivingLicenseForFirstTime_toolStripMenuItem.Name = "IssueDrivingLicenseForFirstTime_toolStripMenuItem";
            this.IssueDrivingLicenseForFirstTime_toolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.IssueDrivingLicenseForFirstTime_toolStripMenuItem.Text = "Issue Driving License (Fiest Time)";
            this.IssueDrivingLicenseForFirstTime_toolStripMenuItem.Click += new System.EventHandler(this.IssueDrivingLicenseForFirstTime_toolStripMenuItem_Click);
            // 
            // ShowLicense_toolStripMenuItem
            // 
            this.ShowLicense_toolStripMenuItem.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.ShowLicense_toolStripMenuItem.Name = "ShowLicense_toolStripMenuItem";
            this.ShowLicense_toolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.ShowLicense_toolStripMenuItem.Text = "Show License";
            this.ShowLicense_toolStripMenuItem.Click += new System.EventHandler(this.ShowLicense_toolStripMenuItem_Click);
            // 
            // ShowPersonLicenseHistory_toolStripMenuItem
            // 
            this.ShowPersonLicenseHistory_toolStripMenuItem.Image = global::DVLD.Properties.Resources.LicenseView_400;
            this.ShowPersonLicenseHistory_toolStripMenuItem.Name = "ShowPersonLicenseHistory_toolStripMenuItem";
            this.ShowPersonLicenseHistory_toolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.ShowPersonLicenseHistory_toolStripMenuItem.Text = "Show Person License History";
            this.ShowPersonLicenseHistory_toolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHistory_toolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(431, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Local Driving License Applications";
            // 
            // btnAddNewLocalDrivingLicenseApplication
            // 
            this.btnAddNewLocalDrivingLicenseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLocalDrivingLicenseApplication.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.btnAddNewLocalDrivingLicenseApplication.Location = new System.Drawing.Point(1180, 143);
            this.btnAddNewLocalDrivingLicenseApplication.Name = "btnAddNewLocalDrivingLicenseApplication";
            this.btnAddNewLocalDrivingLicenseApplication.Size = new System.Drawing.Size(78, 59);
            this.btnAddNewLocalDrivingLicenseApplication.TabIndex = 15;
            this.btnAddNewLocalDrivingLicenseApplication.UseVisualStyleBackColor = true;
            this.btnAddNewLocalDrivingLicenseApplication.Click += new System.EventHandler(this.btnAddNewLocalDrivingLicenseApplication_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1153, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 32);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Manage_Applications_64;
            this.pictureBox1.Location = new System.Drawing.Point(529, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageLocalDrivingLicensens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 450);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.textFilterValue);
            this.Controls.Add(this.CbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewLocalDrivingLicenseApplication);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dvgAllLocalDrivingLicenseApplications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageLocalDrivingLicensens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageLocalDrivingLicense";
            this.Load += new System.EventHandler(this.ManageLocalDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllLocalDrivingLicenseApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox textFilterValue;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewLocalDrivingLicenseApplication;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dvgAllLocalDrivingLicenseApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowApplicationDeatils_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditApplication_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteApplication_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelApplication_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SechduleTests_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueDrivingLicenseForFirstTime_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicense_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistory_toolStripMenuItem;
    }
}