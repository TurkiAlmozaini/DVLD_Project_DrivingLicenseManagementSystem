namespace DVLD
{
    partial class frmManageTestsTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestsTypes));
            this.dvgTestsTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbRecordsCount = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTestsTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgTestsTypes
            // 
            this.dvgTestsTypes.AllowUserToAddRows = false;
            this.dvgTestsTypes.AllowUserToDeleteRows = false;
            this.dvgTestsTypes.BackgroundColor = System.Drawing.Color.White;
            this.dvgTestsTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTestsTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dvgTestsTypes.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dvgTestsTypes.Location = new System.Drawing.Point(3, 170);
            this.dvgTestsTypes.Name = "dvgTestsTypes";
            this.dvgTestsTypes.ReadOnly = true;
            this.dvgTestsTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgTestsTypes.Size = new System.Drawing.Size(1037, 255);
            this.dvgTestsTypes.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // editTestTypeToolStripMenuItem
            // 
            this.editTestTypeToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_322;
            this.editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            this.editTestTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            this.editTestTypeToolStripMenuItem.Click += new System.EventHandler(this.editTestTypeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(413, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Manage Tests Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(924, 431);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 32);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbRecordsCount
            // 
            this.lbRecordsCount.AutoSize = true;
            this.lbRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRecordsCount.Location = new System.Drawing.Point(111, 436);
            this.lbRecordsCount.Name = "lbRecordsCount";
            this.lbRecordsCount.Size = new System.Drawing.Size(19, 19);
            this.lbRecordsCount.TabIndex = 24;
            this.lbRecordsCount.Text = "0";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lable3.Location = new System.Drawing.Point(12, 436);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(103, 19);
            this.lable3.TabIndex = 23;
            this.lable3.Text = "#  Records:";
            // 
            // frmManageTestsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1041, 475);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecordsCount);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.dvgTestsTypes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageTestsTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditTestsTypes";
            this.Load += new System.EventHandler(this.frmManageTestsTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTestsTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTestsTypes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecordsCount;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editTestTypeToolStripMenuItem;
    }
}