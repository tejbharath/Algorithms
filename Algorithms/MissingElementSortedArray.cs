using System.Collections.Generic;

namespace Algorithms
{
    public class MissingElementSortedArray
    {
        //public int MissingElements(int[] nums, int k)
        //{
        //    var missingNums = new List<int>();
        //    var i = 0;
        //    var j = 1;
        //    while(i < nums.Length-1  && j < nums.Length)
        //    {
        //        if (nums[j] - nums[i] > 1)
        //        {
        //            var leftVal = nums[i];
        //            while (leftVal < nums[j] - 1)
        //            {
        //                missingNums.Add(leftVal + 1);
        //                leftVal = leftVal + 1;
        //            }
        //        }
        //        i = j;
        //        j = j + 1;
        //    }
        //    return missingNums[k - 1];
        //}

        public int MissingElements(int[] nums, int k)
        {
            var missingNums = new List<int>();
            
            for(var i = nums[0]; i< 10; i++)
            {
                missingNums.Add(i + 1);
            }
            
            for(int j = 1; j < nums.Length; j++)
            {
                if (missingNums.Contains(nums[j]))
                {
                    missingNums.Remove(nums[j]);
                }
            }
            return missingNums[k - 1];
        }
    }
}
