using System;

namespace Operators_and_cycles_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActive = true;

            Console.WriteLine("Для выхода из программы наберите exit");

            while (isActive)
            {
                Console.Write("Введите любое сообщение: ");
                string message = Console.ReadLine();
                Console.WriteLine(message);

                if (message == "exit")
                {
                    isActive = false;
                }
            }
        }
    }
}
