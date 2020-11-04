using System;
using System.Text;

namespace Algorithms
{
    public class StringPalindrome
    {
        public bool IsPalindrome(string s)
        {

            var delimiters = new char[] { ',', ' ', ':' };
            for (int j = 0; j < delimiters.Length; j++)
            {
                s = s.Replace(delimiters[j].ToString(), string.Empty);
            }

            s = s.ToLower();

            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrEmpty(s))
            {
                return true;
            }

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            if (sb.ToString() == s)
            {
                return true;
            }

            return false;
        }
    }
}
