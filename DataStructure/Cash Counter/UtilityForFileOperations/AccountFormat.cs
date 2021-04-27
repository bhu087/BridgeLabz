/////------------------------------------------------------------------------
////<copyright file="AccountFormat.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------

namespace Cash_Counter.UtilityForFileOperations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Account Model
    /// </summary>
    public class AccountFormat
    {
        /// <summary>
        /// Gets and sets the value Name in the Account Model
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// gets and sets the value Account Number in Model 
        /// </summary>
        public long AccountNumber { get; set; }

        /// <summary>
        /// gets and sets the value Balance in Model 
        /// </summary>
        public int Balance { get; set; }
    }
}
