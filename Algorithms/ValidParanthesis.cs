using System.Collections.Generic;

namespace Algorithms
{
    public class ValidParanthesis
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    default:
                        if (stack.Count == 0 || s[i] != stack.Pop())
                        {
                            return false;
                        };
                        break;
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
