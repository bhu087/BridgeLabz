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
