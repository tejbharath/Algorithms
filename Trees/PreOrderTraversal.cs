using System;
using System.Collections.Generic;

namespace Trees
{
    public class PreOrderTraversal
    {
        public TreeNode root;

        public void BuildTree()
        {
            root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
        }

        public void Traverse()
        {
            if (root == null)
            {
                return;
            }

            var result = new Stack<TreeNode>();
            var list = new List<int>();
            TreeNode curr = root;

            while (curr != null || result.Count!=0)
            {
                //Reach the left most node of the tree and store each in a stack
                while(curr != null)
                {
                    result.Push(curr);
                    curr = curr.left; //1, 2, 4
                }

                curr = result.Pop(); // 4
                list.Add(curr.val);

                curr = curr.right;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
