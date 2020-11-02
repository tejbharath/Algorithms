using System.Collections.Generic;

namespace Trees
{
    public class CycledLinkedList
    {
        public bool HasCycle(ListNode head)
        {
            var set = new HashSet<ListNode>();

            var curr = head;
            
            while (curr != null)
            {

                if (!set.Contains(curr))
                {
                    set.Add(curr);
                }
                else
                {
                    return true;
                }

                curr = curr.next;
            }

            return false;
        }

        public bool OptimizedHasCycle(ListNode head) // O(1) space complexity - O(n2) Time 
        {
            var slow = head;
            var fast = head.next;
                        
            while (slow != fast) // 1, 2, 3, 4, 2
            {
                if(fast == null || fast.next == null)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
    }
}
