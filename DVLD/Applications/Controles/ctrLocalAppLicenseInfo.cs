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
    public partial class ctrLocalAppLicenseInfo : UserControl
    {

        private int ID = 0;
        private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private int _PassedTestCount = 0;
        public ctrLocalAppLicenseInfo()
        {
            InitializeComponent();


        }

    
        public void LoadLocalApplicationInfo(int ID,int PassedTestCount)
        {
            _LocalDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfo(ID);
            _PassedTestCount = PassedTestCount; 


            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Local Driving License Application with App = " + _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _FillLocalDrivingLicenseApplicationInfo();



        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            lbID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lbLicense.Text = ClsLicenseClass.FindLicenseClassByID(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            lbPassedTest.Text = _PassedTestCount.ToString();

            


       

            
        }

        private void _ResetPersonInfo()
        {
            lbID.Text = "[????]";
            lbLicense.Text = "[????]";
            lbPassedTest.Text = "[????]";
        }
    }
}
