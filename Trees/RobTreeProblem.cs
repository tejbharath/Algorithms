using System;

namespace Trees
{
    public class RobTreeProblem
    {
        public int Rob(int[] nums)
        {
            return Helper(nums, 0, 0);
        }

        public int Helper(int[] nums, int i, int amount)
        {
            //Base Case
            if (i >= nums.Length) return amount;
            return Math.Max(Helper(nums, i + 2, nums[i] + amount), Helper(nums, i + 1, amount));
        }
    }
}
