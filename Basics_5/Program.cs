using System;

namespace Basics_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Кругликов";
            string lastName = "Вадим";
            string tempString;

            Console.WriteLine($"Исходные данные: Имя - {name} Фамилия - {lastName}");

            tempString = name;
            name = lastName;
            lastName = tempString;

            Console.WriteLine($"Исходные данные: Имя - {name} Фамилия - {lastName}");
        }
    }
}
