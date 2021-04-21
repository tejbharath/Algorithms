using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class LongestSubstringVowels
    {
        public int FindTheLongestSubstringVowelsLength(string s)
        {
            var count = 0;
            var max = 0;
            for(var i = 0; i < s.Length; i++)
            {
                if (isVowel(s[i]))
                {
                    count++;
                }
                else
                {
                    max = Math.Max(max, count);
                    count = 0;
                }
            }

            return max;
        }

        public int FindTheLongestSubstringLengthStartingAndEndingWithVowels(string s)
        {
            var left = 0;
            var right = 1;
            var strList = new List<string>(); 
            while(right < s.Length)
            {
                if (!isVowel(s[left]))
                {
                    left = left + 1;
                    right = left + 1;
                }
                else if (isVowel(s[right]))
                {
                    right = right + 1;
                }
                else
                {
                    strList.Add(s.Substring(left, right - left + 1));
                    left = right + 1;
                    right = right + 2;
                }
                
            }
            return 0;
        }

        public bool isVowel(char c)
        {
            if( c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                return true;
            }
            return false;
        }
    }
}
