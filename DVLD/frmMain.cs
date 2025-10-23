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
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        

        public frmMain(frmLogin frm)
        {
            InitializeComponent();

            _frmLogin = frm;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePeople Form = new frmManagePeople();
            Form.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frm = new frmManageUsers();
            frm.Show();
            
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);

            frm.ShowDialog();
        }

        private void signToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void manageApplicationsTypsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationsTypes frm = new frmManageApplicationsTypes();
            frm.ShowDialog();
        }

        private void manageTestsTaypsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestsTypes frm = new frmManageTestsTypes();
            frm.ShowDialog();
        }

        //*******************************************************************************//
        //*******************************************************************************//

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicenseApplication frm = new frmAddEditLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicensens frm = new frmManageLocalDrivingLicensens();
            frm.ShowDialog();
        }
    }
}
