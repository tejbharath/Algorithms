using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            // {1, 4, 6, 8, 9, 10}, target - 9

            var left = 0; // 3
            var right = nums.Length - 1; // 5

            while(left <= right)
            {
                var mid = left + (right - left) / 2; // To avoid integer overflow

                if (target == nums[mid])
                {
                    return mid;
                }

                if(target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            
            return -1;
        }

        public int SearchRecurssion(int[] nums, int target)
        {
            // {1, 4, 6, 8, 9, 10}, target - 9

            var left = 0; // 3
            var right = nums.Length - 1; // 5

            return Searching(nums, left, right, target);
        }

        private int Searching(int[] nums, int left, int right, int target)
        {
            if(left > right)
            {
                return -1;
            }
  
            var mid = left + (right - left) / 2;

            if (target == nums[mid])
            {
                return mid;
            }

            if (target > nums[mid])
            {
                return Searching(nums, mid + 1, right, target);
            }
            else
            {
                return Searching(nums, left, mid - 1, target);
            }
        }
    }
}
