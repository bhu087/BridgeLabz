/////------------------------------------------------------------------------
////<copyright file="CashCounterLogic.cs" company="BridgeLabz">
////author="Bhushan"
////</copyright>
////-------------------------------------------------------------------------

namespace Cash_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Cash_Counter.UtilityForFileOperations;

    /// <summary>
    /// Cash Counter Logic
    /// </summary>
    public class CashCounterLogic
    {
        private Node Head;

        /// <summary>
        /// Create a new Node
        /// </summary>
        /// <returns>return New Node</returns>
        private Node CreateQueue()
        {
            return Head;
        }

        /// <summary>
        /// Add if new customer arrives
        /// </summary>
        /// <param name="name">Customer name</param>
        /// <param name="accountNumber">Account Number</param>
        /// <param name="balance">Customer Balance</param>
        /// <returns>returns status</returns>
        public bool AddToQueue(string name, long accountNumber, int balance)
        {
            Node currentNode = Head;
            Node tempNode = new Node(name, accountNumber, balance);
            if (Head == null)
            {
                Head = tempNode;
                return true;
            }

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = tempNode;
            return true;
        }

        /// <summary>
        /// Delete the customer from front after giving the serve
        /// </summary>
        /// <returns>returns status</returns>
        public bool DeleteFromQueue()
        {
            Node currentNode = Head;
            if (Head == null)
            {
                return false;
            }

            Head = currentNode.Next;
            return true;
        }

        /// <summary>
        /// Display the Queue customers
        /// </summary>
        public void DisplayCustomers()
        {
            Node currentNode = this.Head;
            if (this.IsEmpty())
            {
                return;
            }

            while (currentNode.Next != null)
            {
                Console.WriteLine(currentNode.Name);
                currentNode = currentNode.Next;
            }

            Console.WriteLine(currentNode.Name);
        }

        /// <summary>
        /// Checks weather customer is in queue or not to avoid repeated entries
        /// </summary>
        /// <param name="accountNumber">require account number</param>
        /// <returns>return status</returns>
        public bool IsCustomerInQueue(long accountNumber)
        {
            Node current = this.Head;
            if (this.IsEmpty())
            {
                return false;
            }

            while (current.Next != null)
            {
                if (current.AccountNumber == accountNumber)
                {
                    return true;
                }

                current = current.Next;
            }

            if (current.AccountNumber == accountNumber)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Service to Customer
        /// </summary>
        /// <param name="serviceType">Require service type</param>
        /// <returns>status message</returns>
        public string ServiceToCustomer(string serviceType)
        {
            Node current = this.Head;
            Console.WriteLine("Service is giving to {0}", current.Name);
            AccountControl accountControl = new AccountControl();
            if (serviceType.Equals("Deposit"))
            {
                Console.WriteLine("Enter a Amount to deposit");
                int amount = 0;
                try
                {
                    amount = int.Parse(Console.ReadLine());
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }

                bool status = accountControl.UpdateBalance(current.AccountNumber, amount);
                this.DeleteFromQueue();
                Console.WriteLine("Updated Balance is {0}", current.Balance + amount);
                return "Deposited";
            }

            if (serviceType.Equals("Withdraw"))
            {
                Console.WriteLine("Enter How much amount You want");
                try
                {
                    int requiredAmount = int.Parse(Console.ReadLine());
                    if (current.Balance >= requiredAmount)
                    {
                        bool status = accountControl.UpdateBalance(current.AccountNumber, -requiredAmount);
                        this.DeleteFromQueue();
                        Console.WriteLine("Collect your Cash " + requiredAmount);
                        Console.WriteLine("Updated balance is {0}", current.Balance - requiredAmount);
                        return "Withdraw";
                    }
                    else
                    {
                        this.DeleteFromQueue();
                        return "Insufficient Balance";
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Your balance is {0}", current.Balance);
                this.DeleteFromQueue();
                return null;
            }

            return null;
        }

        /// <summary>
        /// Size of the Queue
        /// </summary>
        /// <returns>length of the Queue</returns>
        public int SizeOfCounter()
        {
            if (this.IsEmpty())
            {
                return 0;
            }

            Node currentNode = this.Head;
            int customerCount = 0;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                customerCount++;
            }

            return customerCount + 1;
        }

        /// <summary>
        /// Checks the empty Queue or not
        /// </summary>
        /// <returns>returns status</returns>
        public bool IsEmpty()
        {
            if (this.Head == null)
            {
                return true;
            }

            return false;
        }
    }
}
