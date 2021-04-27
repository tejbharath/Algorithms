using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class GroupingAnagramAlgorithm
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs == null || strs.Length == 0) return new List<IList<string>>();
            
            var dict = new Dictionary<string, IList<string>>();

            for(var i = 0; i < strs.Length; i++)
            {
                var arr = strs[i].ToCharArray().OrderBy(_ => _).ToArray();
                var sortedKey = new string(arr);
                if (!dict.ContainsKey(sortedKey))
                {
                    dict.Add(sortedKey, new List<string> {strs[i]});
                }
                else
                {
                    dict.TryGetValue(sortedKey, out IList<string> groupedList);
                    groupedList.Add(strs[i]);
                }
            }

            return dict.Values.ToList();
        }
    }
}
