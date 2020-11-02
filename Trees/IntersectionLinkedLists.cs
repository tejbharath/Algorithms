using System.Collections.Generic;

namespace Trees
{
    public class IntersectionLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var set = new HashSet<ListNode>();
            var currA = headA;
            var currB = headB;

            while (currA != null || currB != null)
            {
                if (currA != null)
                {
                    if (set.Contains(currA))
                    {
                        return currA;
                    }
                    else
                    {
                        set.Add(currA);
                    }

                    currA = currA.next;
                }

                if (currB != null)
                {
                    if (set.Contains(currB))
                    {
                        return currB;
                    }
                    else
                    {
                        set.Add(currB);
                    }
                    currB = currB.next;
                }
            }

            return null;
        }

        public ListNode GetOptimizedIntersectionNode(ListNode headA, ListNode headB)
        {
            var currA = headA;
            var currB = headB;

            while(currA != currB)
            {
                if(currA == null)
                {
                    currA = headB;
                }
                else
                {
                    currA = currA.next;
                }

                if(currB == null)
                {
                    currB = headA;
                }
                else
                {
                    currB = currB.next;
                }
            }

            return currA;
        }

    }
}
