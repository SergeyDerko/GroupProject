using System;

namespace _05_Array_SortBubblesMethod
{
    class Program
    {
        static void Main()
        {
            Console.Write("\n Вывод одномерного масива и его сортировка!\n Введите количество елементов массива: ");
            var quantity = Console.ReadLine();
            int verify;
            if (!string.IsNullOrEmpty(quantity) && int.TryParse(quantity, out verify))
            {
                var arr = new int[int.Parse(quantity)];
                var randomnumber = new Random();
                for (var i = 0; i < arr.Length; i++)
                {
                    arr[i] = randomnumber.Next(1, 100);
                }
                Console.WriteLine("\n Массив рандомных чисел от 1 до 100: \n");
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
            }
            else
            {
                Console.WriteLine(" Вы ввели некоректное значение!");
            }

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
