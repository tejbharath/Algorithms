using System;
using System.Linq;

namespace Algorithms
{
    public class ShuffleArray
    {
        private readonly Random _rand;
        private readonly int[] initialArray;
        private readonly int[] copiedArray;

        public ShuffleArray(int[] nums)
        {
            _rand = new Random();
            initialArray = new int[nums.Length];
            copiedArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                initialArray[i] = nums[i];
            }
        }

        public int GetRandomNumber(int n)
        {
            return _rand.Next(0, n);
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return initialArray;
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            //var arr = initialArray; // Don't assign a variable to an array. It just points to the memory location of the original array
            var arr = CopyArray();
            Swap(GetRandomNumber(arr.Length - 1), GetRandomNumber(arr.Length - 1), arr);

            if (Enumerable.SequenceEqual(arr,copiedArray))
            {
                Swap(GetRandomNumber(arr.Length - 1), GetRandomNumber(arr.Length - 1), arr);
            }
            return arr;
        }

        private int[] CopyArray()
        {
            var tempArr = new int[initialArray.Length];
            for (int i = 0; i < initialArray.Length; i++)
            {
                tempArr[i] = initialArray[i];
                copiedArray[i] = initialArray[i];
            }

            return tempArr;
        }

        public void Swap(int left, int right, int[] numbers)
        {
            var temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;
        }

    }
}
