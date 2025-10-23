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
    public partial class frmChangePassword : Form
    {

        private int _UserID = -1;
        ClsUser _User;
       
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }





        private void frmChangePassword_Load(object sender, EventArgs e)
        {
             _User = ClsUser.FindUserByUserID(_UserID);
              ctrUserInfo1.LoadUserInfo(_User.UserID);



        }

        private void txCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
           

            if(txCurrentPassword.Text != _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txCurrentPassword, "Not Macth With Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txCurrentPassword, "");
            }
        }

        private void txPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txPassword, null);
            };
        }

        private void txConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txConfirmPassword.Text.Trim() != txPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txConfirmPassword, null);
            };
        }

      

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //Update Password
            _User.Password = txPassword.Text.Trim();

            if(_User.Save())
            {
                MessageBox.Show("Password Changed Successfuly", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Occurd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
