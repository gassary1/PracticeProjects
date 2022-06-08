using System;

namespace Operators_and_cycles_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int startResult;
            int maxResult = 98;
            int factor = 1;

            for (startResult = 7; result < maxResult; factor++)
            {
                result = startResult * factor;
                Console.WriteLine(result);
            }
        }
    }
}
