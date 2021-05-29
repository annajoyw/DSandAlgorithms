using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.LinkedLists
{
    class MergreSortedLinkedLists
    {

            public class ListNode
            {
                public int val;
                public ListNode next;
                public ListNode(int x) { val = x; }
             }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            // Validations
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            var newHead = new ListNode(0); // Creating this dummy node ease the logic
            var runnerHead = newHead;        // This is the runner node

            while (l1 != null && l2 != null)
            {
                if (l1.val >= l2.val)
                {
                    runnerHead.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    runnerHead.next = l1;
                    l1 = l1.next;
                }

                runnerHead = runnerHead.next;
            }

            // Simply add the 'leftover' from the while loop at the end 
            if (l1 != null) runnerHead.next = l1;
            if (l2 != null) runnerHead.next = l2;

            return newHead.next;
        }
    }
}
