using System;

namespace _07_Array_SortBubblesMethod
{
    class Program
    {
        static void Main()
        {
            var randomnumber = new Random();
            var arr = new int[10];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = randomnumber.Next(1, 100);
            }
            Console.WriteLine(" Массив рандомных чисел от 1 до 100: \n");
            Output(arr);
            Console.WriteLine("\n\n Отсортированый масив пузырьковым методом: \n");
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Output(arr);

            Console.ReadKey();

        }

        private static void Output(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write($" {i}");
            }

        }
    }
}
