using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    class AddressBookLogic
    {
        public static string AddsBook = File.ReadAllText(@"I:\BridgeLabz\Logical Programs\AddressBook\AddressBook\AddressJSON.json");
        public static AddressList AddsList = JsonConvert.DeserializeObject<AddressList>(AddsBook);
        public static List<AddressBookObject> AddsObject = AddsList.AddressBookContents;

        public void AddContact()
        {
            Console.WriteLine("Enter a Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a Mobile Number");
            long number = long.Parse(Console.ReadLine());
            if (this.DuplicateNumber(number))
            {
                Console.WriteLine("Contact already exixts try with new Number");
                AddContact();
            }
            Console.WriteLine("Enter a Company Name");
            string company = Console.ReadLine();
            AddressBookObject addressBookObject = new AddressBookObject{
                Name = name,
                MobileNumber = number,
                Company = company
            };
            AddsObject.Add(addressBookObject);
            string output = JsonConvert.SerializeObject(AddsList, Formatting.Indented);
            File.WriteAllText(@"I:\BridgeLabz\Logical Programs\AddressBook\AddressBook\AddressJSON.json", output);
        }
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
        public bool DuplicateNumber(long number)
        {
            foreach (AddressBookObject contacts in AddsObject)
            {
                if (contacts.Name.Equals(number))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
