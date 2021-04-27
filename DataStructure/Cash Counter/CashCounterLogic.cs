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

        public bool AddToQueue(string name)
        {
            Node currentNode = head;
            Node tempNode = new Node(name);
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
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
            Console.WriteLine(currentNode.Data);
        }

        public bool IsCustomerInQueue(string name)
        {
            Node current = head;
            if (IsEmpty())
            {
                return false;
            }
            while (current.Next != null)
            {
                if (current.Data == name)
                {
                    return true;
                }
                current = current.Next;
            }
            if (current.Data == name)
            {
                return true;
            }
            return false;
        }

        public string ServiceToCustomer(string serviceType)
        {
            if (serviceType.Equals("Deposit"))
            {
                return "Deposited";
            }
            if (serviceType.Equals("Withdraw"))
            {
                return "over";
            }
            else
            {
                return "Balance";
            }
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
