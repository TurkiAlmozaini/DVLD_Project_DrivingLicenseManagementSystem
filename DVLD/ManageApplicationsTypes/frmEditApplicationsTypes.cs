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
    public partial class frmEditApplicationsTypes : Form
    {


        private clsApplicationsTypes _applicationsTypscs;
        private int _ApplicationTypeID = -1;
        public frmEditApplicationsTypes(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _applicationsTypscs.Title = txtApplicationTypeTitle.Text;
            _applicationsTypscs.Fees = Convert.ToSingle(txtApplicationFees.Text);



            if(_applicationsTypscs.Save())
            {
                MessageBox.Show("Data Saved Successfuly ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmUpdateApplicationFees_Load(object sender, EventArgs e)
        {
            _applicationsTypscs = clsApplicationsTypes.Find(_ApplicationTypeID);
            lbID.Text = _applicationsTypscs.ID.ToString();
            txtApplicationTypeTitle.Text = _applicationsTypscs.Title;
            txtApplicationFees.Text = _applicationsTypscs.Fees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtApplicationTypeTitle_Validating(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrEmpty(txtApplicationTypeTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtApplicationTypeTitle, "This Filed Requred !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtApplicationTypeTitle, "");
            }
        }

        private void txtApplicationFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtApplicationFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtApplicationFees, "This Filed Requred !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtApplicationFees, "");
            }
        }

        private void txtApplicationTypeTitle_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(txtApplicationTypeTitle, "Cannot Enter Numbers Only Letters");
            }
            else
            {
                errorProvider1.SetError(txtApplicationTypeTitle, "");
            }


    }

        private void txtApplicationFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(txtApplicationFees, "Cannot Enter Letters Only Numbers");
            }
            else
            {
                errorProvider1.SetError(txtApplicationFees, "");
            }

        }
    }
}
