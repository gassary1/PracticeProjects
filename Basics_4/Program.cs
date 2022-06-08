using System;

namespace Basics_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPictures = 52;
            int columns = 3;

            int fullRows = countOfPictures / columns;
            int remainOfPictures = countOfPictures % columns;

            Console.WriteLine($"Всего заполненных рядов - {fullRows}\nОстаток фотографии - {remainOfPictures}");
            Console.ReadLine();
        }
    }
}
