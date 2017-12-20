using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    class List {
        Article Head;
        public List()
        {
            Head = null;
        }
        public void AddToEnd(string title, string keyword)
        {
            if (Head == null)
                Head = new Article(title, keyword);
            else
            {
                Head.AddToEnd(title, keyword);
            }
        }
        public void print()
        {
            if (Head != null)
                Head.print();
        }

    }
}
