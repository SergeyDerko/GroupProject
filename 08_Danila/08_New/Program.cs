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
            Console.WriteLine("enter first number");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int y = Int32.Parse(Console.ReadLine());
            int[,] ar = new int[x,y];
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    ar[i, j] = r.Next(1, 49);
                    Console.Write("{0}\t", ar[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
       
    }
}
