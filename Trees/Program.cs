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
            //SymmetryTreeIterative s = new SymmetryTreeIterative();
            //Console.WriteLine(s.IsSymmetric(t.root));
            //RightSideView r = new RightSideView();
            //var list = r.RightView(t.root);
            //PrintList(list.ToList());
            //var lst = t.BreadFirstTraversal();
            //PrintList(lst);

            //Cousins c = new Cousins(); 
            //c.BuildTree();
            //Console.WriteLine(c.IsCousins(2, 4));


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
            //link.AddNode(2);
            //Console.WriteLine("Original LinkedList");
            //link.PrintAllListNodes();

            //DeleteDuplicates2 d = new DeleteDuplicates2();
            //d.DeleteDuplicates(head);
            //Console.WriteLine("Removed Duplicates");
            //link.PrintAllListNodes();

            //ReorderLinkedList r = new ReorderLinkedList();
            //r.ReorderList(head);
            //link.PrintAllListNodes();

            //ReverseLinkedListRange r = new ReverseLinkedListRange();
            //r.ReverseBetween(head, 2, 4);
            //link.PrintAllListNodes();

            //RemoveDuplicatesLinkedList r = new RemoveDuplicatesLinkedList();
            //r.RemoveDuplicates(head);
            //Console.WriteLine("Removed Duplicates List");
            //link.PrintAllListNodes();

            //BackTracking find all paths of a binary tree
            AllPathsInATree all = new AllPathsInATree();
            var lst = all.GetAllPaths(t.root);
            PrintList(lst);

        }

        private static void PrintList(IList<List<int>> nums)
        {
            foreach (var i in nums)
            {
                Console.WriteLine($"List starting");
                foreach (var item in i)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
