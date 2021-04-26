using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookOperations
    {
        public void AddressOperationsSelcection()
        {
            Console.WriteLine("Enter Options");
            Console.WriteLine("1 for Add Person");
            Console.WriteLine("2 for Delete Person");
            Console.WriteLine("3 for Edit Person");
            Console.WriteLine("4 for Display Contacts");
            Console.WriteLine("5 for sorted display");
            try
            {
                int option = int.Parse(Console.ReadLine());
                AddressBookLogic addressBookLogic = new AddressBookLogic();
                switch (option)
                {
                    case 1:
                        addressBookLogic.AddContact();
                        break;
                    case 2:
                        addressBookLogic.DeleteContact();
                        break;
                    case 3:
                        addressBookLogic.EditContact();
                        break;
                    case 4:
                        addressBookLogic.PrintContacts();
                        break;
                    case 5:
                        addressBookLogic.SortByName();
                        break;
                    default:
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
