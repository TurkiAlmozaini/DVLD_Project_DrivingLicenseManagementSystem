using DVLD_Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_Business_Layer
{
    public class ClsUser
    {

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        private enum enMode { AddMode, UpdateMode }
        private enMode _Mode;

        // Constructor for updating a user
        public ClsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            _Mode = enMode.UpdateMode;
        }

        // Constructor for adding a new user
        public ClsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            _Mode = enMode.AddMode;
        }

        public static ClsUser FindUserByUserID(int UserID)
        {

            int PersonID = -1;
            string UserName = "";
            string password = "";
            bool isActive = false;

            if (ClsDataAccessLayer_User.FindUserByUserID(UserID, ref PersonID, ref UserName, ref password, ref isActive))
            {
                return new ClsUser(UserID, PersonID, UserName, password, isActive);
            }

            return null;
        }

        public static ClsUser FindUserByPersonID(int PersonID)
        {

            int UserID = -1;
            string UserName = "";
            string password = "";
            bool isActive = false;

            if (ClsDataAccessLayer_User.FindUserByPersonID(ref UserID, PersonID, ref UserName, ref password, ref isActive))
            {
                return new ClsUser(UserID, PersonID, UserName, password, isActive);
            }

            return null;
        }

        public static ClsUser FindUserByUserNameAndPassword(string UserName,string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            bool isActive = false;

            if (ClsDataAccessLayer_User.FindUserByUserNameAndPassword(ref UserID,ref PersonID,  UserName, Password, ref isActive))
            {
                return new ClsUser(UserID, PersonID, UserName, Password, isActive);
            }

            return null;
        }

        private bool _AddNewUser()
        {

            this.UserID = ClsDataAccessLayer_User.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);

            return this.UserID > 0;
        }

        private bool _UpdateUser()
        {
            return ClsDataAccessLayer_User.UpdateUesr(this.UserID, this.UserName, this.Password, this.IsActive);
        }

        public static bool DeleteUser(int UserID)
        {
            return ClsDataAccessLayer_User.DeleteUser(UserID);
        }

        public static DataTable GetAllUsers()
        {
            return ClsDataAccessLayer_User.GetAllUsers();
        }

        
        public static bool IsUserExist(int UserID)
        {
            return ClsDataAccessLayer_User.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return ClsDataAccessLayer_User.IsUserExist(UserName);
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            return ClsDataAccessLayer_User.IsUserExistForPersonID(PersonID);
        }


        public static bool ChangePassword(int UserID,string NewPassword)
        {
            return ClsDataAccessLayer_User.ChangePassword(UserID, NewPassword);
        }






        public bool Save()
        {


            switch (_Mode)
            {
                case enMode.AddMode:

                    _Mode = enMode.UpdateMode;
                    return _AddNewUser();


                case enMode.UpdateMode:
                    return _UpdateUser();


                default:
                    return false;
            }



        }
















    }


    
}
