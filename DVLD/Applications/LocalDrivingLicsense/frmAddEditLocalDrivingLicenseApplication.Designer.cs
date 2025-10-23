namespace DVLD
{
    partial class frmAddEditLocalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditLocalDrivingLicenseApplication));
            this.lbTitelForm = new System.Windows.Forms.Label();
            this.tbApplicationInfo = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrPersonInfoWithFilter1 = new DVLD.People.Controles.ctrPersonInfoWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbLoginApplication = new System.Windows.Forms.TabPage();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.lbCreated = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbApplicationInfo.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbLoginApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitelForm
            // 
            this.lbTitelForm.AutoSize = true;
            this.lbTitelForm.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitelForm.ForeColor = System.Drawing.Color.Maroon;
            this.lbTitelForm.Location = new System.Drawing.Point(159, 20);
            this.lbTitelForm.Name = "lbTitelForm";
            this.lbTitelForm.Size = new System.Drawing.Size(453, 25);
            this.lbTitelForm.TabIndex = 48;
            this.lbTitelForm.Text = "Add New Local Driving License Application";
            // 
            // tbApplicationInfo
            // 
            this.tbApplicationInfo.Controls.Add(this.tbPersonInfo);
            this.tbApplicationInfo.Controls.Add(this.tbLoginApplication);
            this.tbApplicationInfo.Location = new System.Drawing.Point(12, 62);
            this.tbApplicationInfo.Name = "tbApplicationInfo";
            this.tbApplicationInfo.SelectedIndex = 0;
            this.tbApplicationInfo.Size = new System.Drawing.Size(791, 408);
            this.tbApplicationInfo.TabIndex = 47;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.ctrPersonInfoWithFilter1);
            this.tbPersonInfo.Controls.Add(this.btnNext);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Size = new System.Drawing.Size(783, 382);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrPersonInfoWithFilter1
            // 
            this.ctrPersonInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrPersonInfoWithFilter1.FilterEnabled = true;
            this.ctrPersonInfoWithFilter1.Location = new System.Drawing.Point(3, 17);
            this.ctrPersonInfoWithFilter1.Name = "ctrPersonInfoWithFilter1";
            this.ctrPersonInfoWithFilter1.ShowAddPerson = true;
            this.ctrPersonInfoWithFilter1.Size = new System.Drawing.Size(777, 324);
            this.ctrPersonInfoWithFilter1.TabIndex = 22;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(661, 347);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 32);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbLoginApplication
            // 
            this.tbLoginApplication.Controls.Add(this.cbLicenseClasses);
            this.tbLoginApplication.Controls.Add(this.lbCreated);
            this.tbLoginApplication.Controls.Add(this.lbFees);
            this.tbLoginApplication.Controls.Add(this.lbDate);
            this.tbLoginApplication.Controls.Add(this.pictureBox5);
            this.tbLoginApplication.Controls.Add(this.label1);
            this.tbLoginApplication.Controls.Add(this.lbLID);
            this.tbLoginApplication.Controls.Add(this.pictureBox4);
            this.tbLoginApplication.Controls.Add(this.pictureBox2);
            this.tbLoginApplication.Controls.Add(this.pictureBox1);
            this.tbLoginApplication.Controls.Add(this.pictureBox3);
            this.tbLoginApplication.Controls.Add(this.label5);
            this.tbLoginApplication.Controls.Add(this.label4);
            this.tbLoginApplication.Controls.Add(this.label3);
            this.tbLoginApplication.Controls.Add(this.label2);
            this.tbLoginApplication.Location = new System.Drawing.Point(4, 22);
            this.tbLoginApplication.Name = "tbLoginApplication";
            this.tbLoginApplication.Size = new System.Drawing.Size(783, 382);
            this.tbLoginApplication.TabIndex = 1;
            this.tbLoginApplication.Text = "Application Info";
            this.tbLoginApplication.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(255, 120);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(271, 21);
            this.cbLicenseClasses.TabIndex = 27;
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreated.Location = new System.Drawing.Point(251, 188);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(42, 19);
            this.lbCreated.TabIndex = 26;
            this.lbCreated.Text = "N\\A";
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFees.Location = new System.Drawing.Point(251, 153);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(42, 19);
            this.lbFees.TabIndex = 25;
            this.lbFees.Text = "N\\A";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(251, 91);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(42, 19);
            this.lbDate.TabIndex = 24;
            this.lbDate.Text = "N\\A";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(216, 188);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 19);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Created by  :";
            // 
            // lbLID
            // 
            this.lbLID.AutoSize = true;
            this.lbLID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLID.Location = new System.Drawing.Point(251, 63);
            this.lbLID.Name = "lbLID";
            this.lbLID.Size = new System.Drawing.Size(42, 19);
            this.lbLID.TabIndex = 21;
            this.lbLID.Text = "N\\A";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(216, 153);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Properties.Resources.License_Type_32;
            this.pictureBox2.Location = new System.Drawing.Point(216, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(216, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Application Fees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "License Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Application Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "D.L Application ID :";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(565, 476);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 38);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(685, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 38);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 526);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitelForm);
            this.Controls.Add(this.tbApplicationInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmAddEditLocalDrivingLicenseApplication_Load);
            this.tbApplicationInfo.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbLoginApplication.ResumeLayout(false);
            this.tbLoginApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTitelForm;
        private System.Windows.Forms.TabControl tbApplicationInfo;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private People.Controles.ctrPersonInfoWithFilter ctrPersonInfoWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tbLoginApplication;
        private System.Windows.Forms.Label lbLID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
    }
}