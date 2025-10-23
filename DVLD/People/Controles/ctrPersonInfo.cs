using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using DVLD_Business_Layer;
using System.IO;

namespace DVLD
{
    public partial class ctrPersonInfo : UserControl
    {



        private ClsPerson _Person;
        public ClsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        private int _PersonID = -1;
        public int PersonID
        {
            get
            {
                return _PersonID;
            }
        }




        

        public ctrPersonInfo()
        {
            InitializeComponent();
        }

   
 

        public void LoadPersonInfo(int PersonID)
        {

            
            _Person = ClsPerson.Find(PersonID);



            if(_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _FillPersonInfo();


        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = ClsPerson.Find(NationalNo);



            if (_Person == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {

            lnkEditInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lbPersonID.Text = _Person.PersonID.ToString();
            lbName.Text = _Person.FullName;
            lbNationalNo.Text = _Person.NationalNo;
            lbGendor.Text = (_Person.Gender == 0 ? "Male" : "Female");
            lbEmail.Text = _Person.Email;
            lbAddress.Text = _Person.Address;
            lbDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lbPhone.Text = _Person.Phone;
            lbCountry.Text = ClsCountry.FindCountry(_Person.NationalityID_FK).CountryName;
            _LoadPersonImage();


        }


        private void _ResetPersonInfo()
        {
            //_Person.PersonID = -1;

            lbPersonID.Text = "[????]";
            lbNationalNo.Text = "[????]";
            lbName.Text = "[????]";
            pcGendorImage.Image = Resources.Man_32;
            lbGendor.Text = "[????]";
            lbEmail.Text = "[????]";
            lbPhone.Text = "[????]";
            lbDateOfBirth.Text = "[????]";
            lbCountry.Text = "[????]";
            lbAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Man_32;

        }

        public void ResetPersonInfo()
        {
            _ResetPersonInfo();
        }

        private void _LoadPersonImage()
        {

            if(_Person.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;


            

            string ImagePath = _Person.ImagePath;


            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void lnkEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
    }
}
