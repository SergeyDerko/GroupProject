

using System;

namespace _07_SortArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Enter height: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            int width = int.Parse(Console.ReadLine());
            int[,] array = new int[height, width];
            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    array[i, j] = rand.Next(100);
                    Console.Write(" " + array[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
