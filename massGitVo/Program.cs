using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace massGitVo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту:");
            int hight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину:");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[][] arrey = new int[hight][];
            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i] = new int[lenght];
                for (int j = 0; j < arrey[i].Length; j++)
                {
                    arrey[i][j] = new Random().Next(0, 9);
                    Thread.Sleep(50);
                }
            }
            for (int i = 0; i < arrey.Length; i++)
            {
                for (int j = 0; j < arrey[i].Length; j++)
                {
                    Console.Write(arrey[i][j]);
                }
                Console.WriteLine();
            }
        } 

        
    }
}
                   

