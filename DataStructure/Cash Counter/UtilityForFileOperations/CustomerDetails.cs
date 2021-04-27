using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_Counter.UtilityForFileOperations
{
    class CustomerDetails
    {
        public string Name { set; get; }
        public long AccountNumber { set; get; }
        public int Balance { set; get; }
        public bool IsRegisteredCustomer { set; get; }
    }
}
