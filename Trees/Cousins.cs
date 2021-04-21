using System.Collections.Generic;

namespace Trees
{
    public class Cousins
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

        public bool IsCousins(int x, int y)
        {

            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count != 0)
            {

                var map = new Dictionary<int, int>();
                var childCount = queue.Count;

                for (int i = 0; i < childCount; i++)
                {
                    var curr = queue.Dequeue();

                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                        map.Add(curr.left.val, curr.val);
                    }

                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                        map.Add(curr.right.val, curr.val);
                    }

                }

                if (map.ContainsValue(x) || map.ContainsValue(y))
                {
                    return false;
                }
                if (map.TryGetValue(x, out int parent1) && map.TryGetValue(y, out int parent2))
                {
                    if (parent1 == parent2)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }


                //levelList.Add(curr.val);
            }
            return false;
        }
    }
}
