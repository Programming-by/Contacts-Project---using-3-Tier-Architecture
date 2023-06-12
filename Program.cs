using System;
using System.Data;
using ContactsBusinessLayer;
using CountriesBusinessLayer;

namespace ContactsConsoleApp___Presentation_Layer
{
    internal class Program
    {
        //------------------Country Business-------------------//

        static void testFindCountryByID(int ID)
        {
            clsCountry Country = clsCountry.Find(ID);
            if (Country != null) { 

            Console.WriteLine(Country.CountryName);

            } else
            {
                Console.WriteLine("Country with [" + ID + "] Not found");

            }
        }


        static void testFindCountryByName(string CountryName)
        {

            clsCountry Country = clsCountry.Find(CountryName);

            if (Country != null)
            {
                Console.WriteLine("Country [" + Country.CountryName + "] is Found with ID = " + Country.ID);

            } else
            {
                Console.WriteLine("Country [" + Country.CountryName + "] is Not Found");

            }
        }

        static void testIsCountryExistByID(int ID)
        {

            if (clsCountry.IsCountryExist(ID))

                Console.WriteLine("Yes, Country is there");

             else  
                
                Console.WriteLine("No, Country is not there");

        }

        static void testIsCountryExistByName(string CountryName)
        {
            if (clsCountry.IsCountryExist(CountryName))

                Console.WriteLine("Yes, Country is there");

            else
                Console.WriteLine("No, Country is Not there");
        }

        static void testAddNewCountry()
        {
            clsCountry Country = new clsCountry();

            Country.CountryName = "Jordan";

            if (Country.Save())
            {
                Console.WriteLine("Country Added Successfully with id=" + Country.ID);
            }


        }
       
        
        static void testUpdateCountry(int ID)
        {
            clsCountry Country = clsCountry.Find(ID);

            if (Country != null)
            {
            Country.CountryName = "USA";

            if (Country.Save())
            {
                Console.WriteLine("Country updated Successfully ");
            } else
            {
                Console.WriteLine("Country is you want to update is Not found!");

            }

            }

        }
       
        
        static void testDeleteCountry(int ID)
        {
            if (clsCountry.IsCountryExist(ID))

                if (clsCountry.DeleteCountry(ID))

                    Console.WriteLine("Country Deleted Successfully.");

                else
                    Console.WriteLine("Failed to Delete");

            else
                Console.WriteLine("Faild to delete: The Country with id = " + ID + " is not found");

        }


        static void ListCountries()
        {
            DataTable dataTable = clsCountry.GetAllCountries();

            Console.WriteLine("Countries Data:");

            foreach( DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["CountryID"]} , {row["CountryName"]}");
            }

        }


        //------------------Contact Business-------------------//
         static void testFindContact(int ID)
        {

            Contact Contact1 = Contact.Find(ID);

            if (Contact1 != null)
            {

                Console.WriteLine(Contact1.FirstName + " " + Contact1.LastName);
                Console.WriteLine(Contact1.Email);
                Console.WriteLine(Contact1.Phone);
                Console.WriteLine(Contact1.Address);
                Console.WriteLine(Contact1.DateOfBirth);
                Console.WriteLine(Contact1.CountryID);
                Console.WriteLine(Contact1.ImagePath);

            } else {

                Console.WriteLine("Contact with [" + ID + "] is not Found");

                  }



        }

         static void testAddNewContact()
        {
            Contact Contact1 = new Contact();

            Contact1.FirstName = "Anas";
            Contact1.LastName = "Naamneh";
            Contact1.Email = "naamneh.anas@gmail.com";
            Contact1.Phone = "07888888";
            Contact1.Address = "Amman";
            Contact1.DateOfBirth = new DateTime(1977,11,6,10,30,0);
            Contact1.CountryID = 1;
            Contact1.ImagePath = "";

            if (Contact1.Save())
            {
                Console.WriteLine("Contact Added Successfully with id=" + Contact1.ID);
            }


        }

         static void testUpdateContact(int ID)
        {
            Contact Contact1 = Contact.Find(ID);

            Contact1.FirstName = "Mohammed";
            Contact1.LastName = "Ahmad";
            Contact1.Email = "Moh.Ahmad@gmail.com";
            Contact1.Phone = "07999999";
            Contact1.Address = "Irbid";
            Contact1.DateOfBirth = new DateTime(1995, 1, 5, 5, 24, 0);
            Contact1.CountryID = 1;
            Contact1.ImagePath = "";

            if (Contact1.Save())
            {
                Console.WriteLine("Contact Updated Successfully with id=" + Contact1.ID);
            }


        }

         static void testDeleteContact(int ID)
        {
            if (Contact.IsContactExist(ID))

                if (Contact.DeletContact(ID))
                {
                    Console.WriteLine("Contact Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Contact Failed To Delete");

                }
            else
                Console.WriteLine("The Contact with Contact id = " +  ID + " is not found");



        }

        static void ListContacts()
        {
            DataTable dataTable = Contact.GetAllContacts();

            Console.WriteLine("Contacts Data");

            foreach(DataRow row in dataTable.Rows)
            {

                Console.WriteLine($"{ row["ContactID"]}, {row["FirstName"]} {row["LastName"]} ");
            }


        }


        static void testIsContactExist(int ID)
        {
            if (Contact.IsContactExist(ID))
            {
                Console.WriteLine("Yes, Contact is there");
            } else
            {
                Console.WriteLine("No, Contact is not there");

            }

        }

        static void Main(string[] args)
        {
             testFindCountryByID(2);
            // testFindCountryByName("USA");
           //  testIsCountryExistByID(100);
           //  testIsCountryExistByName("USA");
            // testAddNewCountry();
            // testUpdateCountry(8);
            // testDeleteCountry(6);
           //  ListCountries();


            //  testFindContact(2);
            //testAddNewContact();
            // testUpdateContact(1);
            //testDeleteContact(9);
            //ListContacts();


            //testIsContactExist(1);


            Console.ReadKey();
        }
    }
}
