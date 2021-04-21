namespace Algorithms
{
    public class ProductItself
    {
        public class Solution
        {
            public int[] ProductExceptSelf(int[] nums)
            {
                var forward = new int[nums.Length];
                var backward = new int[nums.Length];
                var product = new int[nums.Length];


                forward[0] = 1;
                for (int i = 1; i < nums.Length; i++)
                {
                    forward[i] = forward[i - 1] * nums[i - 1];
                }

                backward[nums.Length - 1] = 1;
                for (int j = nums.Length - 2; j >= 0; j--)
                {
                    backward[j] = backward[j + 1] * nums[j + 1];
                }

                for (int k = 0; k < nums.Length; k++)
                {
                    product[k] = forward[k] * backward[k];
                }

                return product;
            }
        }

    }
}
