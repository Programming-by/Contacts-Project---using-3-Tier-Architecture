using System;
using System.Data;
using ContactsBusinessLayer;


namespace ContactsConsoleApp___Presentation_Layer
{
    internal class Program
    {
        public static void testFindContact(int ID)
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

        public static void testAddNewContact()
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

        public static void testUpdateContact(int ID)
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


        static void Main(string[] args)
        {
            //  testFindContact(2);
            //testAddNewContact();
            testUpdateContact(1);


            Console.ReadKey();
        }
    }
}
