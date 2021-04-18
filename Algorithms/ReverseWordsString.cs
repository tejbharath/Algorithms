using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ReverseWordsString
    {
        public string ReverseWords(string s)
        {
            string[] arr = s.Split(' ');
            var stack = new Stack<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
            }

            arr = new string[stack.Count];

            for(int j = 0; j < arr.Length; j++)
            {
                arr[j] = stack.Pop();
            }
            return string.Join(" ", arr);
        }
    }
}
