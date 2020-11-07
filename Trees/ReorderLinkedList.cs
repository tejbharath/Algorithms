using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class ReorderLinkedList
    {
        public void ReorderList(ListNode head)
        {

            //Input : 1 ->  2 -> 3 -> 4
            //Output : 1 -> 4 -> 3 -> 2
            if (head != null)
            {
                var count = 0;
                ListNode prev = null;
                var curr = head.next;

                while (curr != null)
                {
                        var temp = curr.next;
                        curr.next = prev;
                        prev = curr;
                        curr = temp;
                }

                //Need to assign end to left.next
                head.next = prev;
            }
        }
    }
}
