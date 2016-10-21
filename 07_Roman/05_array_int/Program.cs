using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_array_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество колонок=>");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество строк=>");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array=new int[50,50];
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            { 
                for (int j = 0; j < m; j++)
                {
                    array[i,j] = ran.Next(1,9);
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
