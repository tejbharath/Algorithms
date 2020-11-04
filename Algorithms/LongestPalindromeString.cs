using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class LongestPalindromeString
    {
        public string LongestPalindrome(string s)
        {
            var list = new List<string>();
            var map = new Dictionary<int, char>();
            var strArr = s.ToCharArray();

            if (strArr.Length == 1)
            {
                return s;
            }

            var left = 0;
            var right = 1;
            map.Add(left, strArr[left]);
            // regular palindrome "abcca"

            while (right < strArr.Length)
            {
                map.TryGetValue(right, out char value);
                if (value == strArr[right])
                {
                    left = right - 1;
                }
                map.Add(right, strArr[right]);
                if (strArr[left] == strArr[right])
                {
                    if (CheckPalindrome(s.Substring(left,right+1).ToCharArray(), left, right))
                    {
                        list.Add(s.Substring(left, right+1));
                    }
                    left = right;
                }
                right++;
            }
            var max = 0;
            var index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > max)
                {
                    max = list[i].Length;
                    index = i;
                }
            }
            if (list.Count == 0)
            {
                return "";
            }
            return list[index];
        }

        private bool CheckPalindrome(char[] s, int left, int right)
        {
            StringBuilder sb = new StringBuilder();                      
             
            for (int i = right; i >= left; i--)
            {
                sb.Append(s[i]);
            }

            if (sb.ToString() == new string(s))
            {
                return true;
            }
            return false;
        }
    }
}
