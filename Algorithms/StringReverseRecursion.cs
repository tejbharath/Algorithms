using System;

namespace Algorithms
{
    class StringReverseRecursion
    {
        public string Reverse(string word)
        {
           var strArr = new char[word.Length];
           Helper(0, word.Length-1, word, strArr);
           return new String(strArr);
        }

        private void Helper(int i, int j, string word, char[] strArr)
        {
            if (word == null || i >= word.Length)
            {
                return;
            }
            strArr[j] = word[i];
            Helper(i+1, j-1, word, strArr);
        }
    }
}
