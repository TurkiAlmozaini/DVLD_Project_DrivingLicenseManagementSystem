using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;


namespace DVLD_Data_Layer
{
    public class ClsDataAccessLayer_Person
    {

        
      
       
        public static bool FindPerson(int PersonID,ref string NationalNo ,ref string FirstName,ref string SecondName , ref string ThirdName,ref string LastName,ref DateTime DateOfBirth, ref byte Gendor,ref string Address,ref string Phone,ref string Email,ref int NationalityCountryID,ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "Select * From People Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);

            


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                if(reader.Read())
                {
                    IsFound = true;


                    PersonID = (int)reader["PersonID"];
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = "";

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";





                    reader.Close();

                }

            }

            catch (Exception ex)
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



        public static bool FindPerson(ref int PersonID ,string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "Select * From People Where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@NationalNo", NationalNo);




            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    IsFound = true;


                    PersonID = (int)reader["PersonID"];
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ImagePath = "";

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        ImagePath = "";

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";





                    reader.Close();

                }

            }

            catch (Exception ex)
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

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
               int personID = 0;


               SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

               string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
                 VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                 SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);

               if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
               else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Gendor", Gendor);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Phone", Phone);


               if(Email != "")
                command.Parameters.AddWithValue("@Email", Email);
               else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

               command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

               if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
               else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    personID = insertedID;
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

                return personID;
        }

        public static bool DeletePerson(int PersonID)
        {
            int RowDeleted = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "Delete From People Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();

                RowDeleted = command.ExecuteNonQuery();


               
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();

            }



            return RowDeleted > 0;

        }

        public static bool  UpdatePerson(int PersonID ,string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int RowsUpdated = 0;



            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
                string query = @"UPDATE People 
                         SET FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, 
                             LastName = @LastName, DateOfBirth = @DateOfBirth, Gendor = @Gendor, 
                             Address = @Address, Phone = @Phone, Email = @Email, 
                             NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath
                         WHERE PersonID = @PersonID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);

                if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
                else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Gendor", Gendor);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Phone", Phone);

                 if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
                else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

                command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
                else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
                {
                    connection.Open();
                    RowsUpdated = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., log it)
                }
                finally
                {
                    connection.Close();
                }


            return RowsUpdated > 0;
        }

        public static DataTable GetAllPersons()
        {
            DataTable TablePersons = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            
            string query = @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth, People.Gendor,  
				  CASE
                  WHEN People.Gendor = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GendorCaption,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID
                ORDER BY People.FirstName";


            SqlCommand command = new SqlCommand(query, connection);



            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    TablePersons.Load(reader);
                }
                else
                    TablePersons = null;

                reader.Close();
                
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();

            }

            return TablePersons;
        }



        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

    }
}
