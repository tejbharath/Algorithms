using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class WordPatternAlgorithm
    {
        public bool WordPattern(string pattern, string s)
        {
            if (pattern == null || pattern.Length == 0 || s == null || s.Length == 0) return false;

            var words = s.Split(' ').ToList();
            if (pattern.Length != words.Count) return false;

            var patternMap = new Dictionary<string, char>();
            var stringMap = new Dictionary<char, string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                var pWord = words[i];
                var sChar = pattern[i];

                if (!patternMap.ContainsKey(pWord))
                {
                    patternMap.Add(pWord, sChar);
                }
                else
                {
                    patternMap.TryGetValue(pWord, out char value);
                    if (sChar != value) return false;
                }

                if (!stringMap.ContainsKey(sChar))
                {
                    stringMap.Add(sChar, pWord);
                }
                else
                {
                    stringMap.TryGetValue(sChar, out string word);
                    if (pWord != word) return false;
                }
            }
            return true;
        }
    }
}
