using DVLD_Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class ClsLicenseClass
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        private enum enMode { AddMode, UpdateMode }
        private enMode _Mode;

        // Constructor for updating a license class
        public ClsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            _Mode = enMode.UpdateMode;
        }

        // Constructor for adding a new license class
        public ClsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = 0;
            _Mode = enMode.AddMode;
        }

        public static ClsLicenseClass FindLicenseClassByID(int LicenseClassID)
        {
            string ClassName = "";
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal  ClassFees = 0;

            if (ClsDataAccessLayer_LicenseClass.FindLicenseClassByID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new ClsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }

            return null;
        }

        public static ClsLicenseClass FindLicenseClassByClassName(string ClassName)
        {
            int LicenseClassID = 0;
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = 0;

            if (ClsDataAccessLayer_LicenseClass.FindLicenseClassByClassName(ref LicenseClassID,ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new ClsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }

            return null;
        }

        private bool _AddNewLicenseClass()
        {
            this.LicenseClassID = ClsDataAccessLayer_LicenseClass.AddNewLicenseClass(this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);

            return this.LicenseClassID > 0;
        }

        private bool _UpdateLicenseClass()
        {
            return ClsDataAccessLayer_LicenseClass.UpdateLicenseClass(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    return _AddNewLicenseClass();

                case enMode.UpdateMode:
                    return _UpdateLicenseClass();
            }

            return false;
        }

        public static bool DeleteLicenseClass(int LicenseClassID)
        {
            return ClsDataAccessLayer_LicenseClass.DeleteLicenseClass(LicenseClassID);
        }

        public static DataTable GetAllLicenseClasses()
        {
            return ClsDataAccessLayer_LicenseClass.GetAllLicenseClasses();
        }

     
    }

}
