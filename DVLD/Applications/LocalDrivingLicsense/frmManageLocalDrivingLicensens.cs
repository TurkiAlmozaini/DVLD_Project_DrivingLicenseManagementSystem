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
    public partial class frmManageLocalDrivingLicensens : Form
    {

          

        private static DataTable AllLocalDrivingLicenseApplications = ClsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
        private DataTable _AllLocalDrivingLicenseApplications = AllLocalDrivingLicenseApplications.DefaultView.ToTable(false, "LocalDrivingLicenseApplicationID",
            "ClassName", "NationalNo", "FullName", "ApplicationDate", "PassedTestCount", "Status");


        public frmManageLocalDrivingLicensens()
        {
            InitializeComponent();
        }

        private void ManageLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            dvgAllLocalDrivingLicenseApplications.DataSource = _AllLocalDrivingLicenseApplications;
            lbRecordsCount.Text = dvgAllLocalDrivingLicenseApplications.Rows.Count.ToString();


            if(dvgAllLocalDrivingLicenseApplications.Rows.Count > 0)
            {
                dvgAllLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L AppID";
                dvgAllLocalDrivingLicenseApplications.Columns[0].Width = 110;

                dvgAllLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                dvgAllLocalDrivingLicenseApplications.Columns[1].Width = 150;

                dvgAllLocalDrivingLicenseApplications.Columns[2].HeaderText = "NationlNo";
                dvgAllLocalDrivingLicenseApplications.Columns[2].Width = 100;

                dvgAllLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dvgAllLocalDrivingLicenseApplications.Columns[3].Width = 150;

                dvgAllLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dvgAllLocalDrivingLicenseApplications.Columns[4].Width = 150;

                dvgAllLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dvgAllLocalDrivingLicenseApplications.Columns[5].Width = 100;

                dvgAllLocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
                dvgAllLocalDrivingLicenseApplications.Columns[6].Width = 150;

           
            }


            IssueDrivingLicenseForFirstTime_toolStripMenuItem.Enabled = false;
            ShowLicense_toolStripMenuItem.Enabled = false;
        }

        private void btnAddNewLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicenseApplication frm = new frmAddEditLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowApplicationDeatils_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dvgAllLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            int PassedTestCount = (int)dvgAllLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;
            frmShowApplicationDetails frm = new frmShowApplicationDetails(ID , PassedTestCount);
            frm.ShowDialog();
        }

        private void EditApplication_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicenseApplication frm = new frmAddEditLocalDrivingLicenseApplication((int)dvgAllLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void DeleteApplication_toolStripMenuItem_Click(object sender, EventArgs e)
        {

            ClsLocalDrivingLicenseApplication LDL = ClsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfo((int)dvgAllLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure do want delete this application ?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                
                // first we Cansel application from base table 

                if(clsApplications.Cancel(LDL.ApplicationID,2))
                {

                    if (ClsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication(LDL.LocalDrivingLicenseApplicationID))
                    {


                        MessageBox.Show("User Deleted Successfuly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                        
                    }
                } 
            }

           
        }

        private void CancelApplication_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SechduleTests_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void IssueDrivingLicenseForFirstTime_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ShowLicense_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ShowPersonLicenseHistory_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
