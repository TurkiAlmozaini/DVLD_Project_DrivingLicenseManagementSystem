using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using DVLD_Business_Layer;

namespace DVLD
{
    public partial class frmAddEditPerson : Form
    {

        


       

        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;



        private enum enMode { AddMode, UpdateMode };
        enMode _Mode;
        ClsPerson _Person;
        private int _PersonID = -1;


        public frmAddEditPerson()
        {
            InitializeComponent();

            _Mode = enMode.AddMode;
            _Person = new ClsPerson();
           
        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.UpdateMode;
            _PersonID = PersonID;




        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
           
            if(_Mode == enMode.UpdateMode)
                _LoadData();
            
           

        }

        private void _LoadData()
        {
            _Person = ClsPerson.Find(_PersonID);






            if(_Person == null)
            {
                MessageBox.Show("No Person With ID" + _PersonID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }


            lbPersonID.Text = _Person.PersonID.ToString();
            txFirstName.Text = _Person.FirstName;
            txSecondName.Text = _Person.SecondName;
            txThirdName.Text = _Person.ThirdName;
            txLastName.Text = _Person.LastName;
            txNationlNo.Text = _Person.NationalNo;
            txEmail.Text = _Person.Email;
            txAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            txPhone.Text = _Person.Phone;
            cbCountry.Text = ClsCountry.FindCountry(_Person.NationalityID_FK).CountryName;



            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;



            if(_Person.ImagePath != "")
            {
                pbImage.ImageLocation = _Person.ImagePath;
            }


             llRemove.Visible = (pbImage.ImageLocation != null);
          
               
            
              

            


            

            

        }


        private void _ResetDefualtValues()
        {
            _FillCountriesInComboBox();

            if (_Mode == enMode.AddMode)
            {
                lbModeForm.Text = "Add New Person";
                this.Text = "Add New Person";
                _Person = new ClsPerson();
            }
            else
            {
                lbModeForm.Text = "Update Person";
                this.Text = "Edit Person";



            }


         



           // llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountry.SelectedIndex = cbCountry.FindString("Jordan");

            txFirstName.Text = "";
            txSecondName.Text = "";
            txThirdName.Text = "";
            txLastName.Text = "";
            txNationlNo.Text = "";
            rbMale.Checked = true;
            txPhone.Text = "";
            txEmail.Text = "";
            txAddress.Text = "";



            if (rbMale.Checked)
                pbImage.Image = Resources.Male_512;
            else
                pbImage.Image = Resources.Female_512;


            llRemove.Visible = false;

        }


        private void _FillCountriesInComboBox()
        {

            DataTable dtCountries = ClsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }

            cbCountry.SelectedIndex = 150 - 1;

        }

        private bool _HandlePersonImage()
        {



            if(_Person.ImagePath != pbImage.ImageLocation)
            {
                if(_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);


                    }
                    catch (IOException)
                    {

                    }
                }
            }



            if(pbImage.ImageLocation != null)
            {
                string SourceImageFile = pbImage.ImageLocation.ToString();

                if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                {
                    pbImage.ImageLocation = SourceImageFile;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }


            return true;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (!_HandlePersonImage())
                return;



            _Person.FirstName = txFirstName.Text;
            _Person.SecondName = txSecondName.Text;
            _Person.ThirdName = txThirdName.Text;
            _Person.LastName = txLastName.Text;
            _Person.NationalNo = txNationlNo.Text;
            _Person.Email = txEmail.Text;
            _Person.Phone = txPhone.Text;
            _Person.Address = txAddress.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Person.Gender = 0;
            else
                _Person.Gender = 1;

            if (pbImage.ImageLocation != null)
                _Person.ImagePath = pbImage.ImageLocation;
            else
                _Person.ImagePath = "";


            _Person.NationalityID_FK = ClsCountry.FindCountry(cbCountry.Text).CountryID;

           
            

          


            if(_Person.Save())
            {

                lbPersonID.Text = _Person.PersonID.ToString();
                _Mode = enMode.UpdateMode;
                lbModeForm.Text = "Update Person";
                MessageBox.Show(" Data Saved Successfuly ", " Saved ", MessageBoxButtons.OK,MessageBoxIcon.Information);

                DataBack?.Invoke(this, _Person.PersonID);

            }
            else
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(pbImage.ImageLocation == null)
            pbImage.Image = Resources.Male_512;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation == null)
                pbImage.Image = Resources.Female_512;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidation.ValidateEmail(txEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txEmail, null);
            };
        }

        private void txNationlNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txNationlNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txNationlNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txNationlNo, null);
            }

            //Make sure the national number is not used by another person
            if (ClsPerson.IsPersonExist(txNationlNo.Text) && txNationlNo.Text.Trim() != _Person.NationalNo)
            {
                e.Cancel = true;
                errorProvider1.SetError(txNationlNo, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txNationlNo, null);
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbImage.Load(selectedFilePath);

                llRemove.Visible = true;
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
              pbImage.ImageLocation = null;

            if (rbMale.Checked)
                pbImage.Image = Resources.Male_512;
            else
                pbImage.Image = Resources.Female_512;


            llRemove.Visible = false;
        }

    }
}