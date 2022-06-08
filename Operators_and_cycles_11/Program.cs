using System;

namespace Operators_and_cycles_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int deep = 0;
            int maxDeep = 0;

            Console.Write("Введите скобочное выраженение: ");
            input = Console.ReadLine();

            if (input.Length == 0)
            {
                Console.WriteLine("Строка пустая");
            }

            foreach (char symbol in input)
            {
                if (symbol == '(')
                {
                    deep++;

                    if (deep > maxDeep)
                    {
                        maxDeep = deep;
                    }
                }
                else if (symbol == ')')
                {
                    deep--;

                    if (deep < 0)
                    {
                        break;
                    }
                }
            }

            if (deep == 0 && input.StartsWith('('))
            {
                Console.WriteLine($"Скобочное выражение верное. Максимальная глубина равна - {maxDeep}");
            }
            else
            {
                Console.WriteLine("Скобочное выражение неверное!");
            }
        }
    }
}
