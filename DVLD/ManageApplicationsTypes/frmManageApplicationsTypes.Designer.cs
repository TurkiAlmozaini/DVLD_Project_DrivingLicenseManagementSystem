namespace DVLD
{
    partial class frmManageApplicationsTypes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dvgAllApplicationsTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editapplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllApplicationsTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(120, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Manage Applications Types";
            // 
            // dvgAllApplicationsTypes
            // 
            this.dvgAllApplicationsTypes.AllowUserToAddRows = false;
            this.dvgAllApplicationsTypes.AllowUserToDeleteRows = false;
            this.dvgAllApplicationsTypes.BackgroundColor = System.Drawing.Color.White;
            this.dvgAllApplicationsTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAllApplicationsTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dvgAllApplicationsTypes.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dvgAllApplicationsTypes.Location = new System.Drawing.Point(12, 174);
            this.dvgAllApplicationsTypes.Name = "dvgAllApplicationsTypes";
            this.dvgAllApplicationsTypes.ReadOnly = true;
            this.dvgAllApplicationsTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAllApplicationsTypes.Size = new System.Drawing.Size(512, 297);
            this.dvgAllApplicationsTypes.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editapplicationTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 26);
            // 
            // editapplicationTypeToolStripMenuItem
            // 
            this.editapplicationTypeToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_321;
            this.editapplicationTypeToolStripMenuItem.Name = "editapplicationTypeToolStripMenuItem";
            this.editapplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.editapplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            this.editapplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.editapplicationTypeToolStripMenuItem_Click);
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRecordsCount.Location = new System.Drawing.Point(111, 482);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(19, 19);
            this.lbRecordsCount.TabIndex = 21;
            this.lbRecordsCount.Text = "0";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lable3.Location = new System.Drawing.Point(12, 482);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(103, 19);
            this.lable3.TabIndex = 20;
            this.lable3.Text = "#  Records:";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(419, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 32);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(197, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageApplicationsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 521);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.dvgAllApplicationsTypes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageApplicationsTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageApplicationsType";
            this.Load += new System.EventHandler(this.frmManageApplicationsType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAllApplicationsTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgAllApplicationsTypes;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editapplicationTypeToolStripMenuItem;
    }
}