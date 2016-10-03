using System;

namespace _05_randomArray
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter the length:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            var y = Convert.ToInt32(Console.ReadLine());
            var rand = new Random();

            var table = new int[x, y];

            var sum = 0;

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    table[i, j] = rand.Next(0, 100);
                    // выводим рандомные элементы от 0 до 100 (например)
                    Console.Write("{0}\t", table[i, j]);

                    sum += table[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sum of this array is " + sum);


            Console.ReadKey();
        }
    }
}