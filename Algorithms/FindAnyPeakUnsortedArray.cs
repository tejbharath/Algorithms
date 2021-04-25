namespace Algorithms
{
    public class FindAnyPeakUnsortedArray
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums == null || nums.Length == 0) return -1;

            var left = 0;
            var right = nums.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if ((mid == nums.Length - 1 || nums[mid] > nums[mid + 1]) && (mid == 0 || nums[mid] > nums[mid - 1]))
                {
                    return mid;
                }
                else if (nums[mid] < nums[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}