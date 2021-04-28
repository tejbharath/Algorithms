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

        public int FindMissingElementBinarySearch(int[] nums) //[1, 2, 3, 5, 6, 7]
        {
            var left = 0;
            var right = nums.Length - 1;
            while(left <= right)
            {
                var mid = left + (right - left) / 2;
                if (nums[mid] != mid)
                {
                    if(nums[mid-1] + 1 != mid)
                    {
                        return mid;
                    }
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
