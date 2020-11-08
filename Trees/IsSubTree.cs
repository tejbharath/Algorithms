namespace Trees
{
    public class IsSubTree
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null) return false;
            if (ValidateSubtree(s, t)) return true;
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        public bool ValidateSubtree(TreeNode s, TreeNode t)
        {
            //BaseCase
            if (s == null && t == null) return true;
            if (s == null || t == null) return false;
            if (s.val != t.val) return false;
            return ValidateSubtree(s.left, t.left) && ValidateSubtree(s.right, t.right);
        }
    }
}
