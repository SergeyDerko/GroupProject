using System;

namespace _02_calc
{
    class Program
	{
		static void Main(string[] args)
		{
            do
            {
                Console.WriteLine("Input 1st value:");
                // float x = float.Parse(Console.ReadLine());
                var x = float.Parse(args[0]);
                var y = float.Parse(args[2]);
                var z = args[1];
                Console.WriteLine("Input 2nd value:");
                // float y = float.Parse(Console.ReadLine());
                Console.WriteLine("Which operation we want to do?");
                // string z = Console.ReadLine();
                if (z == "+")
                {
                    Console.WriteLine(x + y);
                }
                else if (z == "-")
                {
                    Console.WriteLine(x - y);
                }
                else if (z == "*")
                {
                    Console.WriteLine(x * y);
                }
                else if (z == "/" && y > 0)
                {
                    Console.WriteLine(x / y);
                }
                else
                {
                    Console.WriteLine("Soryan, something went wrong");
                }

            } while ((Console.ReadKey().Key == ConsoleKey.Escape));

        }
    }
}
