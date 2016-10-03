using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_New
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Привет Arr!");
            Console.Write("Введите высоту:");
            int x = Int32.Parse(Console.ReadLine());
          Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red ;
            int y = 10;
            var arr = new int[x, y];
            Random r = new Random();
            Random ra = new Random();
            for (int i = 0; i < x; i++)
            {
                y = ra.Next(1, 10);    
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = r.Next(1, 10);
                    Console.Write("{0}\t", arr[i,j]);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
       
    }
}
