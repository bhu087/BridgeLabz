using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cash_Counter.UtilityForFileOperations
{
    class AccountControl
    {
        public static string AccountFile = File.ReadAllText(@"I:\BridgeLabz\DataStructure\Cash Counter\Accounts\AccountList.json");
        public static AccountList accountList = JsonConvert.DeserializeObject<AccountList>(AccountFile);
        public static List<AccountFormat> accountFormat = accountList.Accounts;

        public CustomerDetails GetCustomer(long AccountNumber)
        {
            CustomerDetails customerDetails;
            foreach (AccountFormat account in accountFormat)
            {
                if (account.AccountNumber == AccountNumber)
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
    }
}
