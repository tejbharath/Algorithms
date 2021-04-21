namespace Trees
{
    public class ReverseLinkedListRange
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            var curr = head;
            ListNode left = null;
            ListNode right = null;
            ListNode start = null;
            ListNode end = null;
            ListNode prev = null;
            var count = 0;
            
            while (curr != null)   // {1, 2, 3, 4, 5}
            {
                count++; 

                if (count > m && count <= n)
                {

                    if (count == n)
                    {
                        end = curr; 
                        right = curr.next;
                    }
                    ListNode temp = curr.next;  
                    curr.next = prev;  
                    prev = curr;  
                    curr = temp; 
                }
                else
                {
                    if (count == m)
                    {
                        start = curr;  
                        left = prev; 
                    }
                    
                    prev = curr;
                    curr = curr.next; 
                }
            }

            left.next = end;
            start.next = right;

            return head;
        }
    }
}
