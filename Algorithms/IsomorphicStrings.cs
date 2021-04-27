using System.Collections.Generic;

namespace Algorithms
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (t == null || t.Length == 0 || s == null || s.Length == 0 || s.Length != t.Length) return false;

            var sMap = new Dictionary<char, char>();
            var tMap = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                var sChar = s[i];
                var tChar = t[i];

                if (!sMap.ContainsKey(sChar))
                {
                    sMap.Add(sChar, tChar);
                }
                else
                {
                    sMap.TryGetValue(sChar, out char tValue);
                    if (sChar != tValue) return false;
                }

                if (!tMap.ContainsKey(tChar))
                {
                    tMap.Add(tChar, sChar);
                }
                else
                {
                    tMap.TryGetValue(tChar, out char sValue);
                    if (tChar != sValue) return false;
                }
            }
            return true;
        }
    }
}
