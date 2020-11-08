using System.Collections.Generic;

namespace Trees
{
    public class ReorderLinkedList
    {
        public void ReorderList(ListNode head)
        {

                var queue = new Queue<ListNode>();
                var stack = new Stack<ListNode>();

                var curr = head;
                var count = 0;
                while (curr != null)
                {
                    count++;
                    curr = curr.next;
                }

                ListNode currentNode = head;

                var i = 0;
                while (i < count / 2)
                {
                    var temp = currentNode.next;
                    currentNode.next = null;
                    queue.Enqueue(currentNode);
                    currentNode = temp;
                    i++;
                }

                ListNode oddNode = null;
                if (count % 2 != 0)
                {
                    oddNode = currentNode;
                    currentNode = currentNode.next;
                }

                while (currentNode != null)
                {
                    var tempNode = currentNode.next;
                    currentNode.next = null;
                    stack.Push(currentNode);
                    currentNode = tempNode;
                }

                ListNode returnNode = queue.Count != 0 ? queue.Dequeue() : null;
                var current = returnNode;
                while (queue.Count != 0 && stack.Count != 0)
                {
                    current.next = stack.Pop();
                    current.next.next = queue.Dequeue();
                    current = current.next.next;
                }

                current.next = stack.Pop();
                

                if (oddNode != null)
                {
                    oddNode.next = null;
                    current.next.next = oddNode;
                }

                head = returnNode;

            }
        }
}
