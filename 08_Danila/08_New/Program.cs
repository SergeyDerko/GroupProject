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
       int[,] ar = new int[7,7];
            Random r = new Random();

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    ar[i,j] = r.Next(1, 49);
                    Console.Write("{0}\t", ar[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
       
    }
}
