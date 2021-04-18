using System.Collections.Generic;

namespace Algorithms
{
    public class MissingLeastIntegerUnsortedArray
    {
        public int GetMissingInteger(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                dict.Add(i + 1, arr[i]);
            }

            var min = int.MaxValue;
            for(int j = 0; j < arr.Length; j++)
            {
                if (!dict.ContainsValue(j + 1))
                {
                    if(j+1 <  min)
                    {
                        min = j + 1;
                    }
                }
            }
            if(min == int.MaxValue)
            {
                return arr.Length + 1;
            }
            return min;
        }
    }
}
