using System;
using static System.Console;

namespace _05_array_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите количество колонок=>");
            int m = Convert.ToInt32(ReadLine());
            Write("Введите количество строк=>");
            int n = Convert.ToInt32(ReadLine());
            int[,] array = new int[50, 50];
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = ran.Next(1, 9);
                    Write(array[i, j] + " ");
                }
                WriteLine();
            }
            ReadKey();
            for (int k = 1; k <= n; k++)
            {

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m-1; j++)
                    {
                        if (array[k,j] < array[k,j + 1])
                        {
                            int z = array[k,j];
                            array[k, j] = array[k, j + 1];
                            array[k, j + 1] = z;
                        }
                    }
                    WriteLine();
                }
                

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Write(array[i, j] + " ");
                }
                WriteLine();
            }
            ReadKey();
        }
    }
}
