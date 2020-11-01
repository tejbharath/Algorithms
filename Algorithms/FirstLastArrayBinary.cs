namespace Algorithms
{
    public class FirstLastArrayBinary
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length-1;
            var res = new int[2];

            res[0] = FindLeftIndex(nums, left, right, target);
            res[1] = FindRightIndex(nums, left, right, target);

            return res;
        }

        private int FindRightIndex(int[] nums, int left, int right, int target)
        {
            while(left <= right)
            {
                var mid = left + (right - left) / 2;
                if(target > nums[mid])
                {
                    left = mid + 1;
                }
                else if(target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    if (mid == right || nums[mid + 1] > target)
                    {
                        return mid;
                    }
                    if (nums[mid+1] == target)
                    {
                        left = mid + 1;
                    }
                }
            }
            return -1;
        }

        private int FindLeftIndex(int[] nums, int left, int right, int target)
        {

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else if(target > nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    if(left == mid || nums[mid - 1] < target)
                    {
                        return mid;
                    }
                    if(nums[mid -1] == target)
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
