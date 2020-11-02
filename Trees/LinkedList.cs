using System;

namespace Trees
{
    public class LinkedList 
    {
        public ListNode head;

        public ListNode AddNode(int val)
        {
            if(head == null)
            {
                head = new ListNode(val);
                return head;
            }
            
            ListNode curr = head;
            while(curr.next != null)
            {
                curr = curr.next;
            }

            curr.next = new ListNode(val);

            return curr.next;
        }

        public ListNode GetNode(int value)
        {
            ListNode curr = head;
            while (curr != null)
            {
                if (curr.val == value)
                {
                    return curr;
                }
                curr = curr.next;
            }
            return null;
        }

        public void DeleteNode(int value)
        {
            if (head.val == value) {
                head = head.next;
            }

            ListNode curr = head;
                  
            while (curr != null && curr.next != null)
            {
                if(curr.next.val == value)
                {
                  curr.next = curr.next.next;
                  return;
                }
                curr = curr.next;
            }
        }

        public void PrintAllListNodes()
        {
            ListNode curr = head;

            while (curr != null)
            {
                Console.WriteLine(curr.val);
                curr = curr.next;
            }
            Console.WriteLine();
        }        
    }
}
