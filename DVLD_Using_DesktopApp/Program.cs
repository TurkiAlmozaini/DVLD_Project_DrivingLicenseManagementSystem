using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business_Layer;

namespace DVLD_Using_ConsoleApp
{
    internal class Program
    {

        
       
        static void FindPerson(int ID)
        {
            ClsPerson Person = ClsPerson.Find(ID);



            if(Person != null)
            {



               


                Console.WriteLine(Person.PersonID);
                Console.WriteLine(Person.NationalNo);
                Console.WriteLine(Person.FirstName);
                Console.WriteLine(Person.SecondName);
                Console.WriteLine(Person.ThirdName);
                Console.WriteLine(Person.LastName);
                Console.WriteLine(Person.DateOfBirth);
                Console.WriteLine(Person.Gender);
                Console.WriteLine(Person.Address);
                Console.WriteLine(Person.Phone);
                Console.WriteLine(Person.Email);
                Console.WriteLine(Person.NationalityID_FK);
                Console.WriteLine(Person.ImagePath);
                                        
            }

        }


        static void FindPerson(string NationalNo)
        {
            ClsPerson Person = ClsPerson.Find(NationalNo);

            if (Person != null)
            {






                Console.WriteLine(Person.PersonID);
                Console.WriteLine(Person.NationalNo);
                Console.WriteLine(Person.FirstName);
                Console.WriteLine(Person.SecondName);
                Console.WriteLine(Person.ThirdName);
                Console.WriteLine(Person.LastName);
                Console.WriteLine(Person.DateOfBirth);
                Console.WriteLine(Person.Gender);
                Console.WriteLine(Person.Address);
                Console.WriteLine(Person.Phone);
                Console.WriteLine(Person.Email);
                Console.WriteLine(Person.NationalityID_FK);
                Console.WriteLine(Person.ImagePath);

            }
        }

        static void AddPerson()
        {
            ClsPerson Person = new ClsPerson();



            Person.FirstName = "Farah";
            Person.SecondName = "Naif";
            Person.ThirdName = "Eid";
            Person.LastName = "Almoazaini";
            Person.DateOfBirth = DateTime.Today;
            Person.Gender = 1;
            Person.Address = "Naif Road";
            Person.Phone = "98298";
            Person.Email = "";
            Person.NationalityID_FK = 87;
            Person.ImagePath = "";

            if(Person.Save())
            {
                Console.WriteLine("Add New Person Successfuly with id " + Person.PersonID);
            }
        }

        static void DeletePerson(int PersonID)
        {
            if(ClsPerson.DeletePerson(PersonID))
            {
                Console.WriteLine("Deleted With Successfuly");
            }
            else
            {
                Console.WriteLine("Stops ! Error");
            }
        }

        static void UpdatePerson(int PersonID)
        {

            ClsPerson Person = ClsPerson.Find(PersonID);


            Person.NationalNo = "N122";

            if(Person.Save())
            {
                Console.WriteLine("Yes");
            }
        }

        static void PrintAllPersons()
        {
            DataTable data = ClsPerson.GetAllPersons();


            int NumberRow = 1;

            foreach (DataRow row in data.Rows)
            {

                Console.WriteLine("**************************************" + NumberRow + "******************************");
                Console.WriteLine("PersonID: " + row["PersonID"]);
                Console.WriteLine("NationalNo: " + row["NationalNo"]);
                Console.WriteLine("FirstName: " + row["FirstName"]);
                Console.WriteLine("SecondName: " + row["SecondName"]);
                Console.WriteLine("ThirdName: " + row["ThirdName"]);
                Console.WriteLine("LastName: " + row["LastName"]);
                Console.WriteLine("DateOfBirth: " + row["DateOfBirth"]);
                Console.WriteLine("Gendor: " + row["Gendor"]);
                Console.WriteLine("Address: " + row["Address"]);
                Console.WriteLine("Phone: " + row["Phone"]);
                Console.WriteLine("Email: " + row["Email"]);
                Console.WriteLine("NationalityCountryID: " + row["NationalityCountryID"]);
                Console.WriteLine("ImagePath:" + row["ImagePath"]);
                NumberRow++;
                Console.WriteLine("\n\n");
                // To add a line break between rows for better readability }



            }
        }

        static void IsPersonExist(int PersonID)
        {


            if (ClsPerson.IsPersonExsit(PersonID))
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");


        }








        //********************************************************************//


        static void FindUser(string UserName,string Password)
        {
            ClsUser User = ClsUser.FindUserByUserNameAndPassword(UserName,Password);

            if (User != null)
            {



                Console.WriteLine(User.UserID);
                Console.WriteLine(User.PersonID);
                Console.WriteLine(User.UserName);
                Console.WriteLine(User.Password);
                Console.WriteLine(User.IsActive);
          

            }
            else
            {
                Console.WriteLine("N0");
            }

        }

        static void AddNewUser()
        {


            // First Will Serch if Person alrady Exixt //

            ClsPerson Person = ClsPerson.Find(22);



            // if Person not found Will Add Person First //

            if(Person == null)
            {
                 Person = new ClsPerson();

                Person.FirstName = "Huda";
                Person.SecondName = "Naif";
                Person.ThirdName = "Moh";
                Person.LastName = "Almozaini";
                Person.DateOfBirth = DateTime.Now;
                Person.Address = "1n";
                Person.Phone = "850324";
                Person.Email = "Love@gmail.com";
                Person.NationalNo = "N44";
                Person.Gender = 0;
                Person.NationalityID_FK = 159;



                if(Person.Save())
                {
                    Console.WriteLine("Added Person New With ID", Person.PersonID);
                }
            }


            // here Chick if Person not Added if not Will Exixt From Proess;
            if(Person.PersonID == -1)
            {
                return;
            }


            

            ClsUser User = new ClsUser();


            User.UserName = "User10";
            User.Password = "1234";
            User.IsActive = true;
            User.PersonID =  Person.PersonID;



            if(User.Save())
            {
                Console.WriteLine(User.UserID);
            }


        }

        static void UpdateUser(int UserID)
        {
            ClsUser User = ClsUser.FindUserByUserID(UserID);


            User.UserName = "Turki Naif";
            

            if(User.Save())
            {
                Console.WriteLine("Loool");
            }
            

        }

       

        static void FindCountry(int CountryID)
        {
            ClsCountry country = ClsCountry.FindCountry(1);

            if(country != null)
            {
                Console.WriteLine(country.CountryID);
                Console.WriteLine(country.CountryName);
            }
        }


        static void FindCountry(string CountryName)
        {
            ClsCountry country = ClsCountry.FindCountry(CountryName);

            if (country != null)
            {
                Console.WriteLine(country.CountryID);
                Console.WriteLine(country.CountryName);
            }
        }


        static void DeleteUser(int UserID)
        {

            if(ClsUser.DeleteUser(UserID))
            {
                Console.WriteLine("Deleted Succsffuly");
            }
            else
            {
                Console.WriteLine("there wrong");
            }
        }


        static void PrintALlUsers()
        {

            DataTable data = ClsUser.GetAllUsers();


            int NumberRow = data.Rows.Count;

            foreach (DataRow row in data.Rows)
            {

                Console.WriteLine("**************************************" + NumberRow + "******************************");
                Console.WriteLine("UserID: " + row["UserID"]);
                Console.WriteLine("UserName: " + row["UserName"]);
                Console.WriteLine("FullName: " + row["FullName"]);
                Console.WriteLine("\n\n");
                // To add a line break between rows for better readability }



            }

        }


        //*****************************************************//



     



        static void FindLocalApplication(int ID)
        {
            ClsLocalDrivingLicenseApplication localDrivingLicenseApplication = ClsLocalDrivingLicenseApplication.FindLocalDrivingLicenseApplicationInfo(ID);


            if(localDrivingLicenseApplication != null)
            {
                Console.WriteLine(localDrivingLicenseApplication.ApplicantFullName);
            }
        }




        static void Main(string[] args)
        {



            FindLocalApplication(36);
            
            Console.ReadKey();



       }


    }


}
