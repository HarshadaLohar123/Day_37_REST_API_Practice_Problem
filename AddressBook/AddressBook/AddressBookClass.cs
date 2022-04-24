using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Person
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public int PostalCode;
        public long PhoneNumber;
        public string Email;

        public string Result()
        {
            return "\nName is: " + First_Name + " " + Last_Name + "\nAddress: " + Address + "\nCity is " + City +
                "\nState is " + State + "\nPostal code is: " + PostalCode + "\nPhone: " + PhoneNumber + "\nEmail is " + Email;
        }
    }
    public class AddressBookClass
    {
        public List<Person> person = new List<Person>();

        public void Display()
        {
            Console.WriteLine("\nAddressBook is: ");
            foreach (Person per in person)
            {
                Console.WriteLine(per.Result());
            }
        }

        public void addPerson(Person p)
        {
            person.Add(p);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\Bridgelabz\Visual Studio Assignment\Day-37-Practice-Problem\AddressBook\AddressBook\ContactDetail.json", jsonData);
        }

        public AddressBookClass()
        {
            string json = File.ReadAllText(@"D:\Bridgelabz\Visual Studio Assignment\Day-37-Practice-Problem\AddressBook\AddressBook\ContactDetail.json");
            if (json.Length > 0)
            {
                person = JsonConvert.DeserializeObject<List<Person>>(json);
            }
            else
                person = new List<Person>();
        }

        public void EditPerson(string First_Name)
        {
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].First_Name == First_Name)
                {
                    Console.WriteLine("Enter First Name: ");
                    person[i].First_Name = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    person[i].Last_Name = Console.ReadLine();
                    Console.WriteLine("Enter Address ");
                    person[i].Address = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    person[i].City = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    person[i].State = Console.ReadLine();
                    Console.WriteLine("Enter pin code: ");
                    person[i].PostalCode = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number: ");
                    person[i].PhoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Email id: ");
                    person[i].Email = Console.ReadLine();
                }
            }
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\Bridgelabz\Visual Studio Assignment\Day-37-Practice-Problem\AddressBook\AddressBook\ContactDetail.json", jsonData);
        }

        public void Remove(string First_Name)
        {
            Person pers = null;
            foreach (Person p in person)
            {
                if (p.First_Name == First_Name)
                {
                    pers = p;
                }
            }
            person.Remove(pers);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\Bridgelabz\Visual Studio Assignment\Day-37-Practice-Problem\AddressBook\AddressBook\ContactDetail.json", jsonData);
        }
    }
}
