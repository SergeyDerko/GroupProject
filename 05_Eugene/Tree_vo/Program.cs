using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_vo
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 0; i < 50; i++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*");
            
            for (var i = 0; i < 49; i++)
            {
                Console.WriteLine(" ");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***");
        

        }
    }
}
