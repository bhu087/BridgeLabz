/////------------------------------------------------------------------------
////<copyright file="AddressBookLogic.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------
namespace AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Address Book Logic
    /// </summary>
    public class AddressBookLogic
    {
        /// <summary>
        /// Address Book read from file
        /// </summary>
        public static string AddsBook = File.ReadAllText(@"I:\BridgeLabz\Logical Programs\AddressBook\AddressBook\AddressJSON.json");
        
        /// <summary>
        /// Address List Deserialized object
        /// </summary>
        public static AddressList AddsList = JsonConvert.DeserializeObject<AddressList>(AddsBook);

        /// <summary>
        /// Address Objects List
        /// </summary>
        public static List<AddressBookObject> AddsObject = AddsList.AddressBookContents;

        /// <summary>
        /// Add contact Logic
        /// </summary>
        public void AddContact()
        {
            Console.WriteLine("Enter a Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a Mobile Number");
            long number = long.Parse(Console.ReadLine());
            if (this.DuplicateNumber(number))
            {
                Console.WriteLine("Contact already exixts try with new Number");
                this.AddContact();
            }

            Console.WriteLine("Enter a Company Name");
            string company = Console.ReadLine();
            AddressBookObject addressBookObject = new AddressBookObject {
                Name = name,
                MobileNumber = number,
                Company = company
            };
            AddsObject.Add(addressBookObject);
            string output = JsonConvert.SerializeObject(AddsList, Formatting.Indented);
            File.WriteAllText(@"I:\BridgeLabz\Logical Programs\AddressBook\AddressBook\AddressJSON.json", output);
        }

        /// <summary>
        /// Delete Contact Logic
        /// </summary>
        public void DeleteContact()
        {
            int i = 0;
            foreach (AddressBookObject contacts in AddsObject)
            {
                Console.WriteLine("Enter {0} for delete {1}", i, contacts.Name);
                i += 1;
            }

            i = int.Parse(Console.ReadLine());
            AddsObject.RemoveAt(i);
            string output = JsonConvert.SerializeObject(AddsList, Formatting.Indented);
            File.WriteAllText(@"I:\BridgeLabz\Logical Programs\AddressBook\AddressBook\AddressJSON.json", output);
        }

        /// <summary>
        /// Edit Contact
        /// </summary>
        public void EditContact()
        {
            int i = 0;
            foreach (AddressBookObject contacts in AddsObject)
            {
                Console.WriteLine("Enter {0} for eidt {1}", i, contacts.Name);
                i += 1;
            }

            i = int.Parse(Console.ReadLine());
            AddsObject.RemoveAt(i);
            Console.WriteLine("Enter Rename");
            string name = Console.ReadLine();
            Console.WriteLine("Enter new Mobile Number");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Company");
            string company = Console.ReadLine();
            AddressBookObject addressBookObject = new AddressBookObject
            {
                Name = name,
                MobileNumber = number,
                Company = company
            };
            AddsObject.Add(addressBookObject);
            string output = JsonConvert.SerializeObject(AddsList, Formatting.Indented);
            File.WriteAllText(@"I:\BridgeLabz\Logical Programs\AddressBook\AddressBook\AddressJSON.json", output);
        }

        /// <summary>
        /// Duplicate Number Finder
        /// </summary>
        /// <param name="number">Entered Number</param>
        /// <returns>returns the presence of the Number</returns>
        public bool DuplicateNumber(long number)
        {
            foreach (AddressBookObject contacts in AddsObject)
            {
                if (contacts.MobileNumber.Equals(number))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Print all contacts in Address book
        /// </summary>
        public void PrintContacts()
        {
            Console.WriteLine("Name \t|\tNumber \t|\tCompany :");
            foreach (AddressBookObject contacts in AddsObject)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", contacts.Name, contacts.MobileNumber, contacts.Company);
            }
        }

        /// <summary>
        /// Sort by Name
        /// </summary>
        public void SortByName()
        {
            List<string> sortContacts = new List<string>();
            foreach (AddressBookObject contacts in AddsObject)
            {
                string entries = contacts.Name + "\t\t" + contacts.MobileNumber + "\t\t" + contacts.Company;
                sortContacts.Add(entries);
            }

            sortContacts.Sort();
            foreach (string contacts in sortContacts)
            {
                Console.WriteLine(contacts);
            }
        }
    }
}
