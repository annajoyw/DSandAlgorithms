using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DS.LinkedLists.SinglyLinkedList;

namespace DS.LinkedLists
{
    class TraversingLinkedList
    {
        private Node start;

        public TraversingLinkedList()
        {
            start = null;
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while(p != null)
            {
                n++;
                p = p.next;
            }
        }
            
    }
}
