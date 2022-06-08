using System;

namespace Operators_and_cycles_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfRepeat = 10;

            Console.Write("Введите любое сообщение: ");
            string message = Console.ReadLine();

            for (int i = 0; i < countOfRepeat; i++)
            {
                Console.WriteLine(message);
            }

            Console.ReadLine();
        }
    }
}
