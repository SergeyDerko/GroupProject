using System;


namespace _11_tile_and_wall
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new string('-', 20) + "Размеры стены" + new string('-', 20));
            Console.WriteLine("Введите ширину стены: ");
            var wallWidth = Console.ReadLine();
            Console.WriteLine("Введите высоту стены: ");
            var wallHeight = Console.ReadLine();

            Console.WriteLine(new string('-', 20) + "Размеры плитки" + new string('-', 20));
            Console.WriteLine("Введите ширину плитки: ");
            var tileWidth = Console.ReadLine();
            Console.WriteLine("Введите высоту плитки: ");
            var tileHeight = Console.ReadLine();

            var wallArea = int.Parse(wallWidth) * int.Parse(wallHeight);
            var tileArea = int.Parse(tileWidth) * int.Parse(tileHeight);

            Console.WriteLine(new string('-', 20) + "Количество плитки" + new string('-', 20));
            var tilecount = wallArea / tileArea;
            Console.WriteLine(tilecount);

            Console.ReadKey();


        }
    }
}
