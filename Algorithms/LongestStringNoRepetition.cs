using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class LongestStringNoRepetition
    {
        public int LengthOfLongestSubstring(string s)
        {

            var set = new HashSet<char>();
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = i+1; j < s.Length; j++)
                {
                    if(s[i] != s[j] && !set.Contains(s[i]))
                    {
                        set.Add(s[i]);
                    }
                }
            }

            //var max = 0;
            //foreach (var item in lst)
            //{
            //    if(item.Length > max)
            //    {
            //        max = item.Length;
            //    }
            //}
            
            return set.Count;
        }
    }
}
