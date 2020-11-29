using System.Linq;

namespace Algorithms
{
    public class SortArray
    {

        public int SortRegular(int[] nums, int target)
        {
            var lst = nums.ToList();
            lst.Sort();

            var left = 0;
            var right = lst.Count - 1;
            
            while (left <= right)
            {
                var mid = left + (right - left) / 2; // To avoid integer overflow exception

                if (target == nums[mid])
                {
                    return mid;
                }

                if (target < nums[mid])
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
