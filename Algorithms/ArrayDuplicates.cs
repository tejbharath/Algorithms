using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ArrayDuplicates
    {
            public bool ContainsDuplicate(int[] nums)
            {
                var i = 0;
                var j = 1;
            while (i <= nums.Length - 2)
            {
                while (j < nums.Length)
                {
                    if (nums[j] - nums[i] == 0)
                    {
                        return true;
                    }
                    j++;
                }
                if(i <= nums.Length - 2)
                {
                    i++;
                    j = i + 1;
                }
            }
 
                 
                return false;
            }
     
    }
}
