using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Layer;


namespace DVLD_Business_Layer
{


    public class ClsPerson
    {


        public int PersonID { get; private set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; }
        public DateTime DateOfBirth { get; set; }
        public byte Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityID_FK { get; set; }
        public string ImagePath { get; set; }
        private enum enMode {AddMode,UpdateMode};
        enMode _Mode;

        

        

        /// ////////////////////////////////////////////////////////////////////////////////



        

        
        public  ClsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address,string Phone,string Email,int Country,string ImagePath)
        {
           
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.FullName = FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityID_FK = Country;
            this.ImagePath = ImagePath;
            _Mode = enMode.UpdateMode;
        }

        public ClsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityID_FK = -1;
            this.ImagePath = "";
            _Mode = enMode.AddMode;
        }

        public static ClsPerson Find(int PersonID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            string ImagePath = "";
            int NationalityCountryID = 0;
          
            if(ClsDataAccessLayer_Person.FindPerson(PersonID,ref NationalNo,ref FirstName,ref SecondName,ref ThirdName,ref LastName,ref DateOfBirth,ref Gendor,ref Address,ref Phone,ref Email,ref NationalityCountryID,ref ImagePath))
            {
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }


            return null;
            


        }


        public static ClsPerson Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            string ImagePath = "";
            int NationalityCountryID = 0;

            if (ClsDataAccessLayer_Person.FindPerson(ref PersonID,  NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new ClsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }


            return null;



        }
    

        private  bool _AddNewPerson()
        {

       

            this.PersonID = ClsDataAccessLayer_Person.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityID_FK, this.ImagePath);

            return PersonID > 0;
            

        }

        private bool _UpdatePerson()
        {
            return ClsDataAccessLayer_Person.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityID_FK, this.ImagePath);
        }

        public static bool DeletePerson(int PersonID)
        {
            return ClsDataAccessLayer_Person.DeletePerson(PersonID);
        }

        public static DataTable GetAllPersons()
        {
            return ClsDataAccessLayer_Person.GetAllPersons();
        }

        public static bool IsPersonExsit(int PersonID)
        {
            return ClsDataAccessLayer_Person.IsPersonExist(PersonID);
        }

        public static bool IsPersonExist(string NationalNo)
        {
            return ClsDataAccessLayer_Person.IsPersonExist(NationalNo);
        }

        
         public bool Save()
        {


            switch(_Mode)
            {
                case enMode.AddMode:

                    _Mode = enMode.UpdateMode;
                    return _AddNewPerson();


                case enMode.UpdateMode:
                    return _UpdatePerson();


                default:
                    return false;
            }
            

        }


        //////////////////////////////////////////





    }




}
