using System.Collections.Generic;

namespace CustomDataStructures
{
    public class MyQueue
    {

        private Stack<int> firstStack;
        private Stack<int> secondStack;

        /** Initialize your data structure here. */
        public MyQueue()
        {
            firstStack = new Stack<int>();
            secondStack = new Stack<int>();

        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            firstStack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            Peek();
            return secondStack.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (secondStack.Count == 0)
            {
                while (firstStack.Count != 0)
                {
                    secondStack.Push(firstStack.Pop());
                }
            }

            return secondStack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return firstStack.Count == 0 && secondStack.Count == 0;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
