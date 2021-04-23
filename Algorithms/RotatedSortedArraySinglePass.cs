using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class RotatedSortedArraySinglePass
    {
        public int Search(int[] nums, int target)
        {

            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[left] <= nums[mid])
                { // Is the left part of the array sorted?
                    if (target >= nums[left] && target < nums[mid])
                    { // does the target in left
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                { // Is the right part of the array sorted?
                    if (target <= nums[right] && target > nums[mid])
                    { // does the target in left
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
