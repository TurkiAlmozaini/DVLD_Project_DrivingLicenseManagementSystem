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
    public partial class FrmAddEditUser : Form
    {

        ClsUser _User;
        private int _UserID = -1;
        private enum enMode { AddMode = 0, UpdateMode = 1 };
        enMode _Mode;
        public FrmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddMode;
            

        }

        public FrmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.UpdateMode;
           

        }

        private void FrmAddEditUser_Load(object sender, EventArgs e)
        { 
            _ResetDefualtValues();

            if (_Mode == enMode.UpdateMode)
                _LoadUserData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateMode)
            {
                btnSave.Enabled = true;
                tbLoginInfo.Enabled = true;
                tbUserInfo.SelectedTab = tbUserInfo.TabPages["tbLoginInfo"];
                return;
            }

            if (ctrPersonInfoWithFilter1.PersonID != -1)
            {

                if (ClsUser.IsUserExistForPersonID(ctrPersonInfoWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrPersonInfoWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tbLoginInfo.Enabled = true;
                    tbUserInfo.SelectedTab = tbUserInfo.TabPages["tbLoginInfo"];
                }
            }
            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrPersonInfoWithFilter1.FilterFocus();

            }







        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {

            

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.UserName = txUserName.Text.Trim();
            _User.Password = txPassword.Text.Trim();
            _User.IsActive = chIsActive.Checked;
            _User.PersonID = ctrPersonInfoWithFilter1.PersonID;


            if (_User.Save())
            {
                ctrPersonInfoWithFilter1.FilterEnabled = false;
                _Mode = enMode.UpdateMode;
                lbTitelForm.Text = "Update User";
                this.Text = "Update User";
                lbUserID.Text = _User.UserID.ToString();
                MessageBox.Show("Data Saved Successfuly " , "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddMode)
            {
                lbTitelForm.Text = "Add New User";
                this.Text = "Add New User";
                _User = new ClsUser();

                tbLoginInfo.Enabled = false;
                ctrPersonInfoWithFilter1.FilterFocus();
            }
            else
            {
                lbTitelForm.Text = "Update User";
                this.Text = "Update User";

                tbLoginInfo.Enabled = true;
                btnSave.Enabled = true;


            }

            txUserName.Text = "";
            txPassword.Text = "";
            txConfirmPassword.Text = "";
            chIsActive.Checked = true;


        }
        private void _LoadUserData()
        {
            _User = ClsUser.FindUserByUserID(_UserID);
            ctrPersonInfoWithFilter1.FilterEnabled = false;


            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }


            lbUserID.Text = _User.UserID.ToString();
            txUserName.Text = _User.UserName;                              
            txPassword.Text = _User.Password;
            txConfirmPassword.Text = _User.Password;
            chIsActive.Checked = _User.IsActive;
            ctrPersonInfoWithFilter1.LoadPersonInfo(_User.PersonID);



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

        private void txUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txUserName, null);
            };


            if (_Mode == enMode.AddMode)
            {

                if (ClsUser.IsUserExist(txUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txUserName, null);
                };
            }


            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txUserName.Text.Trim())
                {
                    if (ClsUser.IsUserExist(txUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txUserName, null);
                    };
                }
            }
        }
    }
}
    

