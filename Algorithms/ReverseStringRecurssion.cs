namespace Algorithms
{
    public class ReverseStringRecurssion
    {
        public void reverseString(char[] str) // { 'H', 'E', 'L', 'L', 'O'}
        {
            var left = 0;
            var right = str.Length - 1;

            reversing(str, left, right);

        }

        private void reversing(char[] str, int left, int right)
        {
            if (left >= right)
            {
                return;
            }                     

            var temp = str[left];
            str[left] = str[right];
            str[right] = temp; // {'O', 'L', 'L', 'E', 'H'}, 2, 2

            reversing(str, ++left, --right);
        }
    }
}
