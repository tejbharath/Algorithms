namespace Algorithms
{
    public class MinSortedArray
    {
        public int FindMin(int[] nums)
        {
            if (nums == null && nums.Length == 0) return -1;

            var left = 0;
            var right = nums.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if ((mid == 0 || nums[mid - 1] > nums[mid]) && (mid == nums.Length - 1 || nums[mid + 1] > nums[mid]))
                {
                    return nums[mid];
                }
                else if (nums[mid] < nums[right]) //Right sorted
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return 0;
        }

    }
}
