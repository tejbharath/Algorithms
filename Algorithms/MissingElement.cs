using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MissingElement
    {
        public int FindMissingElement(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (!(nums[i] == nums[i + 1] - 1))
                {
                    return nums[i + 1] - 1;
                }
            }
            return -1;
        }

        public int FindMissingElementExtraArray(int[] nums)
        {
            var leftElem = nums[nums.Length - 1];

            var tempArr = new int[leftElem];

            for (int i = 0; i < nums.Length; i++)
            {
                tempArr[i] = i + 1;
            }

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != tempArr[i]) return tempArr[i];
            }
            return -1;
        }

        public int FindMissingElementBinarySearch(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            while(left <= right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] != nums[mid - 1] + 1)
                {
                    right = mid;
                }
            }

             
            return -1;
        }

        private int BinarySearchRight(int left, int right, int[] nums)
        {
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] != nums[mid + 1] - 1)
                {
                    return nums[mid+1] - 1;
                }
                else
                {
                    left = mid;
                }
            }
            return -1;
        }

        private int BinarySearchLeft(int left, int right, int[] nums)
        {
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (mid >= 0 || nums[mid] != nums[mid - 1] + 1)
                {
                    return nums[mid - 1] + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return -1;
        }
    }
}
