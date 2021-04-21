using System;
using System.Text;

namespace Algorithms
{
    public class StringCompression
    {
        public int Compress(char[] chars)
        {

            StringBuilder build = new StringBuilder();

            char current = chars[0];
            int count = 1;
            for (int i = 1; i < chars.Length; i++)
            { //a

                if (current == chars[i])
                {
                    count++;
                }
                else
                {
                    build.Append(current);
                    if (count > 1)
                    {
                        build.Append(count.ToString());
                    }
                    current = chars[i];
                    count = 1;
                }
            }

            build.Append(current);
            if (count > 1)
            {
                build.Append(count.ToString());
            }

            Console.WriteLine(build.ToString());
            return build.ToString().Length;
        }
    }
}
