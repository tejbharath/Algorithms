using System;

namespace Algorithms
{
    public class ReverseString
    {
       public char[] reverseString(string str)
       {
 
            if(String.IsNullOrEmpty(str))
            {
                return new char[] { };
            }

            var arr = str.ToCharArray();
            var n = arr.Length;
            var res = new char[n];

            var result = reverse(arr, res, 0, n - 1);

            return result;       
        }

        private char[] reverse(char[] arr, char[] res, int current, int last)
        {
            if(last < 0)
            {
                return res;
            }

            res[current] = arr[last];
            return reverse(arr, res, current + 1, last - 1);            
        }
    }


}
