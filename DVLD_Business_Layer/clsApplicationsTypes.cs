using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLD_Data_Layer;

namespace DVLD_Business_Layer
{
    public class clsApplicationsTypes
    {

        enum enMode { AddMode  , UpdateMode };
        enMode _Mode = enMode.AddMode;

      
            public int ID { get; set; }
            public string Title { get; set; }
            public float Fees { get; set; }

            public clsApplicationsTypes(int applicationTypeID, string applicationTypeTitle, float applicationFees)
            {
                this.ID = applicationTypeID;
                this.Title = applicationTypeTitle;
                this.Fees = applicationFees;
                _Mode = enMode.UpdateMode;
            }

            public clsApplicationsTypes()
            {
                this.ID = -1;
                this.Title = "";
                this.Fees = 0000;
                _Mode = enMode.AddMode;
            }
            
            public static clsApplicationsTypes Find(int applicationTypeID)
            {
                string appTypeTitle = "";
                float appFees = 0;

                if (clsDataAccsessLayer_ApplicationsTypes.FindApplicationType(applicationTypeID, ref appTypeTitle, ref appFees))
                {
                    return new clsApplicationsTypes(applicationTypeID, appTypeTitle, appFees);
                }

                return null;
            }

            public static DataTable GetAllApplicationsTypes()
            {
                return clsDataAccsessLayer_ApplicationsTypes.GetAllApplicationsTypes();
            }

            private bool _UpdateApplicationFees()
            {
                return clsDataAccsessLayer_ApplicationsTypes.UpdateApplicationFees(this.ID, this.Title, this.Fees);
            }

            private bool _AddNewApplicationType()
            {
                //call DataAccess Layer 
           
                this.ID = clsDataAccsessLayer_ApplicationsTypes.AddNewApplicationType(this.Title, this.Fees);
           
           
                return (this.ID != -1);
            }


            public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddMode:
                    if (_AddNewApplicationType())
                    {

                        _Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateMode:

                    return _UpdateApplicationFees();

            }

            return false;
        }
    }

 }



