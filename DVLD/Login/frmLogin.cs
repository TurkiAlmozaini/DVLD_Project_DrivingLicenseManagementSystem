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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            ClsUser User = ClsUser.FindUserByUserNameAndPassword(txUserName.Text.Trim(), txPassword.Text.Trim());


            if(User != null)
            {
              
               if(chIsRemaindMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txUserName.Text.Trim(), txPassword.Text.Trim());
                }
               else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (!User.IsActive)
                {

                    txUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                clsGlobal.CurrentUser = User;
                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();

                
            }

           
          
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
                string UserName = "", Password = "";

                if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
                {
                    txUserName.Text = UserName;
                    txPassword.Text = Password;
                    chIsRemaindMe.Checked = true;
                }
                else
                    chIsRemaindMe.Checked = false;

            
        }
    }
}
