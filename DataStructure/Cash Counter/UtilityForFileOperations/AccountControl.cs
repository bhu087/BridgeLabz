/////------------------------------------------------------------------------
////<copyright file="AccountControl.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------

namespace Cash_Counter.UtilityForFileOperations
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Account Control Class
    /// </summary>
    public class AccountControl
    {
        /// <summary>
        /// account details in file format
        /// </summary>
        private static string accountFile = File.ReadAllText(@"I:\BridgeLabz\DataStructure\Cash Counter\Accounts\AccountList.json");

        /// <summary>
        /// deserialize the object
        /// </summary>
        private static AccountList accountList = JsonConvert.DeserializeObject<AccountList>(accountFile);

        /// <summary>
        /// List of Accounts
        /// </summary>
        private static List<AccountFormat> accountFormat = accountList.Accounts;

        /// <summary>
        /// Gets the customer Details
        /// </summary>
        /// <param name="accountNumber">Account number of customer</param>
        /// <returns>Customer Model</returns>
        public CustomerDetails GetCustomer(long accountNumber)
        {
            CustomerDetails customerDetails;
            foreach (AccountFormat account in accountFormat)
            {
                if (account.AccountNumber == accountNumber)
                {
                    customerDetails = new CustomerDetails
                    {
                        Name = account.Name,
                        AccountNumber = account.AccountNumber,
                        Balance = account.Balance,
                        IsRegisteredCustomer = true
                    };
                    return customerDetails;
                }
            }

            customerDetails = new CustomerDetails
            {
                IsRegisteredCustomer = false
            };
            return customerDetails;
        }

        /// <summary>
        /// Update the balance of front customer in Queue
        /// </summary>
        /// <param name="accountNumber">Account number of Customer</param>
        /// <param name="amount">Name of customer</param>
        /// <returns>returns status</returns>
        public bool UpdateBalance(long accountNumber, int amount)
        {
            foreach (AccountFormat account in accountFormat)
            {
                if (account.AccountNumber == accountNumber)
                {
                    account.Balance += amount;
                    string output = JsonConvert.SerializeObject(accountList, Formatting.Indented);
                    try
                    {
                        File.WriteAllText(@"I:\BridgeLabz\DataStructure\Cash Counter\Accounts\AccountList.json", output);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    return true;
                }
            }
            
            return false;
        }
    }
}
