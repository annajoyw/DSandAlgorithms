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

            var newHead = new ListNode(0); // dummy list to add values to
            var runnerHead = newHead;        // pointer to beginning of list

            while (l1 != null && l2 != null) //while we have two lists do the following:
            {
                if (l1.val >= l2.val) //compares values of nodes
                {
                    runnerHead.next = l2; //take this element, put in in our list and move forward 
                    l2 = l2.next; //move pointer forward so we no longer see the current value in out next iteration
                }
                else //same thing as lines above but for if the value is l1 < l2
                {
                    runnerHead.next = l1;
                    l1 = l1.next;
                }

                runnerHead = runnerHead.next; //we got our element, this line moves the pointer to the next element
            }

            // this checks and adds the 'leftover' from the while loop at the end of our list
            if (l1 != null) runnerHead.next = l1;
            if (l2 != null) runnerHead.next = l2;

            return newHead.next;
        }
    }
}
