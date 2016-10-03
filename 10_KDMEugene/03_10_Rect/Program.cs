using System;

namespace _03_10_Rect
{
    public class Program
    {
        // для возврата ввода вручную
        // private static void Main()
        static void Main(string[] args)


        {
            do
            {
                
      
            Console.WriteLine("Height: " + args[0]);
            // для возврата ввода вручную
            // var height = int.Parse(Console.ReadLine());
            var height = int.Parse(args[0]);
            Console.WriteLine("Length: " + args[1]);
            // для возврата ввода вручную
            //  var length = int.Parse(Console.ReadLine());
            var length = int.Parse(args[1]);
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
            } while(Console.ReadKey().Key == ConsoleKey.Escape);
        }
    }
}