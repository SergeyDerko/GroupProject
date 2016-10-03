using System;

namespace _05_randomArray
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the length:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            var y = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();

            int [,] table = new int[x, y];

            int sum = 0;

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    table[i, j] = rand.Next(0, 100);
                    Console.WriteLine("{0}\t", table[i, j]); 
                    // выводим рандомные элементы от 0 до 100 (например)
                    sum += table[i, j];
                }

            Console.WriteLine("Sum of this array is " + sum);
            

            Console.ReadKey();
        }
        
        }
}
