using System.Collections.Generic;

namespace Trees
{
    public class RightSideView
    {
        //public IList<int> RightView(TreeNode root)
        //{

        //    IList<int> lst = new List<int>();
        //    if (root == null)
        //    {
        //        return lst;
        //    }
        //    var queue = new Queue<TreeNode>();
        //    queue.Enqueue(root);

        //    while (queue.Count != 0)
        //    {

        //        var count = queue.Count;

        //        for (int i = 0; i < count; i++)
        //        {
        //            var curr = queue.Dequeue();

        //            if (curr.left != null)
        //            {
        //                queue.Enqueue(curr.left);
        //            }

        //            if (curr.right != null)
        //            {
        //                queue.Enqueue(curr.right);
        //            }

        //            if (i == count - 1)
        //            {
        //                lst.Add(curr.val);
        //            }
        //        }

        //    }
        //    return lst;
        //}

        public IList<int> RightView(TreeNode root)
        { // 1, 3

            IList<int> returnList = new List<int>();
            return Helper(root, returnList);
        }

        public IList<int> Helper(TreeNode root, IList<int> returnList)
        {

            if (root == null)
            {
                return returnList;
            }

            returnList.Add(root.val);
            return Helper(root.right, returnList);
        }
    }
}
