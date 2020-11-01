namespace Algorithms
{
    class FibanocciRecursion
    {
        public int[] FindFibanocci(int length)
        {
            var res = new int[length];
            res[0] = 0;
            res[1] = 1;

            for (int i = 2; i < length; i++)
            {
                res[i] = res[i - 1] + res[i - 2];
            }

            return res;
        }

        public int[] FindFibanocciRecursion(int length)
        {
            var res = new int[length];
            res[0] = 0;
            res[1] = 1;

            var iterator = 2;
            RecurseFib(length, res, iterator);
            
            return res;
        }

        private void RecurseFib(int length, int[] res, int i)
        {
            // Base case
            if (i >= length)
            {
                return;
            }

            res[i] = res[i - 1] + res[i - 2];
            RecurseFib(length, res, ++i);
        }
    }
}
