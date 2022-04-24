using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to address book problem ");
            AddressBookClass ad = new AddressBookClass();
            while (true)
            {
                Console.WriteLine("\nSelect Any one Operation: ");
                Console.WriteLine("1. To Add New Person: ");
                Console.WriteLine("2. To Display Contacts: ");
                Console.WriteLine("3. To Update Contacts: ");
                Console.WriteLine("4. To Delete Contacts: ");
                int read = int.Parse(Console.ReadLine());
                switch (read)
                {
                    case 1:
                        Person person = new Person();
                        Console.WriteLine("Enter First Name: ");
                        string fname = Console.ReadLine();
                        person.First_Name = fname;
                        Console.WriteLine("Enter Last Name: ");
                        string lname = Console.ReadLine();
                        person.Last_Name = lname;
                        Console.WriteLine("Enter Address ");
                        string address = Console.ReadLine();
                        person.Address = address;
                        Console.WriteLine("Enter City: ");
                        string city = Console.ReadLine();
                        person.City = city;
                        Console.WriteLine("Enter State: ");
                        string state = Console.ReadLine();
                        person.State = state;
                        Console.WriteLine("Enter pin code: ");
                        int pin = int.Parse(Console.ReadLine());
                        person.PostalCode = pin;
                        Console.WriteLine("Enter Phone Number: ");
                        long number = long.Parse(Console.ReadLine());
                        person.PhoneNumber = number;
                        Console.WriteLine("Enter Email id: ");
                        string email = Console.ReadLine();
                        person.Email = email;
                        ad.addPerson(person);
                        break;

                    case 2:
                        ad.Display();
                        break;

                    case 3:
                        Console.WriteLine("Please enter the First name to Update that contact: ");
                        string uname = Console.ReadLine();
                        ad.UpdatePerson(uname);
                        break;

                    case 4:
                        Console.WriteLine("Please enter the firat name to delete that contact: ");
                        string dname = Console.ReadLine();
                        ad.Remove(dname);
                        break;

                    default:
                        Console.WriteLine("Please select valid input: ");
                        break;
                }
            }
        }
    }
}
