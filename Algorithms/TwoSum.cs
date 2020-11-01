using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class TwoSum
    {
        public int[] CaluclateTwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(target-nums[i]))
                {
                    dict.Add(nums[i], i);
                }
                else
                {
                    dict.TryGetValue(target-nums[i], out int value);
                    return new int[] { i, value };
                }

            }
            return new int[] { 0, 0 };
            //var j = 1;
            //while(i < nums.Length)
            //{
            //    while (j < nums.Length)
            //    {
            //        if (target - nums[i] == nums[j])
            //        {
            //            return new int[] { i, j };
            //        }
            //        j++;
            //    }
            //    i++;
            //    j = i + 1;
            //}
            //return new int[] { };
        }
    }

}
