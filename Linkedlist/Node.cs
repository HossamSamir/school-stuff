using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    class Node
    {
        public string Data;
        public Node next;
        public Node(string Data)
        {
            this.Data = Data;
            next = null;
        }
        public void AddToEnd(string Data)
        {
            if (next == null)
                next = new Node(Data);
            else
            {
                next.AddToEnd(Data);
            }
        }
        public void print()
        {
            Console.WriteLine(Data);
            if (next != null)
                next.print();
        }
    }
}
