/////------------------------------------------------------------------------
////<copyright file="Node.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------

namespace Cash_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Node
    /// </summary>
    class Node
    {
        public string Name;
        public long AccountNumber;
        public int Balance;
        public Node Next;

        /// <summary>
        /// Constructure
        /// </summary>
        /// <param name="name">require name</param>
        /// <param name="accountNumber">require account number</param>
        /// <param name="balance">require balance</param>
        public Node(string name, long accountNumber, int balance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
}
