using System;

namespace Basics_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            string specialization;
            int age;

            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            surname = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите вашей специализацию: ");
            specialization = Console.ReadLine();

            Console.WriteLine($"Ваше имя - {name}. Ваша фамилия - {surname}." +
                $"\nВаш возраст составляет {age} лет.\nСпециализация - {specialization}");
        }
    }
}
