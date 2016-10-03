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
            int hight = 10;
            int lenght = 5;
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

