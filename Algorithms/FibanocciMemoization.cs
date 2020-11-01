using System.Collections.Generic;

namespace Algorithms
{
    public class FibanocciMemoization
    {
        public int FindFibanocci(int count)
        {
            if (count < 2)
            {
                return count;
            }

            return FindFibanocci(count - 1) + FindFibanocci(count - 2);
        }

        public int FindFibanocciMem(int count)
        {
            var cache = new Dictionary<int, int>
            {
                { 0, 0 },
                { 1, 1 }
            };

            if (cache.ContainsKey(count))
            {
                cache.TryGetValue(count, out int value);
                return value;
            }
            
            var result = FindFibanocciMem(count - 1) + FindFibanocciMem(count - 2);

            cache.Add(count, result);
            return result;
        }
    }
}
