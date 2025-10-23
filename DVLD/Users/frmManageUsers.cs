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

    
    public partial class frmManageUsers : Form
    {

        private static DataTable _AllDataUsers = ClsUser.GetAllUsers();
        private DataTable _DataUsers = _AllDataUsers.DefaultView.ToTable(false, "UserID", "PersonID", "FullName", "UserName", "IsActive");
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            CbFilterBy.SelectedIndex = 0;
            dvgAllUsers.DataSource = _DataUsers;
            lbRecordsCount.Text = dvgAllUsers.Rows.Count.ToString();


            if(dvgAllUsers.Rows.Count > 0)
            {

                dvgAllUsers.Columns[0].HeaderText = "User ID";
                dvgAllUsers.Columns[0].Width = 110;

                dvgAllUsers.Columns[1].HeaderText = "Person ID";
                dvgAllUsers.Columns[1].Width = 110;

                dvgAllUsers.Columns[2].HeaderText = "Full Name";
                dvgAllUsers.Columns[2].Width = 300;

                dvgAllUsers.Columns[3].HeaderText = "User Name";
                dvgAllUsers.Columns[3].Width = 130;

                dvgAllUsers.Columns[4].HeaderText = "Is Active";
                dvgAllUsers.Columns[4].Width = 80;
            }
        }

        private void textFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColom = "";


            switch(CbFilterBy.Text)
            {
                case "User ID":
                    FilterColom = "UserID";
                    break;

                case "Person ID":
                    FilterColom = "PersonID";
                    break;

                case "Full Name":
                    FilterColom = "FullName";
                    break;


                case "User Name":
                    FilterColom = "UserName";
                    break;


                default:
                    FilterColom = "None";
                    break;

            }



            if (textFilterValue.Text.Trim() == "" || FilterColom == "None")
            {
                _DataUsers.DefaultView.RowFilter = "";
                lbRecordsCount.Text = dvgAllUsers.Rows.Count.ToString();
                return;
            }
            


            if (FilterColom == "PersonID" || FilterColom == "UserID")
                //in this case we deal with integer not string.

                _DataUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColom, textFilterValue.Text.Trim());
            else
                _DataUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColom, textFilterValue.Text.Trim());

            lbRecordsCount.Text = dvgAllUsers.Rows.Count.ToString();


        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            textFilterValue.Visible = (CbFilterBy.Text != "None" && CbFilterBy.Text !=  "Is Acitve");
            textFilterValue.Focus();

            /////////////////////////////
            ///////////////////////////

            cbIsFilterIsActive.Visible = (CbFilterBy.Text == "Is Acitve");
            cbIsFilterIsActive.SelectedIndex = 0;
        }

        private void cbIsFilterIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {




            string FilterColumn = "IsActive";
            string FilterValue = cbIsFilterIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _DataUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _DataUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lbRecordsCount.Text = dvgAllUsers.Rows.Count.ToString();

        }

        private void textFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (CbFilterBy.Text == "Person ID" || CbFilterBy.Text == "User ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
              


        }

        private void showdeatilstoolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmShowUserInfo frm = new frmShowUserInfo((int)dvgAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditUser frm = new FrmAddEditUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditUser frm = new FrmAddEditUser((int)dvgAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are You Sure Want To Delete User [" + dvgAllUsers.CurrentRow.Cells[0].Value + "]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {

                if (ClsUser.DeleteUser((int)dvgAllUsers.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("User Deleted Successfuly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("there Error Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dvgAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditUser frm = new FrmAddEditUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void _RefreshUsersList()
        {
            _AllDataUsers = ClsUser.GetAllUsers();
            _DataUsers = _AllDataUsers.DefaultView.ToTable(false, "UserID", "PersonID", "FullName", "UserName", "IsActive");


            dvgAllUsers.DataSource = _DataUsers;
            lbRecordsCount.Text = dvgAllUsers.Rows.Count.ToString();
        }

   
    }



}
