using System;

namespace _07_10_AnotherArray
{
    class Program
    {
        static void Main(string[] args)
        {
           
             
            int[,] array = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(0, 10);
                    Console.Write("{0}\t", array[i, j]);
                }
            }
            Console.ReadLine();

        }
    }
}
