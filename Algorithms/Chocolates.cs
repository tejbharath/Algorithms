using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Chocolates
    {
        public int GetMinumum(List<int> chocolates)
        {
            chocolates.Sort();
            try
            {
                var half = chocolates.Count / 2;
                var i = 0;
                var j = chocolates.Count - 1;
                var firstCount = 0;
                var secondCount = 0;
                var iteratorCount = 0;
                while (iteratorCount < half)
                {
                    firstCount = chocolates[i] + chocolates[j];
                    chocolates.RemoveAt(i);
                    chocolates.RemoveAt(j-1);
                    iteratorCount += 2;
                    i++;
                    j--;
                }

                for(var k = 0; k < chocolates.Count; k ++)
                {
                    secondCount += chocolates[k];
                }

                return Math.Abs(firstCount - secondCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
                return 0;
            }
        }
    }
}
