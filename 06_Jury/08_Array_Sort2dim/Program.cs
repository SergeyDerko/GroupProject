using System;
namespace _08_Array_Sort2dim
{
    class Program
    {
        static void Main()
        {
            var x = 10;
            var y = 5;
            var arr = new int[y,x];
            var random = new Random();
            Console.WriteLine("\n Двумерный массив рандомных чисел от 1 до 100 размерность, 5х10: \n");
            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    arr[i, j] = random.Next(1, 100);
                    Console.Write($"\t {arr[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Отсортированый двумерный массив: \n");

            
                       














            Console.ReadKey();
        }
    }
}
