using System;

namespace _03_tree
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Малюємо ялинку");
            int width = int.Parse(Console.ReadLine());
            for (int i = width; i > 0; i--)
            {
                for (int j = width - i; j < width; j++)
                {
                    Console.Write(" "); 
                }
                for (int j = 0; j < width - i; j++)
                {
                    Console.Write("/");
                }
                for (int j = 0; j < width - i; j++)
                {
                    Console.Write("\\");
                }
                Console.WriteLine();

            }
            for (int i = width - 1; i > 0; i--)
            {
                Console.Write(" ");
            }
            Console.Write("||");
            Console.ReadKey();
        }
    }
}
