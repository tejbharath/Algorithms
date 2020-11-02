using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            //InOrderTraversal t = new InOrderTraversal();
            //t.BuildTree();
            //t.Traverse();

            LinkedList link = new LinkedList();
            var head = link.AddNode(1);
            var second = link.AddNode(2);
            var third = link.AddNode(3);
            var fourth = link.AddNode(4);
            fourth.next = second;
            CycledLinkedList c = new CycledLinkedList();
            Console.WriteLine(c.OptimizedHasCycle(head));

        }
    }
}
