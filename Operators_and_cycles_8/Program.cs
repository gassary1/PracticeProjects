using System;

namespace Operators_and_cycles_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "020395";
            string userInput = string.Empty;
            int tryCount = 3;

            for (int i = 0; i < tryCount; i++)
            {
                Console.Write($"Для досутпа у вас есть {tryCount} попыток. Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Торжественно клянусь, что замышляю только шалость");
                }
                else
                {
                    Console.WriteLine($"Доступ запрещен. Количество попыток равно - {tryCount - i - 1}");
                }
            }
        }
    }
}
