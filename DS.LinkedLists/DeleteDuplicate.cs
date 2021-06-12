using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.LinkedLists
{
    class DeleteDuplicate
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;

            var set = new HashSet<int>();

            var current = head;
            var dummyHead = new ListNode(-1);

            var previous = dummyHead;
            dummyHead.next = current;
            while(current != null)
            {
                var value = current.val;
                if (set.Contains(value))
                {
                    previous.next = current.next; //remove current node from list
                    current = current.next; //next iteration
                }
                else
                {
                    set.Add(value);
                    previous = current;
                    current = current.next;
                }
            }
            return dummyHead.Next;
        }
    }
}
