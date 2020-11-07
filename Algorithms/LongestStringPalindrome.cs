using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class LongestStringPalindrome
    {
        public string LongestPalindrome(string s)
        {
            var lst = new List<string>();
            var left = 0;
            var right = 1;

            if (s.Length == 1)
            {
                return s;
            }

            if (isPalindrome(s))
            {
                return s;
            }

            while (left < right && right <= s.Length - 1)
            {
                string substr = null;
                if (right - left == 1)
                {
                    if (s[left] == s[right])
                    {
                        substr = s.Substring(left, (right - left) + 1);
                    }
                    else
                    {
                        substr = s.Substring(left, right - left);
                    }


                }
                else
                {
                    substr = s.Substring(left, (right - left));
                }
                
                if (isPalindrome(substr))
                {
                    lst.Add(substr);
                }

                if (right == s.Length - 1)
                {
                    if (isPalindrome(substr))
                    {
                        lst.Add(substr);
                    }
                    left += 1;
                    right = left + 1;
                }
                else
                {
                    right++;
                }

            }

            return GetMaxLengthElement(lst);
        }

        private string GetMaxLengthElement(List<string> lst)
        {
            string maxString = null;

            if (lst.Count == 2)
            {
                if (lst[0].Length > lst[1].Length)
                {
                    return lst[0];
                }
                else
                {
                    return lst[1];
                }
            }
            for(int i = 0 ; i < lst.Count - 2; i+=2)
            {
                if (lst[i].Length > lst[i + 1].Length)
                {
                    maxString = lst[i];
                }
                else
                {
                    maxString = lst[i + 1];
                }
            }

            if (lst.Count == 0)
            {
                return "";
            }

            return maxString;
        }

        private bool isPalindrome(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            if (sb.ToString() == str)
            {
                return true;
            }
            return false;
        }
    }
}
