namespace CustomDataStructures
{
    public class MyHashMap
    {

        private int[][] arr;
        private int buckets;
        private int bucketItems;

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            buckets = 1000;
            bucketItems = 1000;
            arr = new int[buckets][];
        }

        //Hash function for first index
        public int bucket(int key)
        {
            return key % buckets;
        }

        //Hash function for second index (Nested index - index for the nested structure)
        public int bucketItem(int key)
        {
            return key / bucketItems;
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            var firstIndex = bucket(key);
            var secondIndex = bucketItem(key);
            if (arr[firstIndex] == null)
            {
                if (firstIndex == 0)
                {
                    arr[firstIndex] = new int[bucketItems + 1];
                }
                else
                {
                    arr[firstIndex] = new int[bucketItems];
                }
            }
            if (value == 0)
            {
                arr[firstIndex][secondIndex] = value - 2;
            }
            else
            {
                arr[firstIndex][secondIndex] = value;
            }

        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            var firstIndex = bucket(key);
            var secondIndex = bucketItem(key);
            if (arr[firstIndex] == null || arr[firstIndex][secondIndex] == 0)
            {
                return -1;
            }
            if (arr[firstIndex][secondIndex] == -2)
            {
                return 0;
            }
            return arr[firstIndex][secondIndex];
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            var firstIndex = bucket(key);
            var secondIndex = bucketItem(key);
            if (arr[firstIndex] == null || arr[firstIndex][secondIndex] == -1) return;
            arr[firstIndex][secondIndex] = -1;
        }
    }
 }
