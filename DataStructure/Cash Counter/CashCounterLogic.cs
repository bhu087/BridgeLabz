using Cash_Counter.UtilityForFileOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_Counter
{
    class CashCounterLogic
    {
        Node head;
        public Node CreateQueue()
        {
            return head;
        }

        public bool AddToQueue(string name, long accountNumber, int balance)
        {
            Node currentNode = head;
            Node tempNode = new Node(name, accountNumber, balance);
            if (head == null)
            {
                head = tempNode;
                return true;
            }
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = tempNode;
            return true;
        }

        public bool DeleteFromQueue()
        {
            Node currentNode = head;
            if (head == null)
            {
                return false;
            }
            head = currentNode.Next;
            return true;
        }

        public void DisplayCustomers()
        {
            Node currentNode = head;
            if (IsEmpty())
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

        public bool IsCustomerInQueue(long accountNumber)
        {
            Node current = head;
            if (IsEmpty())
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

        public string ServiceToCustomer(string serviceType)
        {

            Node current = head;
            Console.WriteLine("Service is giving to {0}", current.Name);
            AccountControl accountControl = new AccountControl();
            CustomerDetails customerDetails = new CustomerDetails();
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
                return "Deposited";
            }
            if (serviceType.Equals("Withdraw"))
            {
                Console.WriteLine("Enter How much amount You want");
                try
                {
                    int requiredAmount = int.Parse(Console.ReadLine());
                    if (current.Balance >= requiredAmount )
                    {
                        bool status = accountControl.UpdateBalance(current.AccountNumber, (-requiredAmount));
                        this.DeleteFromQueue();
                        Console.WriteLine("Collect your Cash " + requiredAmount);
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
                this.DeleteFromQueue();
                return null;
            }
            return null;
        }

        public int SizeOfCounter()
        {
            if (this.IsEmpty())
            {
                return 0;
            }
            Node currentNode = head;
            int customerCount = 0;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                customerCount++;
            }
            return customerCount + 1;
        }
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }
    }
}
