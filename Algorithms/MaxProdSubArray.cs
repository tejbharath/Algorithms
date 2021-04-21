using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class MaxProdSubArray
    {
        public int MaxProduct(int[] nums)
        {

            var prod = nums[0] == 0 ? 1 : nums[0];
            var max = nums[0] == 0 ? 1 : nums[0];
            var list = new List<int>();

            if (nums.Length == 1)
            {
                return nums[0];
            }

            for (int i = 0; i < nums.Length - 1; i++)
            { // [2,-1, 1, 1]
                for (int j = i + 1; j < nums.Length; j++)
                {
                    prod = prod * nums[j];
                    list.Add(prod);
                }
                prod = nums[i+1];
            }
            list.Sort();
            max = list.LastOrDefault() <= 1 ? Math.Max(list.LastOrDefault(),MaxValue(nums)) : list.LastOrDefault();

            return max;
        }

        private int MaxValue(int[] nums)
        {

            var maximum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maximum)
                {
                    maximum = nums[i];
                }
            }
            return maximum;
        }
    }
}
