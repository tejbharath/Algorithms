using System;

namespace Trees
{
    public class SumNodes
    {
        public int SumNumbers(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null)
            {
                return root.val;
            }
            var sum = root.val;
            return SumNumbers(root.left, sum) + SumNumbers(root.right, sum);
        }

        public int SumNumbers(TreeNode child, int sum)
        {
            if (child == null) return 0;
            sum = 10 * sum + child.val;
            if (child.left == null && child.right == null) return sum;
            return SumNumbers(child.left, sum) + SumNumbers(child.right, sum);
        }
    }
}
