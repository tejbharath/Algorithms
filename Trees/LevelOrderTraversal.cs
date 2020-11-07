using System.Collections.Generic;

namespace Trees
{
    public class LevelOrderTraversal // Breadth First Search in a Tree
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

        public List<List<int>> LevelTraversal()
        {
            var returnList = new List<List<int>>();
            if (root == null)
            {
                return returnList;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var lst = new List<int>();
                var count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    var curr = queue.Dequeue();
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }

                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }

                    lst.Add(curr.val);
                }
                returnList.Add(lst);
            }

            return returnList;
        }

        public List<int> BreadFirstTraversal()
        {
            var returnList = new List<int>();
            if (root == null)
            {
                return returnList;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var count = queue.Count;

                var curr = queue.Dequeue();

                if (curr.left != null)
                {
                    queue.Enqueue(curr.left);
                }

                if (curr.right != null)
                {
                    queue.Enqueue(curr.right);
                }

                returnList.Add(curr.val);
            }

            return returnList;
        }

    }
}
