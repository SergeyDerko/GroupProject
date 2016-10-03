using System;


namespace _06_10_Random2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = 5;
            var l = 10;
            int[][] array = new int[h][];
            for (int i = 0; i < h; i++)
            {
                array[i] = new int[l];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = new Random().Next(0, 9);
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    System.Threading.Thread.Sleep(100);
                    array[i][j] = new Random().Next(0, 9);
                    Console.Write("\t{0}", array[i][j]);

                }
                Console.WriteLine();
            }



        }
    }
}
