using System;
using System.Data;
using ContactsBusinessLayer;


namespace ContactsConsoleApp___Presentation_Layer
{
    internal class Program
    {
         static void testFindContact(int ID)
        {

            clsContacts Contact1 = clsContacts.Find(ID);

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
            clsContacts Contact1 = new clsContacts();

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
            clsContacts Contact1 = clsContacts.Find(ID);

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
            if (clsContacts.IsContactExist(ID))

                if (clsContacts.DeletContact(ID))
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
            DataTable dataTable = clsContacts.GetAllContacts();

            Console.WriteLine("Contacts Data");

            foreach(DataRow row in dataTable.Rows)
            {

                Console.WriteLine($"{ row["ContactID"]}, {row["FirstName"]} {row["LastName"]} ");
            }


        }


        static void testIsContactExist(int ID)
        {
            if (clsContacts.IsContactExist(ID))
            {
                Console.WriteLine("Yes, Contact is there");
            } else
            {
                Console.WriteLine("No, Contact is not there");

            }

        }

        static void Main(string[] args)
        {
            //  testFindContact(2);
            //testAddNewContact();
            // testUpdateContact(1);
            testDeleteContact(9);

            //ListContacts();

            //testIsContactExist(1);


            Console.ReadKey();
        }
    }
}
