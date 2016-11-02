using System;


namespace _11_tile_and_wall
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new string('-', 20) + "Размеры стены" + new string('-', 20));
            Console.Write("Введите ширину стены: ");
            var wallWidth = Console.ReadLine();
            Console.Write("Введите высоту стены: ");
            var wallHeight = Console.ReadLine();

            Console.WriteLine(new string('-', 20) + "Размеры плитки" + new string('-', 20));
            Console.Write("Введите ширину плитки: ");
            var tileWidth = Console.ReadLine();
            Console.Write("Введите высоту плитки: ");
            var tileHeight = Console.ReadLine();

            
            var wallArea = double.Parse(wallWidth) * double.Parse(wallHeight);
            var tileArea = double.Parse(tileWidth) * double.Parse(tileHeight);

            Console.WriteLine(new string('-', 20) + "Количество плитки" + new string('-', 20));
            var tilecount =  wallArea / tileArea;
            Console.WriteLine(tilecount);

            Console.ReadKey();


        }
    }
}
