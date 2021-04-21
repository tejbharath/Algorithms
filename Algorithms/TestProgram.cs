using System;
using System.Threading.Tasks;

namespace Algorithms
{
    public class TestProgram
    {
        //public int[] getEven(List<int> nums)
        //{
        //    return nums.Where(x => (x % 2 == 0)).Take(3).ToArray();
        //}
        
        public static async Task AsyncMethod()
        {
            try
            {
                Method1Async();
                Console.WriteLine("done");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception catched : " + e.Message);
            }
            await Task.Delay(2000);
        }

        public static async Task Method1Async()
        {
            await Task.Delay(1000);
            Console.WriteLine("Method1");
            throw new Exception("This is an exception");
        }

    }
}
