using System.Collections.Generic;
using System.Linq;

namespace CustomDataStructures
{
    public class MinStack
    {
        /** initialize your data structure here. */
        private Dictionary<int, int> map;
        private int index;

        public MinStack()
        {
            map = new Dictionary<int, int>();
        }

        public void Push(int val)
        {
            if (map.Keys.Count() == 0)
            {
                index = 1;
            }
            else
            {
                index = map.Keys.Max() + 1;
            }
            map.Add(index, val);
        }

        public void Pop()
        {
            if (map.Count == 0)
            {
                return;
            }
            map.Remove(map.Keys.Max());
        }

        public int Top()
        {
            if (map.Count == 0)
            {
                return -1;
            }
            map.TryGetValue(map.Keys.Max(), out int value);
            return value;
        }

        public int GetMin()
        {
            return map.Values.Min();
        }
    }

}
