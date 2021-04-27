using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_Counter
{
    class Node
    {
        public string Name;
        public long AccountNumber;
        public int Balance;
        public Node Next;

        public Node(string name, long accountNumber, int balance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;

        }
    }
}
