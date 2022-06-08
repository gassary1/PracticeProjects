using System;

namespace Basics_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int counOfDiamond;
            int priceOfDiamond = 15;

            Console.Write("Введите имеющееся количество золота: ");
            gold = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Добро пожаловать! Сегодня алмазы стоят {priceOfDiamond} золотых.\nСколько алмахов вы хотите купить? ");
            counOfDiamond = Convert.ToInt32(Console.ReadLine());

            gold -= priceOfDiamond * counOfDiamond;

            Console.WriteLine($"Вы купили {counOfDiamond} алмазов. У вас осталось {gold} золота");
            Console.ReadLine();
        }
    }
}
