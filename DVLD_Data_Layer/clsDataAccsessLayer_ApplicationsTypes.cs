using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_Data_Layer
{
    public class clsDataAccsessLayer_ApplicationsTypes
    {



        public static bool FindApplicationType(int ApplicationTypeID,ref string ApplicationTypeTitle, ref float ApplicationFees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = @"Select * From ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                   
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToSingle(reader["ApplicationFees"]);

                }
           
                reader.Close();
            }

            catch
            {
                IsFound = false;
                connection.Close();
            }

            finally
            {
                connection.Close();
            }


            return IsFound;
        }
        public static DataTable GetAllApplicationsTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"Select * From ApplicationTypes";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                else
                    dt = null;

                reader.Close();
            }

            catch
            {
                connection.Close();
            }

            finally
            {
                connection.Close();
            }

            return dt;



        }
        public static bool UpdateApplicationFees(int ID,string Title, float Fees)
        {
            int RowsUpdated = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"Update ApplicationTypes
                            Set ApplicationFees = @ApplicationFees,
                            ApplicationTypeTitle = @ApplicationTypeTitle
                            Where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ID);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);
            command.Parameters.AddWithValue("@ApplicationTypeTitle",Title);


            try
            {
                connection.Open();
                RowsUpdated = command.ExecuteNonQuery();

            }

            catch
            {
                connection.Close();
            }

            finally
            {
                connection.Close();
            }




            return RowsUpdated > 0;


        }
        public static int AddNewApplicationType(string Title, float Fees)
        {
            int ApplicationTypeID = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = @"Insert Into ApplicationTypes (ApplicationTypeTitle,ApplicationFees)
                            Values (@Title,@Fees)
                            
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", Title);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationTypeID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return ApplicationTypeID;

        }
    }
}
