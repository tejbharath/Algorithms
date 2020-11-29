using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Algorithms
{

    public class Program
    {        
        static async Task Main(string[] args)
        {
            //---TWO SUM Call
            //TwoSum sum = new TwoSum();
            //var intarr = new int[] { 3, 1, 9, 4 };
            //var twosum = sum.CaluclateTwoSum(intarr, 5);
            //Console.WriteLine("two sum:");
            //Console.WriteLine("\n");
            //foreach (var item in twosum)
            //{
            //    Console.WriteLine(item);
            //}

            ////StocksAlgo stock = new StocksAlgo();
            ////var stocks = new int[] { 1, 7, 5 , 9, 6 };
            ////var profit = stock.MaxProfit(stocks);
            ////Console.WriteLine(profit);

            //Array Duplicates
            //ArrayDuplicates dup = new ArrayDuplicates();
            //Console.WriteLine(dup.ContainsDuplicateOptimized(new int[] { 1, 4, 5, 0, 3, 6 }));

            //Chocolates c = new Chocolates();
            //Console.WriteLine(c.GetMinumum(new List<int>() { 5, 6, 8, 1 }));

            //BinarySearch s = new BinarySearch();
            //var item = s.SearchRecurssion(new int[] { 1, 5, 7, 19, 21, 25, 27, 29 }, 27);
            //Console.WriteLine(item);

            //ReverseString str = new ReverseString();
            //Console.WriteLine(str.reverseString("Hello"));

            //MaxSubArray m = new MaxSubArray();
            //Console.WriteLine(m.MaximumSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));

            //ReverseWord r = new ReverseWord();
            //Console.WriteLine(r.Reverse("Hello"));

            //RotatedSortedArray r = new RotatedSortedArray();
            //Console.WriteLine(r.Search(new int[] {1, 2}, 2));

            //FirstLastArray f = new FirstLastArray();
            //var arr = f.SearchRange(new int[] { 0 }, 0);
            //for(int i = 0; i< arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //FirstLastArrayBinary f = new FirstLastArrayBinary();
            //var arr = f.SearchRange(new int[] { 0, 1, 3, 4, 4, 4, 6 }, 6);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //FibanocciRecursion f = new FibanocciRecursion();
            //var arr = f.FindFibanocciRecursion(8);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //FibanocciMemoization f = new FibanocciMemoization();
            //Console.WriteLine(f.FindFibanocciMem(6));

            //Factorial f = new Factorial();
            //Console.WriteLine(f.GetFactorial(1));

            //LongestStringNoRepetition s = new LongestStringNoRepetition();
            //Console.WriteLine(s.LengthOfLongestSubstring("abcabbca"));

            //StringPalindrome pd = new StringPalindrome();
            //Console.WriteLine(pd.IsPalindrome("A man, a plan, a canal: Panama"));

            //LongestPalindromeString lpd = new LongestPalindromeString();
            //Console.WriteLine(lpd.LongestPalindrome("babad"));

            //ContiguousArray c = new ContiguousArray();
            //Console.WriteLine(c.FindMaxLength(new int[]{0, 0, 1, 0, 0, 0, 1, 1}));
            //var nums = new int[] {1, 2, 4, 5, 6, 8};
            //ShuffleArray arr = new ShuffleArray(nums);
            //PrintArray(nums);
            //Console.WriteLine("Shuffling the Array");
            //PrintArray(arr.Shuffle());
            //Console.WriteLine("Reset starting in 1 second");
            //PrintArray(arr.Reset());
            //Console.WriteLine("Reshuffling the Array");
            //PrintArray(arr.Shuffle());

            //MaxProdSubArray arr = new MaxProdSubArray();
            //Console.WriteLine(arr.MaxProduct(new int[]{-1, -1}));

            //LongestStringPalindrome str = new LongestStringPalindrome();
            //Console.WriteLine(str.LongestPalindrome("abdd"));

            //ClosestToZero c = new ClosestToZero();
            //Console.WriteLine(c.ClosestZero(new int[]{-9, 8, 2, -5, 7}));

            //StringCompression c = new StringCompression();
            //Console.WriteLine(c.Compress(new char[] {'a', 'a', 'b', 'b', 'c','c','c'}));

            //TestProgram t = new TestProgram();
            //var lst = t.getEven(new List<int>() {2, 4, 3, 5, 8, 9});
            //PrintArray(lst);

            var input = new string[] { "A0", "A7", "E0", "F", "E1", "F" };
            //var input = new string[] { "A0", "A1", "A2", "E0", "F", "E1", "F" };
            Solution s = new Solution();
            s.AddWeaponMap("Sword", "SHIKSHIK");
            var result = s.solution(input);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        private static void PrintArray(List<int> nums)
        {
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }

    }
}
