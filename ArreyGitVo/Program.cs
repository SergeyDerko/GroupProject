using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreyGitVo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = 8;
            int hight = 4;
            int [][] arrey = new int [hight] [];
            for (int i = 0; i < arrey.Length; i++)
            {
                arrey = new int[i][];
                for (int j = 0; j < hight; j++)
               {
                arrey [i][j] = 0;
               }
            }
            for (int i = 0; i < arrey.Length; i++)
            {
                arrey = new int[i][];
                for (int j = 0; j < hight; j++)
                {
                    Console.Write(arrey[i][j] );
                }
                Console.WriteLine();
            }
        }
}
