using System.Collections.Generic;

namespace Algorithms
{
    public class ClimbingStairs
    {
        public int DistinctClimb(int stepCount)
        {
            var lst = new List<int>();
            var i = 0;

            while( i < stepCount)
            {
                lst.Add(1);
                i++;
            }

            return -1;
        }
    }
}
