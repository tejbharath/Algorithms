namespace Algorithms
{
    public class Factorial
    {
        public int GetFactorial(int n)
        {

            if (n <= 1)
            {
                return 1;
            }

            return n * GetFactorial(n - 1);
        }
    }
}
