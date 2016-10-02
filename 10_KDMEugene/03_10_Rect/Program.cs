using System;

namespace _03_rectanglee
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Height: ");
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine("Length: ");
            var length = int.Parse(Console.ReadLine());
            if (length <= 0 || height <= 0)
            {
                Console.WriteLine("Soryan, pryamougolnika ne budet ");
                Console.ReadKey();
            }
            else
            {
                for (var l = 0; l < height; l++)
                {
                    for (var h = 0; h <= length - 1; h++)
                        if (h == 0 || l == 0 || h == length - 1 || l == height - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}