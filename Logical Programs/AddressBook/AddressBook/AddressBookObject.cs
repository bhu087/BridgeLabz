/////------------------------------------------------------------------------
////<copyright file="AddressBookObject.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------

namespace AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Object for Address Book
    /// </summary>
    public class AddressBookObject
    {
        /// <summary>
        /// Property Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Mobile number property
        /// </summary>
        public long MobileNumber { get; set; }

        /// <summary>
        /// Company property
        /// </summary>
        public string Company { get; set; }
    }
}
