namespace DVLD
{
    partial class ctrUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.ctrPersonInfo1 = new DVLD.ctrPersonInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbIsActive);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbUserID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbIsActive.Location = new System.Drawing.Point(612, 34);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(48, 18);
            this.lbIsActive.TabIndex = 22;
            this.lbIsActive.Text = "[????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Is Active";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUserName.Location = new System.Drawing.Point(409, 33);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(48, 18);
            this.lbUserName.TabIndex = 20;
            this.lbUserName.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "User Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUserID.Location = new System.Drawing.Point(121, 32);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(48, 18);
            this.lbUserID.TabIndex = 18;
            this.lbUserID.Text = "[????]";
            // 
            // ctrPersonInfo1
            // 
            this.ctrPersonInfo1.BackColor = System.Drawing.Color.White;
            this.ctrPersonInfo1.Location = new System.Drawing.Point(28, 19);
            this.ctrPersonInfo1.Name = "ctrPersonInfo1";
            this.ctrPersonInfo1.Size = new System.Drawing.Size(777, 274);
            this.ctrPersonInfo1.TabIndex = 1;
          
            // 
            // ctrUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrPersonInfo1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrUserInfo";
            this.Size = new System.Drawing.Size(813, 385);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ctrPersonInfo ctrPersonInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUserID;
    }
}
