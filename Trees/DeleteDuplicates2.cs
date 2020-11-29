using System;
using System.Collections.Generic;
using System.Linq;

namespace Trees
{
    public class DeleteDuplicates2
    {
        public void DeleteDuplicates(ListNode head)
        {
            if (!(head == null || head.next == null))
            {
                
                var curr = head;
                var lst = new List<ListNode>();
                var duplicates = new List<ListNode>();

                while (curr != null)
                {

                    var temp = curr.next;

                    curr.next = null;
                    if (!lst.Exists(_ => _.val == curr.val))
                    {
                        lst.Add(curr);
                    }
                    else
                    {
                        duplicates.Add(curr);
                    }

                    curr = temp;
                }

                for (int i = 0; i < lst.Count; i++)
                {
                    if (duplicates.Exists(_ => _.val == lst[i].val))
                    {
                        lst.RemoveAt(i);
                        i = i - 1;
                    }
                }

                ListNode current = null;

                if (lst.Count >= 1)
                {
                    current = lst[0];
                }

                if (lst.Count > 1)
                {
                    for (int i = 1; i < lst.Count; i++)
                    {
                        lst[i - 1].next = lst[i];
                    }
                    current.next = lst[1];
                }

                head = current;
            }
        }
    }
}
