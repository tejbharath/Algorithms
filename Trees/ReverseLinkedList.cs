using System.Collections.Generic;

namespace Trees
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var curr = head;
            var list = new List<ListNode>();
            while (curr.next != null)
            {
                list.Add(curr);
                curr = curr.next;
            }

            // Now curr holds my last node

            head = curr;
            var current = head;
            var i = list.Count - 1;
            while (i >= 0)
            {
                list[i].next = null;
                current.next = list[i];
                current = current.next;
                i--;
            }

            return head;
        }

        public ListNode ReverseListOptimized(ListNode head)
        {
            if (head == null) // 1 -> 2 -> 3 -> 4 -> 5      // 1 <- 2 <- 3 <- 4 <- 5
            {
                return null;
            }

            ListNode prev = null;
            var curr = head;

            while (curr != null)
            {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }


            return prev;
        }

        public ListNode ReverseListStack(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var curr = head;
            var stack = new Stack<ListNode>();

            while (curr.next != null)
            {
                var temp = curr.next;
                curr.next = null;
                stack.Push(curr);
                curr = temp;
            }

            //Holds the last element
            head = curr;
            ListNode current = head;

            while (stack.Count != 0)
            {
                current.next = stack.Pop();
                if (stack.Count != 0)
                {
                    current = current.next;
                }
            }

            return head;
        }
    }
}
