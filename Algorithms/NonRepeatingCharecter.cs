using System.Collections.Generic;

namespace Algorithms
{
    public class NonRepeatingCharecter
    {
      public int FirstUniqueCharecter(string s) 
      {
            var dict = new Dictionary<char, int>();

            for(var i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 1);
                }
                else
                {
                    dict.TryGetValue(s[i], out int value);
                    dict[s[i]] = value + 1;
                }
            }

            for(var i = 0; i < s.Length; i++)
            {
               if(dict[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;       
      }
    }

}
