using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_Counter
{
    class Node
    {
        public string Data;
        public Node Next;

        public Node(string name)
        {
            Data = name;
        }
    }
}
