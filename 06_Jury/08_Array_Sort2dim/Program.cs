using System;
namespace _08_Array_Sort2dim
{
    class Program
    {
        static void Main()
        {
            var x = 10;
            var y = 5;
            var arr = new int[y, x];
            var random = new Random();
            Console.WriteLine("\n Двумерный массив рандомных чисел от 1 до 100 размерность, 5х10: \n");
            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    arr[i, j] = random.Next(1, 100);
                }
            }

            Output(x, y, arr);

            Console.WriteLine("\n Отсортированый по строкам двумерный массив: \n");
            for (var i = 0; i < y; i++)
                for (var j = 0; j < x - 1; j++)
                {
                    for (var k = j; k < x; k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            var tmp = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = tmp;
                        }
                    }
                }

            Output(x, y, arr);
            Console.WriteLine("\n Отсортированый по столбцам двумерный массив: \n");





            Console.ReadKey();
        }
        private static void Output(int x, int y, int[,] arr)
        {
            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    Console.Write($"\t {arr[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
