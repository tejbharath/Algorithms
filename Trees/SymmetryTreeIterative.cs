using System.Collections.Generic;

namespace Trees
{
    public class SymmetryTreeIterative
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var levels = queue.Count;
                var levelList = new List<int>();
                var leafNode = false;
                for (var i = 0; i < levels; i++)
                {
                    var curr = queue.Dequeue();
                    if (curr.left == null && curr.right == null)
                    {
                        leafNode = true;
                    }

                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    else
                    {
                        if (!leafNode)
                        {
                            return false;
                        }
                    }

                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                    else
                    {
                        if (!leafNode)
                        {
                            return false;
                        }
                    }

                    levelList.Add(curr.val);
                }

                if (!IsLevelListSymmetric(levelList))
                {
                    return false;
                }

            }
            return true;
        }

        public bool IsLevelListSymmetric(List<int> list)
        {
            if (list.Count == 1)
            {
                return true;
            }

            if (list.Count % 2 != 0)
            {
                return false;
            }

            var left = 0;
            var right = list.Count - 1;
            var mid = list.Count / 2;
            while (left <= mid - 1 && right >= mid)
            {
                if (list[left] != list[right])
                {
                    return false;
                }

                if (left < list.Count && right > 0)
                {
                    left++;
                    right--;
                }

            }
            return true;
        }
    }
}
