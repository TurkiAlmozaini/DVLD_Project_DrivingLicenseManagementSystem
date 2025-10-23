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
    public partial class frmManageApplicationsTypes : Form
    {

        private static DataTable AllApplicationsTypes = clsApplicationsTypes.GetAllApplicationsTypes();
        private DataTable _AllApplicationsTypes = AllApplicationsTypes.DefaultView.ToTable(false, "ApplicationTypeID", "ApplicationTypeTitle", "ApplicationFees");

        public frmManageApplicationsTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationsType_Load(object sender, EventArgs e)
        {
            dvgAllApplicationsTypes.DataSource = _AllApplicationsTypes;
            lbRecordsCount.Text = dvgAllApplicationsTypes.Rows.Count.ToString();



            if (dvgAllApplicationsTypes.Rows.Count > 0)
            {

                dvgAllApplicationsTypes.Columns[0].HeaderText = "ID";
                dvgAllApplicationsTypes.Columns[0].Width = 90;


                dvgAllApplicationsTypes.Columns[1].HeaderText = "Title";
                dvgAllApplicationsTypes.Columns[1].Width = 280;

                dvgAllApplicationsTypes.Columns[2].HeaderText = "Fees";
                dvgAllApplicationsTypes.Columns[2].Width = 95;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editapplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEditApplicationsTypes frm = new frmEditApplicationsTypes((int)dvgAllApplicationsTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageApplicationsType_Load(null, null);
        }
    }
}
