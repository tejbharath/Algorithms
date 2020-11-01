using System;

namespace Algorithms
{
    public class ReverseWord
    {
        public string Reverse(string str)
        {
            var arr = str.ToCharArray();

            var left = 0;
            var right = arr.Length - 1;            

            while(left <= right)
            {
                var temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            
            return new string(arr);
        }
    }
}
