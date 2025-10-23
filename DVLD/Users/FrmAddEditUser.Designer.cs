namespace DVLD
{
    partial class FrmAddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditUser));
            this.tbUserInfo = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrPersonInfoWithFilter1 = new DVLD.People.Controles.ctrPersonInfoWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbLoginInfo = new System.Windows.Forms.TabPage();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.txConfirmPassword = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txUserName = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitelForm = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbUserInfo.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserInfo
            // 
            this.tbUserInfo.Controls.Add(this.tbPersonInfo);
            this.tbUserInfo.Controls.Add(this.tbLoginInfo);
            this.tbUserInfo.Location = new System.Drawing.Point(12, 73);
            this.tbUserInfo.Name = "tbUserInfo";
            this.tbUserInfo.SelectedIndex = 0;
            this.tbUserInfo.Size = new System.Drawing.Size(791, 408);
            this.tbUserInfo.TabIndex = 0;
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
            // tbLoginInfo
            // 
            this.tbLoginInfo.Controls.Add(this.chIsActive);
            this.tbLoginInfo.Controls.Add(this.lbUserID);
            this.tbLoginInfo.Controls.Add(this.txConfirmPassword);
            this.tbLoginInfo.Controls.Add(this.txPassword);
            this.tbLoginInfo.Controls.Add(this.txUserName);
            this.tbLoginInfo.Controls.Add(this.pictureBox4);
            this.tbLoginInfo.Controls.Add(this.pictureBox2);
            this.tbLoginInfo.Controls.Add(this.pictureBox1);
            this.tbLoginInfo.Controls.Add(this.pictureBox3);
            this.tbLoginInfo.Controls.Add(this.label5);
            this.tbLoginInfo.Controls.Add(this.label4);
            this.tbLoginInfo.Controls.Add(this.label3);
            this.tbLoginInfo.Controls.Add(this.label2);
            this.tbLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tbLoginInfo.Name = "tbLoginInfo";
            this.tbLoginInfo.Size = new System.Drawing.Size(783, 382);
            this.tbLoginInfo.TabIndex = 1;
            this.tbLoginInfo.Text = "Login Info";
            this.tbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Checked = true;
            this.chIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chIsActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chIsActive.Location = new System.Drawing.Point(225, 210);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(99, 23);
            this.chIsActive.TabIndex = 22;
            this.chIsActive.Text = "Is Active";
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(251, 63);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(42, 19);
            this.lbUserID.TabIndex = 21;
            this.lbUserID.Text = "N\\A";
            // 
            // txConfirmPassword
            // 
            this.txConfirmPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConfirmPassword.Location = new System.Drawing.Point(255, 155);
            this.txConfirmPassword.Name = "txConfirmPassword";
            this.txConfirmPassword.Size = new System.Drawing.Size(141, 21);
            this.txConfirmPassword.TabIndex = 20;
            this.txConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txConfirmPassword_Validating);
            // 
            // txPassword
            // 
            this.txPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPassword.Location = new System.Drawing.Point(255, 124);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(141, 21);
            this.txPassword.TabIndex = 19;
            this.txPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txPassword_Validating);
            // 
            // txUserName
            // 
            this.txUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUserName.Location = new System.Drawing.Point(255, 91);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(141, 21);
            this.txUserName.TabIndex = 18;
            this.txUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txUserName_Validating);
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
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Password_321;
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
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID:";
            // 
            // lbTitelForm
            // 
            this.lbTitelForm.AutoSize = true;
            this.lbTitelForm.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitelForm.ForeColor = System.Drawing.Color.Maroon;
            this.lbTitelForm.Location = new System.Drawing.Point(310, 28);
            this.lbTitelForm.Name = "lbTitelForm";
            this.lbTitelForm.Size = new System.Drawing.Size(159, 25);
            this.lbTitelForm.TabIndex = 13;
            this.lbTitelForm.Text = "Add New User";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(682, 487);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 38);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(562, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 38);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 529);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitelForm);
            this.Controls.Add(this.tbUserInfo);
            this.Name = "FrmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddEditUser";
            this.Load += new System.EventHandler(this.FrmAddEditUser_Load);
            this.tbUserInfo.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbLoginInfo.ResumeLayout(false);
            this.tbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbUserInfo;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private System.Windows.Forms.Label lbTitelForm;
        private System.Windows.Forms.Button btnNext;
        private People.Controles.ctrPersonInfoWithFilter ctrPersonInfoWithFilter1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txConfirmPassword;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.CheckBox chIsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}