using System;
using System.Threading;

namespace ColorsInWord
{
    internal class Program
    {
        private static void Main()
        {
            var rand = new Random();
            Console.WriteLine("Entering word: ");
            var word = Console.ReadLine();
            if (word != null)
            {
                var letters = word.ToCharArray();
                for (var i = 0; i <= letters.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        RandomColor(rand, letters, i);
                    }
                    else
                    {
                        var color = letters.Length % i;
                        if (color < 16)
                        {
                            Console.ForegroundColor = (ConsoleColor) color;
                            Console.Write(letters[i]);
                            Thread.Sleep(100);
                        }
                        else
                        {
                            RandomColor(rand, letters, i);
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        private static void RandomColor(Random rand, char[] letters, int i)
        {
            Console.ForegroundColor = (ConsoleColor)rand.Next(15) + 1;
            Console.Write(letters[i]);
            Thread.Sleep(100);
        }
    }
}



