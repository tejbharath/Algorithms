
using System;

namespace Algorithms
{
    public class RotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int pivot;
            var last = nums.Length-1;

            if(nums.Length == 1 && nums[0] == target)
            {
                return 0;
            }
            //{1, 3}, 1
            for(int i=0; i < nums.Length-1; i++)
            {
                if(nums[i] > nums[i + 1])
                {
                    pivot = i + 1;
                    if (target >= nums[pivot] && target <= nums[last])
                    {
                        return SearchBinary(nums, pivot, last, target);
                    }
                    else
                    {
                        return SearchBinary(nums, 0, pivot - 1, target);
                    }                    
                }
            }    
            
            return SearchBinary(nums,0, last, target);
        }

        private int SearchBinary(int[] nums, int left, int right, int target)
        {
            
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if(nums[mid] == target)
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
    }
}
