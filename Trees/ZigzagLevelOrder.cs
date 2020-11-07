using System.Collections.Generic;

namespace Trees
{
    public class ZigzagLevelOrder
    {
        public IList<IList<int>> ZigLevelOrder(TreeNode root)
        {

            IList<IList<int>> returnList = new List<IList<int>>();

            if (root == null)
            {
                return returnList;
            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var flag = false;

            while (queue.Count != 0)
            {

                var lst = new List<int>();
                var count = queue.Count;


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

                    lst.Add(curr.val);

                }

                if (flag == true)
                {
                    lst.Reverse();
                }

                flag = !flag;
                returnList.Add((IList<int>)lst);
            }
            return returnList;
        }
    }
}
