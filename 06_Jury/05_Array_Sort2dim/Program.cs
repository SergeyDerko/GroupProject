using System;


namespace _05_Array_Sort2dim
{
    class Program
    {
        static void Main()
        {
            Console.Write("\n Вывод двумерного массива, его наполнение и сортировка" +
                              "\n Задайте размерность массива!\n" +
                              "\n Введите количество строк: ");
            var row = Console.ReadLine();
            Console.Write(" Введите длину строки: ");
            var column = Console.ReadLine();
            int verify;
            if (int.TryParse(column, out verify) && int.TryParse(row, out verify) && !string.IsNullOrEmpty(column) && !string.IsNullOrEmpty(row))
            {
                var x = int.Parse(row);
                var y = int.Parse(column);
                var arr = new int[x, y];
                var random = new Random();
                Console.WriteLine($"\n Двумерный массив рандомных чисел от 1 до 100 размерность, {x}х{y}: \n");
                for (var i = 0; i < x; i++)
                {
                    for (var j = 0; j < y; j++)
                    {
                        arr[i, j] = random.Next(1, 100);
                    }
                }

                Output(x, y, arr);

                Console.WriteLine("\n Отсортированый по строкам двумерный массив: \n");
                for (var i = 0; i < x; i++)
                    for (var j = 0; j < y - 1; j++)
                    {
                        for (var k = j; k < y; k++)
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

                for (var j = 0; j < y; j++)
                    for (var i = 0; i < x - 1; i++)
                        for (var k = i; k < x; k++)
                            if (arr[i, j] > arr[k, j])
                            {
                                var tmp = arr[i, j];
                                arr[i, j] = arr[k, j];
                                arr[k, j] = tmp;
                            }
                Output(x, y, arr);

            }
            else
            {
                Console.WriteLine(" Вы ввели некоректное значение!");
            }

            Console.ReadKey();


        }
        private static void Output(int x, int y, int[,] arr)
        {
            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    Console.Write($"\t {arr[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
