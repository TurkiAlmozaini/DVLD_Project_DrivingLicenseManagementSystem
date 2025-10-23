namespace DVLD
{
    partial class frmFindPerson
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
            this.lbModeForm = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrPersonInfoWithFilter1 = new DVLD.People.Controles.ctrPersonInfoWithFilter();
            this.SuspendLayout();
            // 
            // lbModeForm
            // 
            this.lbModeForm.AutoSize = true;
            this.lbModeForm.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModeForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbModeForm.Location = new System.Drawing.Point(315, 31);
            this.lbModeForm.Name = "lbModeForm";
            this.lbModeForm.Size = new System.Drawing.Size(134, 25);
            this.lbModeForm.TabIndex = 20;
            this.lbModeForm.Text = "Find Person";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(654, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 38);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrPersonInfoWithFilter1
            // 
            this.ctrPersonInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrPersonInfoWithFilter1.FilterEnabled = true;
            this.ctrPersonInfoWithFilter1.Location = new System.Drawing.Point(0, 72);
            this.ctrPersonInfoWithFilter1.Name = "ctrPersonInfoWithFilter1";
            this.ctrPersonInfoWithFilter1.ShowAddPerson = true;
            this.ctrPersonInfoWithFilter1.Size = new System.Drawing.Size(778, 325);
            this.ctrPersonInfoWithFilter1.TabIndex = 45;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 453);
            this.Controls.Add(this.ctrPersonInfoWithFilter1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbModeForm);
            this.Name = "frmFindPerson";
            this.Text = "frmFindPerson";
            this.Load += new System.EventHandler(this.frmFindPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbModeForm;
        private System.Windows.Forms.Button btnClose;
        private People.Controles.ctrPersonInfoWithFilter ctrPersonInfoWithFilter1;
    }
}