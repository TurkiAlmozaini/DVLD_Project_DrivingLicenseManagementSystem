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
    public partial class frmManagePeople : Form
    {

       private static DataTable  _dtAllPeople = ClsPerson.GetAllPersons();

       private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "GendorCaption", "DateOfBirth", "CountryName", "Phone", "Email");


        public frmManagePeople()
        {
            InitializeComponent();
            this.Location = new Point(30, 120);
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            dgvAllPeople.DataSource = _dtPeople;
            CbFilterBy.SelectedIndex = 0;
            lbRecordsCount.Text = dgvAllPeople.Rows.Count.ToString();

           





            if (dgvAllPeople.Rows.Count > 0)
            {

               

                   dgvAllPeople.Columns[0].HeaderText = "Person ID";
                   dgvAllPeople.Columns[0].Width = 110;
                 
                   dgvAllPeople.Columns[1].HeaderText = "National No.";
                   dgvAllPeople.Columns[1].Width = 120;
                   
                 
                   dgvAllPeople.Columns[2].HeaderText = "First Name";
                   dgvAllPeople.Columns[2].Width = 120;
                  
                   dgvAllPeople.Columns[3].HeaderText = "Second Name";
                   dgvAllPeople.Columns[3].Width = 140;
                 
                  
                   dgvAllPeople.Columns[4].HeaderText = "Third Name";
                   dgvAllPeople.Columns[4].Width = 120;
              
                   dgvAllPeople.Columns[5].HeaderText = "Last Name";
                   dgvAllPeople.Columns[5].Width = 120;

                   dgvAllPeople.Columns[6].HeaderText = "Gendor";
                   dgvAllPeople.Columns[6].Width = 120;
               
                   dgvAllPeople.Columns[7].HeaderText = "Date Of Birth";
                   dgvAllPeople.Columns[7].Width = 140;
               
                   dgvAllPeople.Columns[8].HeaderText = "Nationality";
                   dgvAllPeople.Columns[8].Width = 120;
                
                   
                   dgvAllPeople.Columns[9].HeaderText = "Phone";
                   dgvAllPeople.Columns[9].Width = 120;
                 
               
                   dgvAllPeople.Columns[10].HeaderText = "Email";
                   dgvAllPeople.Columns[10].Width = 170;
                 

            }
            
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            textFilterValue.Visible = (CbFilterBy.Text != "None");


            if(textFilterValue.Visible)
            {
                textFilterValue.Text = "";
                textFilterValue.Focus();
            }
        }

        private void textFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            //Map Selected Filter to real Column name 
            switch (CbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                   FilterColumn = "CountryName";
                   break;

                case "Gendor":
                   FilterColumn = "GendorCaption";
                   break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }


            if (textFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                 
                _dtPeople.DefaultView.RowFilter = "";
                lbRecordsCount.Text = dgvAllPeople.Rows.Count.ToString();

                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, textFilterValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, textFilterValue.Text.Trim());

                lbRecordsCount.Text = dgvAllPeople.Rows.Count.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvAllPeople.CurrentRow.Cells[0].Value;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            _RefreshPeoplList();
 
            


        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeoplList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          


            if (MessageBox.Show("Are you sure want to delete person [" + dgvAllPeople.CurrentRow.Cells[0].Value + "]","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (ClsPerson.DeletePerson((int)dgvAllPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeoplList();
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Next Time");

        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Next Time");
        }

        private void _RefreshPeoplList()
        {
            _dtAllPeople = ClsPerson.GetAllPersons();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dgvAllPeople.DataSource = _dtPeople;
            lbRecordsCount.Text = dgvAllPeople.Rows.Count.ToString();
        }

        private void textFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (CbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            
        }

        
    }
}