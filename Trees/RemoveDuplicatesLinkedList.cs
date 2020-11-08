using System.Collections.Generic;

namespace Trees
{
    public class RemoveDuplicatesLinkedList
    {
        public void RemoveDuplicates(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            var set = new HashSet<int>();

            while (curr != null)
            {

                if (!set.Contains(curr.val))
                {
                    set.Add(curr.val);
                }
                else
                {
                    var next = curr.next;
                    prev.next = curr.next;
                    curr.next = null;
                    curr = next;
                    continue;
                }
                prev = curr;
                curr = curr.next;
            }
        }
    }
}
