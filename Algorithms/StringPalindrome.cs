using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithms
{
    public class StringPalindrome
    {
        public bool IsPalindrome(string s)
        {
            s = Regex.Replace(s, "[^a-zA-Z0-9]", string.Empty);
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
