namespace CustomDataStructures
{
    public class MyHashSet
    {

        private bool[][] arr;
        private int buckets;
        private int bucketItems;

        /** Initialize your data structure here. */
        public MyHashSet()
        {
            buckets = 1000;
            bucketItems = 1000;
            arr = new bool[buckets][];
        }

        public int Bucket(int key)
        {
            return key % buckets;
        }

        public int BucketItem(int key)
        {
            return key / bucketItems;
        }

        public void Add(int key)
        {
            var bucket = Bucket(key);
            var bucketItem = BucketItem(key);
            if (arr[bucket] == null)
            {
                if (bucket == 0)
                {
                    arr[bucket] = new bool[bucketItems + 1];
                }
                else
                {
                    arr[bucket] = new bool[bucketItems];
                }
            }
            arr[bucket][bucketItem] = true;
        }

        public void Remove(int key)
        {
            var bucket = Bucket(key);
            var bucketItem = BucketItem(key);
            if (arr[bucket] == null) return;
            arr[bucket][bucketItem] = false;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            var bucket = Bucket(key);
            var bucketItem = BucketItem(key);
            if (arr[bucket] == null)
            {
                return false;
            }
            return arr[bucket][bucketItem];
        }
    }

    /**
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     */
}
