namespace DVLD.People.Controles
{
    partial class ctrPersonInfoWithFilter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrPersonInfoWithFilter));
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.txFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.ctrPersonInfo1 = new DVLD.ctrPersonInfo();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.Image")));
            this.btnAddPerson.Location = new System.Drawing.Point(545, 16);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(38, 36);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnFindPerson.Image")));
            this.btnFindPerson.Location = new System.Drawing.Point(501, 16);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(38, 36);
            this.btnFindPerson.TabIndex = 4;
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // txFilterValue
            // 
            this.txFilterValue.Location = new System.Drawing.Point(279, 25);
            this.txFilterValue.Name = "txFilterValue";
            this.txFilterValue.Size = new System.Drawing.Size(195, 20);
            this.txFilterValue.TabIndex = 3;
            this.txFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txFilterValue_KeyPress);
            this.txFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txFilterValue_Validating);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbFilterBy.Location = new System.Drawing.Point(91, 24);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(182, 21);
            this.cbFilterBy.TabIndex = 2;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find By:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.txFilterValue);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Controls.Add(this.btnFindPerson);
            this.gbFilter.Location = new System.Drawing.Point(97, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(589, 59);
            this.gbFilter.TabIndex = 6;
            this.gbFilter.TabStop = false;
            // 
            // ctrPersonInfo1
            // 
            this.ctrPersonInfo1.Location = new System.Drawing.Point(0, 54);
            this.ctrPersonInfo1.Name = "ctrPersonInfo1";
            this.ctrPersonInfo1.Size = new System.Drawing.Size(777, 274);
            this.ctrPersonInfo1.TabIndex = 0;
            // 
            // ctrPersonInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrPersonInfo1);
            this.Name = "ctrPersonInfoWithFilter";
            this.Size = new System.Drawing.Size(781, 342);
            this.Load += new System.EventHandler(this.ctrPersonInfoWithFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrPersonInfo ctrPersonInfo1;
        private System.Windows.Forms.TextBox txFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbFilter;
    }
}
