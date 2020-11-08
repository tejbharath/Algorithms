using System;
using System.Collections.Generic;

namespace Trees
{
    public class LargestValueInEachRow
    {
        public IList<int> LargestValues(TreeNode root)
        {
            IList<int> returnList = new List<int>();

            if (root == null)
            {
                return returnList;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var count = queue.Count;
                var max = Int32.MinValue;
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

                    max = Math.Max(curr.val, max);
                }
                returnList.Add(max);

            }

            return returnList;
        }
    }
}
