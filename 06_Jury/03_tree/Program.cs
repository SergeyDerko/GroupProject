using System;

namespace tree
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            var number = Console.ReadLine();
            int verify;
            if (!string.IsNullOrEmpty(number) && int.TryParse(number, out verify))
            {
                var height = int.Parse(number);
                var width = height / 2 - 1;
                var randomcolor = new Random();
                Console.Clear();
                for (var i = 0; i < height; i++)
                {
                    for (var j = 0; j <= (width + i / 2); j++)
                    {
                        if (j < (width - i / 2))
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.ForegroundColor = (ConsoleColor)randomcolor.Next(1, 16);
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Вы ввели некоректное значение!");
            }
            Console.ReadKey();

        }
    }
}
