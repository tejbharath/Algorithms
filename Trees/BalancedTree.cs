using System;

namespace Trees
{
    public class BalancedTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            var count = 0;
            if (Math.Abs(Depth(root.left, count) - Depth(root.right, count)) > 1) return false;
            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        public int Depth(TreeNode root, int count)
        {

            if (root != null)
            {
                count++;
            }

            if (root == null) return count;

            return Math.Max(Depth(root.left, count), Depth(root.right, count));

        }
    }
}
