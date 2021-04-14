using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class TwoSum
    {
        public int[] CaluclateTwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for(int i=0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(target - nums[i])){
                    map.Add(nums[i], i);
                }
                else
                {
                    map.TryGetValue(target - nums[i], out int index);
                    return new int[] { i, index };
                }
            }
            return new int[] { 0, 0 };
        }
    }

}
