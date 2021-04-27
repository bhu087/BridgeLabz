/////------------------------------------------------------------------------
////<copyright file="CustomerDetails.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------

namespace Cash_Counter.UtilityForFileOperations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Customer Details
    /// </summary>
    public class CustomerDetails
    {
        /// <summary>
        /// Gets and sets Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets and sets Account Number
        /// </summary>
        public long AccountNumber { get; set; }

        /// <summary>
        /// Gets and sets Balance
        /// </summary>
        public int Balance { get; set; }

        /// <summary>
        /// Gets and sets registration details of customer
        /// </summary>
        public bool IsRegisteredCustomer { get; set; }
    }
}
