using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class GroupingAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var returnList = new List<IList<string>>();
            var lst = strs.ToList();
            //var slow = 0;
            //var fast = 1;
            //while(slow <= fast && fast < strs.Length)
            //{
            //    var groupList = new List<string>();
            //    groupList.Add(lst[slow]);
            //    if(IsAnagram(lst[slow], lst[fast]) && !returnList.Any(_ => _.Contains(lst[fast])))
            //    {
            //        groupList.Add(lst[fast]);
            //    }              
            //    if(fast < strs.Length-1)
            //    {
            //        fast++;
            //    }
            //    else 
            //    {
            //        slow++;
            //        fast = slow + 1;
            //        returnList.Add(groupList);
            //    }
            //}

            for(int i = 0; i < strs.Length; i++)
            {
                //for (int j = 1; j < strs.Length; j++)
                //{
                //    var groupList = new List<string>();
                //    groupList.Add(lst[i]);
                //    if (IsAnagram(lst[i], lst[j]) && !returnList.Any(_ => _.Contains(lst[j])))
                //    {
                //        if (!groupList.Contains(lst[i]))
                //        {
                //            groupList.Add(lst[i]);
                //        }
                //     slack   groupList.Add(lst[j]);
                //    }
                //    returnList.Add(groupList);
                //}
            }
            return returnList;
        }

        private bool IsAnagram(string target, string current)
        {
            if (target.Length != current.Length) return false;

            var targetMap = MapValues(target);
            var currentMap = MapValues(current);

            return (targetMap.Keys.All(_ => currentMap.ContainsKey(_))) && (targetMap.Values.All(x => currentMap.ContainsValue(x)));
        }

        private Dictionary<char, int> MapValues(string item) {

            var dict = new Dictionary<char, int>();
            for (int i = 0; i < item.Length; i++)
            {
                if (dict.TryGetValue(item[i], out int value))
                {
                    dict[item[i]] = value++;
                }
                else
                {
                    dict.Add(item[i], 1);
                }
            }

            return dict;
        }
    }
}

