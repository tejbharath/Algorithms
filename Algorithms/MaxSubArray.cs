using System;

namespace Algorithms
{
    public class MaxSubArray
    {
        public int MaximumSubArray(int[] nums)
        {
            //{ -2, 1, -3, 4, -1, 2, 1, -5, 4 }

            var sum = 0;
            var max = nums[0];
            var i = 0;
            var j = 0;
            while(j < nums.Length)
            {
                sum += nums[j];

                if(sum > max)
                {
                    max = sum;
                }
                else
                {
                    sum = 0;
                    i++;
                    j = i;
                }
                j++;
            }

            return max;

        }
    }
}
