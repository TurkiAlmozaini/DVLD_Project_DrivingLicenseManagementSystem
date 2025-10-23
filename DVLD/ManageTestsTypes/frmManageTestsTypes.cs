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
    public partial class frmManageTestsTypes : Form
    {


        private DataTable _AllTestsTypes = clsTestTypes.GetAllTestTypes();


        public frmManageTestsTypes()
        {
            InitializeComponent();
        }

        private void frmManageTestsTypes_Load(object sender, EventArgs e)
        {

            dvgTestsTypes.DataSource = _AllTestsTypes;
            lbRecordsCount.Text = dvgTestsTypes.Rows.Count.ToString();

            if(dvgTestsTypes.Rows.Count > 0 )
            {

               dvgTestsTypes.Columns[0].HeaderText = "ID";
               dvgTestsTypes.Columns[0].Width = 90;
       
              
               dvgTestsTypes.Columns[1].HeaderText = "Title";
               dvgTestsTypes.Columns[1].Width = 200;
            
               dvgTestsTypes.Columns[2].HeaderText = "Description";
               dvgTestsTypes.Columns[2].Width = 500;

                dvgTestsTypes.Columns[3].HeaderText = "Fees";
                dvgTestsTypes.Columns[3].Width = 200;
            }  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType((int)dvgTestsTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
