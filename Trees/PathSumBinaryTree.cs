using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class PathSumBinaryTree
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            return HasSum(root, 0, sum); // 1, 2
        }

        public bool HasSum(TreeNode root, int runningSum, int sum)
        {

            if (root == null) return false;
            if (root != null)
            {
                runningSum = runningSum + root.val; //1
            }

            if (root.left == null && root.right == null) return runningSum == sum;

            return HasSum(root.left, runningSum, sum) || HasSum(root.right, runningSum, sum);
        }
    }
}
