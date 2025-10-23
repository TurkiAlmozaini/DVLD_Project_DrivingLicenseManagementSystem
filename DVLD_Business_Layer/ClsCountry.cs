using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Layer;

namespace DVLD_Business_Layer
{
    public class ClsCountry
    {
      public  int CountryID { get; set; }
      public string CountryName { get; set; }




       public ClsCountry(int CountryID,string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }


        public static ClsCountry FindCountry(int CountryID)
        {
            string CountryName = "";

            if(ClsDataAccesLayer_Country.FindCountry(CountryID,ref CountryName))
            {
                return new ClsCountry(CountryID, CountryName);
            }

            return null;
        }


        public static ClsCountry FindCountry(string CountryName)
        {
            int CountryID = -1;

            if (ClsDataAccesLayer_Country.FindCountry(ref CountryID,CountryName))
            {
                return new ClsCountry(CountryID, CountryName);
            }

            return null;
        }


        public static DataTable GetAllCountries()
        {
            return ClsDataAccesLayer_Country.GetAllCountries();
        }





    }
}
