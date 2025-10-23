namespace DVLD
{
    partial class frmManageUsers
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
            this.textFilterValue = new System.Windows.Forms.TextBox();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgAllUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showdeatilstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.cbIsFilterIsActive = new System.Windows.Forms.ComboBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textFilterValue
            // 
            this.textFilterValue.Location = new System.Drawing.Point(246, 197);
            this.textFilterValue.Name = "textFilterValue";
            this.textFilterValue.Size = new System.Drawing.Size(167, 20);
            this.textFilterValue.TabIndex = 17;
            this.textFilterValue.Visible = false;
            this.textFilterValue.TextChanged += new System.EventHandler(this.textFilterValue_TextChanged);
            this.textFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFilterValue_KeyPress);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.FormattingEnabled = true;
            this.CbFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Person ID",
            "Full Name",
            "User Name",
            "Is Acitve"});
            this.CbFilterBy.Location = new System.Drawing.Point(103, 196);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(137, 21);
            this.CbFilterBy.TabIndex = 16;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filter By:";
            // 
            // dvgAllUsers
            // 
            this.dvgAllUsers.AllowUserToAddRows = false;
            this.dvgAllUsers.AllowUserToDeleteRows = false;
            this.dvgAllUsers.BackgroundColor = System.Drawing.Color.White;
            this.dvgAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAllUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dvgAllUsers.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dvgAllUsers.Location = new System.Drawing.Point(12, 223);
            this.dvgAllUsers.Name = "dvgAllUsers";
            this.dvgAllUsers.ReadOnly = true;
            this.dvgAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAllUsers.Size = new System.Drawing.Size(776, 219);
            this.dvgAllUsers.TabIndex = 14;
           
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showdeatilstoolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 186);
            // 
            // showdeatilstoolStripMenuItem
            // 
            this.showdeatilstoolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showdeatilstoolStripMenuItem.Name = "showdeatilstoolStripMenuItem";
            this.showdeatilstoolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.showdeatilstoolStripMenuItem.Text = "Show Details";
            this.showdeatilstoolStripMenuItem.Click += new System.EventHandler(this.showdeatilstoolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = global::DVLD.Properties.Resources.Add_New_User_32;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DVLD.Properties.Resources.Password_32;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.Phone_32;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(295, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Manage Users";
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRecordsCount.Location = new System.Drawing.Point(113, 463);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(19, 19);
            this.lbRecordsCount.TabIndex = 19;
            this.lbRecordsCount.Text = "0";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lable3.Location = new System.Drawing.Point(14, 463);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(103, 19);
            this.lable3.TabIndex = 18;
            this.lable3.Text = "#  Records:";
            // 
            // cbIsFilterIsActive
            // 
            this.cbIsFilterIsActive.FormattingEnabled = true;
            this.cbIsFilterIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsFilterIsActive.Location = new System.Drawing.Point(246, 197);
            this.cbIsFilterIsActive.Name = "cbIsFilterIsActive";
            this.cbIsFilterIsActive.Size = new System.Drawing.Size(84, 21);
            this.cbIsFilterIsActive.TabIndex = 22;
            this.cbIsFilterIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsFilterIsActive_SelectedIndexChanged);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Image = global::DVLD.Properties.Resources.Add_New_User_72;
            this.btnAddPerson.Location = new System.Drawing.Point(704, 145);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(84, 72);
            this.btnAddPerson.TabIndex = 21;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(683, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 32);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(311, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.cbIsFilterIsActive);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.textFilterValue);
            this.Controls.Add(this.CbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgAllUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(199, 140);
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFilterValue;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgAllUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ComboBox cbIsFilterIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showdeatilstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}