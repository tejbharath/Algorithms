using System;
using System.Linq;

namespace Algorithms
{
    public class ContiguousArray
    {
        //public int FindMaxLength(int[] nums)
        //{

        //    var left = 0;
        //    var right = 1;
        //    var hold = 0;
        //    var max = 0;

        //    if (nums.Length == 0)
        //    {
        //        return 0;
        //    }

        //    while (right < nums.Length) // [0,0,1,0,0,0,1,1]
        //    {
        //        if (nums[left] == nums[right])
        //        {
        //            if (right - hold > max)
        //            {
        //                max = right - hold;
        //            }
        //            hold = right + 1;
        //        }
        //        left++;
        //        right++;
        //    }

        //    if (max == 0 && nums.Length % 2 == 0)
        //    {
        //        if (nums.Length % 2 == 0)
        //        {
        //            return nums.Length;

        //        }
        //        return nums.Length - 1;
        //    }

        //    return max;
        //}

        public int FindMaxLength(int[] nums)
        {
            // [0,0,1,0,0,0,1,1]
            var countZero = nums.Count(num => num == 0);

            var countOne = nums.Length - countZero;

            return Math.Abs(countZero - countOne);
        }
    }
}
