using System.Collections.Generic;

namespace Algorithms
{
    public class FirstLastArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var i = 0;
            var j = 0;
            var res = new List<int>();

            while(i < nums.Length)
            {
                if(target == nums[i])
                {
                   res.Add(i);
                   j++;
                }
                i++;
            }

            if(res.Count == 0)
            {
                return new int[] { -1, -1 };
            }

            return new int[] { res[0], res[res.Count - 1] };
            
        }
    }
}
