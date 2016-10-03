using System;
using System.Threading;

namespace _04_Flag
{
    class Program
    {
        static void Line(int x)
        {
            var count = 0;
            var format = "*";
            Line(x, count, format);
            Console.WriteLine();

        }
        private static void Line(int x, int count, string str)
        {
            while (count++ < x)
            {
                Console.Write(str);
            }
        }

        static void Main()
        {
            Console.WriteLine("Вас вiтає програма  V1.0");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("'Укра");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("iна'");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ");
            Console.WriteLine("Введiть ширину :");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введiть высоту : ");
            int y;
            y = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Line(x);
            int count1;
            {
                count1 = 2;
                while (count1++ < y / 2)
                {
                    Console.Write("*");
                    var count = 2;
                    Line(x, count, "*");
                    Console.Write("*");
                    Console.WriteLine();

                }
            }
            {
                Line(x);
            }
            // Вторая часть
            Console.ForegroundColor = ConsoleColor.Yellow;
            Line(x);
            count1 = 2;
            while (count1++ < y / 2)
            {
                Console.Write("*");
                var count = 2;
                Line(x, count, "*");
                Console.Write("*");
                Console.WriteLine();

            }
            {
                Line(x);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Слава Украiнi!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            var z = Console.ReadLine();
            Console.WriteLine();
            if (z == "Героям Слава!")
                for (int i = 0, j = Console.WindowWidth; i < Console.WindowWidth; i++, j--)
                {
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Слава Украiнi!");
                    Console.WriteLine();
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Героям Слава!");
                    Thread.Sleep(100);
                    Console.Clear();
                }
            Console.ReadKey();
        }
    }
}
