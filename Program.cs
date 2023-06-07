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

        static void Main(string[] args)
        {
            testFindContact(1);

            Console.ReadKey();
        }
    }
}
