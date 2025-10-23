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
    public partial class frmShowApplicationDetails : Form
    {
        ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        public frmShowApplicationDetails(int LocalID,int PassedTestCount)
        {
            _LocalDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfo(LocalID);
            InitializeComponent();


            ctrLocalAppLicenseInfo1.LoadLocalApplicationInfo(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID,PassedTestCount);
            ctrApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicenseApplication.ApplicationID);
            
        }
    }
}
