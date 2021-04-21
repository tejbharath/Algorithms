namespace Trees
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return IsSymmetric(root.left, root.right);
        }

        public bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            if (left.val != right.val) return false;
            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
    }
}
