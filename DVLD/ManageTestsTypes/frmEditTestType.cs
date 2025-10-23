using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;

namespace DVLD
{
    public partial class frmEditTestType : Form
    {

        private clsTestTypes _TestType;
        private int _TestTypeID = 0;
        public frmEditTestType(int TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _TestType = clsTestTypes.Find(_TestTypeID);


            if (_TestType != null)
            {
                lbID.Text = _TestType.ID.ToString();
                txtTitle.Text = _TestType.Title;
                txtDescription.Text = _TestType.Description;
                txtFees.Text = _TestType.Fees.ToString();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _TestType.Title = txtTitle.Text;
            _TestType.Description = txtDescription.Text;
            _TestType.Fees = Convert.ToSingle(txtFees.Text);


            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfuly ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "This Filed Requred !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTitle, "");
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "This Filed Requred !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, "");
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This Filed Requred !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFees, "");
            }
        }
    }
}
