using System;

namespace _07_tornArray
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter the length:");
            var x = Convert.ToInt32(Console.ReadLine());
            var rand = new Random();
            int y = 10;

            var table = new int[x, y];
            
                
            for (var i = 0; i < x; i++)
            {
                y = rand.Next(1, 10);
                for (var j = 0; j < y; j++)
                {
                    table[i,j] = rand.Next(0, 100);
                    // выводим рандомные элементы от 0 до 100 (например)
                    Console.Write("{0}\t", table[i,j]);
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}