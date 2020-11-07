using System;
using System.Collections.Generic;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            LevelOrderTraversal t = new LevelOrderTraversal();
            t.BuildTree();
            var lst = t.BreadFirstTraversal();
            PrintList(lst);

            //LinkedList link = new LinkedList();
            //var head = link.AddNode(1);
            //var second = link.AddNode(2);
            //var third = link.AddNode(3);
            //var fourth = link.AddNode(4);
            //fourth.next = second;
            //CycledLinkedList c = new CycledLinkedList();
            //Console.WriteLine(c.OptimizedHasCycle(head));

            //LinkedList link = new LinkedList();
            //var head = link.AddNode(1);
            //link.AddNode(2);
            //link.AddNode(3);
            //link.AddNode(4);
            //link.AddNode(5);
            //link.PrintAllListNodes();

            //ReorderLinkedList r = new ReorderLinkedList();
            //r.ReorderList(head);
            //link.PrintAllListNodes();

            //ReverseLinkedListRange r = new ReverseLinkedListRange();
            //r.ReverseBetween(head, 2, 4);
            //link.PrintAllListNodes();

        }

        private static void PrintList(List<int> nums)
        {
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
