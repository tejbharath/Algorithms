using System.Collections.Generic;

namespace Trees
{
    public class AllPathsInATree
    {
        public IList<List<int>> GetAllPaths(TreeNode root)
        {
            IList<List<int>> returnList = new List<List<int>>();
            IList<int> path = new List<int>();
            Helper(root, returnList, path);
            return returnList;
        }

        private static void Helper(TreeNode root, IList<List<int>> returnList, IList<int> path)
        {
            //Base Case
            if (root == null) return;
            path.Add(root.val);

            if (root.left == null && root.right == null)
            {
                returnList.Add(new List<int>(path));
                return; //copying path to a new list as path is getting modified in further recursions
            }

            Helper(root.left, returnList, path);
            path.RemoveAt(path.Count-1);
            Helper(root.right, returnList, path);
            path.RemoveAt(path.Count-1);

        } 
    }
}
