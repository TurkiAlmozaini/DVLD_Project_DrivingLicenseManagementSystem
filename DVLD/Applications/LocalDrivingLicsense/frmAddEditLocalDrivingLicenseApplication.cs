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
    public partial class frmAddEditLocalDrivingLicenseApplication : Form
    {

       public enum enMode { AddNew = 0, Update = 1 };
       public enMode Mode = enMode.AddNew;

       private int _LocalDrivingLicenseApplicationID = -1;
       private ClsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public frmAddEditLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }


        public frmAddEditLocalDrivingLicenseApplication(int ID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = ID;
            Mode = enMode.Update;
        }



        private void _ResetDefultValue()
        {
            _FillLicenseClassesIntoComboBox();


            if (Mode == enMode.AddNew)
            {
                this.Text = "Add New Local Driving License";
                lbTitelForm.Text = "Add New Local Driving License Application";
                ctrPersonInfoWithFilter1.FilterFocus();
                tbLoginApplication.Enabled = false;

                cbLicenseClasses.SelectedIndex = 2;
                lbFees.Text = clsApplicationsTypes.Find((int)clsApplications.enApplicationType.NewDrivingLicense).Fees.ToString();
                lbCreated.Text = clsGlobal.CurrentUser.UserName;
                

            }
            else
            {
                this.Text = "Update Local Driving License";
                lbTitelForm.Text = "Update Local Driving License Application";
                ctrPersonInfoWithFilter1.FilterEnabled = false;
                tbApplicationInfo.Enabled = true;
                


            }





            lbDate.Text = DateTime.Now.ToShortDateString();
            lbCreated.Text = clsGlobal.CurrentUser.UserName;
            lbFees.Text = clsApplicationsTypes.Find(1).Fees.ToString();




        }

        private void _FillLicenseClassesIntoComboBox()
        {

            DataTable dtLicenseClasses = ClsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                cbLicenseClasses.Items.Add(row["ClassName"]);
            }

            cbLicenseClasses.SelectedIndex = 1;
        }

        private void _LoadData()
        {
            _LocalDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfo(_LocalDrivingLicenseApplicationID);

            ctrPersonInfoWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);

            lbLID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            cbLicenseClasses.Text = ClsLicenseClass.FindLicenseClassByID(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            lbFees.Text = clsApplicationsTypes.Find(_LocalDrivingLicenseApplication.ApplicationTypeID).Fees.ToString();
            lbCreated.Text = clsGlobal.CurrentUser.UserName;
            
            

            
        }

        private void frmAddEditLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

            _ResetDefultValue();

            if(Mode == enMode.Update)
            {
                _LoadData();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {


            if (Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbApplicationInfo.Enabled = true;
                tbApplicationInfo.SelectedTab = tbApplicationInfo.TabPages["tbLoginApplication"];
                return;
            }




            if (ctrPersonInfoWithFilter1.PersonID != -1)
            {

                    tbApplicationInfo.SelectedTab = tbApplicationInfo.TabPages["tbLoginApplication"];
                    tbLoginApplication.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrPersonInfoWithFilter1.FilterFocus();
            }

          
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            int LicenseClassID = ClsLicenseClass.FindLicenseClassByClassName(cbLicenseClasses.Text).LicenseClassID;
            int ActiveApplicationID = clsApplications.GetActiveApplicationIDForLicenseClass(ctrPersonInfoWithFilter1.PersonID, clsApplications.enApplicationType.NewDrivingLicense, LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClasses.Focus();
                return;
            }


            

 
                _LocalDrivingLicenseApplication = new ClsLocalDrivingLicenseApplication();
                _LocalDrivingLicenseApplication.ApplicantPersonID = ctrPersonInfoWithFilter1.PersonID;
                _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
                _LocalDrivingLicenseApplication.ApplicationTypeID = ((int)clsApplications.enApplicationType.NewDrivingLicense);
                _LocalDrivingLicenseApplication.ApplicationStatus = clsApplications.enApplicationStatus.New;
                _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
                _LocalDrivingLicenseApplication.PaidFees = Convert.ToSingle(lbFees.Text);
                _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;



                if (_LocalDrivingLicenseApplication.Save())
                {
                    ctrPersonInfoWithFilter1.FilterEnabled = false;
                    lbLID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                    this.Text = "Update Local Driving License";
                    lbTitelForm.Text = "Update Local Driving License Application";
                    MessageBox.Show(" Data Saved Successfuly ", " Saved ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
       

        }


    }
}
