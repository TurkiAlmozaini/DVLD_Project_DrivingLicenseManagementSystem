using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;

namespace DVLD
{
    public partial class ctrApplicationBasicInfo : UserControl
    {

        private int _ID = 0;
        private clsApplications _Applications;
        public ctrApplicationBasicInfo()
        {
            InitializeComponent();
        }




        public void LoadApplicationInfo(int ID)
        {
            _Applications = clsApplications.FindBaseApplication(ID);
           


            if (_Applications == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Application with ID = " + _Applications.ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _FillLocalDrivingLicenseApplicationInfo();



        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            lbID.Text = _Applications.ApplicationID.ToString();
            lbStatus.Text = _Applications.StatusText;
            lbFees.Text = _Applications.PaidFees.ToString();
            lbType.Text = _Applications.ApplicationTypeInfo.Title;
            lbApplicant.Text = _Applications.ApplicantFullName;
            lbDate.Text = _Applications.ApplicationDate.ToString();
            lbStatusDate.Text = _Applications.LastStatusDate.ToString();
            lbUser.Text = _Applications.CreatedByUserInfo.UserName;


        }

        private void _ResetPersonInfo()
        {

            lbID.Text = "[????]";
            lbStatus.Text = "[????]";
            lbFees.Text = "[????]";
            lbType.Text = "[????]";

            lbApplicant.Text = "[????]";

            lbDate.Text = "[????]";

            lbStatusDate.Text = "[????]";

            lbUser.Text = "[????]";
        }
    }
}
