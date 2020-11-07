using System;

namespace Algorithms
{
    public class MaxSubArray
    {
        public int MaxArray(int[] nums)
        {
            var sum = nums[0];
            var max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum = Math.Max(nums[i], sum + nums[i]);
                max = Math.Max(max, sum);
            }
            return max;
        }
    }
}
