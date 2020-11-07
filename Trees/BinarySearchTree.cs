using System;

namespace Trees
{
    public class BinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {

            return ValidateBST(root, null, null);

        }

        private bool ValidateBST(TreeNode root, Object min, Object max)
        {

            //Base Cases

            if (root == null)
            {
                return true;
            }

            if (min != null && root.val <= (int)min)
            {
                return false;
            }

            if (max != null && root.val >= (int)max)
            {
                return false;
            }

            return ValidateBST(root.left, min, root.val) && ValidateBST(root.right, root.val, max);
        }
    }
}
