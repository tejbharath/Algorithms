using System;

namespace Algorithms
{
    public class ClosestToZero
    {
        public int ClosestZero(int[] nums) //{-9, 8, 2, -1, 4}
        {
            var closest = Math.Abs(nums[0]);

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] > 0 && closest > Math.Abs(0 - nums[i]))
                {
                        closest = nums[i];
                }
                else
                {
                    if (closest > Math.Abs(0 - Math.Abs(nums[i])))
                    {
                        closest = nums[i];
                    }
                }
            }


            return closest;

        }
    }
}
