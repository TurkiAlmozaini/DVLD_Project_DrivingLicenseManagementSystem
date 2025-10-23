using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Layer;
using System.Data;

namespace DVLD_Business_Layer
{
    public class ClsLocalDrivingLicenseApplication : clsApplications
    {

        
        public enum enMode { AddNew = 0, Update = 1 };
        public new  enMode Mode = enMode.AddNew;
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        //public clsLicenseClass LicenseClassInfo;
        public string PersonFullName
        {
            get
            {
                return ClsPerson.Find(ApplicantPersonID).FullName;
            }

        }

        public ClsLocalDrivingLicenseApplication()

        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;
            Mode = enMode.AddNew;

        }

        private ClsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID, int LicenseClassID)

        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID; ;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = (int)ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
           // this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            Mode = enMode.Update;
        }



        public static ClsLocalDrivingLicenseApplication FindLocalDrivingLicenseApplicationInfo(int ID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            if (clsDataAccessLayer_LocalDrivingLicenseApplications.FindByLocalDrivingLicenseApplicationID(ID, ref ApplicationID, ref LicenseClassID))
            {
                clsApplications application = clsApplications.FindBaseApplication(ApplicationID);

                if (application != null)
                {
                    return new ClsLocalDrivingLicenseApplication(ID,
                        ApplicationID,
                        application.ApplicantPersonID,
                        application.ApplicationDate,
                        application.ApplicationTypeID,
                        application.ApplicationStatus,
                        application.LastStatusDate,
                        application.PaidFees,
                        application.CreatedByUserID,
                        LicenseClassID);
                }
            }

            return null;
        }


        public static ClsLocalDrivingLicenseApplication FindByApplicationID(int ID)
        {

            clsApplications application = clsApplications.FindBaseApplication(ID);

            int LocalDrivingLicenseApplicationID = -1;
            int LicenseClassID = -1;




            if (clsDataAccessLayer_LocalDrivingLicenseApplications.FindByApplicationID(application.ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID))
            {


                if (application != null)
                {
                    return new ClsLocalDrivingLicenseApplication(ID,
                        application.ApplicationID,
                        application.ApplicantPersonID,
                        application.ApplicationDate,
                        application.ApplicationTypeID,
                        application.ApplicationStatus,
                        application.LastStatusDate,
                        application.PaidFees,
                        application.CreatedByUserID,
                        LicenseClassID);
                }
                
            }


            return null;
        }


        public bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = clsDataAccessLayer_LocalDrivingLicenseApplications.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);

            return this.LocalDrivingLicenseApplicationID > 0;
        }


        public static bool DeleteLocalDrivingLicenseApplication(int ID)
        {

            // frist we shoud cansel base application in tabel Application

           
            return clsDataAccessLayer_LocalDrivingLicenseApplications.DeleteLocalDrivingLicenseApplication(ID);
        }


        public bool _UpdateLocalDrivingLicenseApplication()
        {

            return clsDataAccessLayer_LocalDrivingLicenseApplications.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }


        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsDataAccessLayer_LocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications();
        }


        public static bool IsLoalDrivingLicenseApplicationExist(int ID)
        {
            return clsDataAccessLayer_LocalDrivingLicenseApplications.IsLocalDrivingLicenseApplicationExist(ID);
        }



        public new  bool  Save()
        {


            base.Mode = (clsApplications.enMode)Mode;
            if (!base.Save())
                return false;


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalDrivingLicenseApplication();

            }

            return false;

        }









    }



}
