using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Layer;

namespace DVLD_Business_Layer
{

    public class clsTestTypes
    {
        public enum enMode { AddMode, UpdateMode }
        private enMode _Mode = enMode.AddMode;

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }

        // Constructor for existing record (Update Mode)
        public clsTestTypes(int testTypeID, string testTypeTitle, string testTypeDescription, float testTypeFees)
        {
            this.ID = testTypeID;
            this.Title = testTypeTitle;
            this.Description = testTypeDescription;
            this.Fees = testTypeFees;
            _Mode = enMode.UpdateMode;
        }

        // Constructor for new record (Add Mode)
        public clsTestTypes()
        {
            this.ID = -1;
            this.Title = "";
            this.Description = "";
            this.Fees = 0.0f;
            _Mode = enMode.AddMode;
        }

        // Static method to find a TestType by ID
        public static clsTestTypes Find(int testTypeID)
        {
            string title = "";
            string description = "";
            float fees = 0;

            if (clsDataAccessLayer_TestsTypes.FindTestType(testTypeID, ref title, ref description, ref fees))
            {
                return new clsTestTypes(testTypeID, title, description, fees);
            }

            return null;
        }

        // Static method to get all TestTypes
        public static DataTable GetAllTestTypes()
        {
            return clsDataAccessLayer_TestsTypes.GetAllTestTypes();
        }

        // Private method to update existing TestType
        private bool _UpdateTestType()
        {
            return clsDataAccessLayer_TestsTypes.UpdateTestType(this.ID, this.Title, this.Description, this.Fees);
        }

        // Private method to add new TestType
        private bool _AddNewTestType()
        {
            this.ID = clsDataAccessLayer_TestsTypes.AddNewTestType(this.Title, this.Description, this.Fees);
            return (this.ID != -1);
        }

        // Public method to save changes (Add or Update)
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddNewTestType())
                    {
                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    return false;

                case enMode.UpdateMode:
                    return _UpdateTestType();
            }

            return false;
        }
    }



}
