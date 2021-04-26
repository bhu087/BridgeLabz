﻿using System;
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
            try
            {
                int option = int.Parse(Console.ReadLine());
                AddressBookLogic addressBookLogic = new AddressBookLogic();
                addressBookLogic.AddContact();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
