namespace Algorithms
{
    public class BalancedString
    {
        public int GetBalancedStringCount(string s)
        {
            int res = 0;
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
                if (counter == 0)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
