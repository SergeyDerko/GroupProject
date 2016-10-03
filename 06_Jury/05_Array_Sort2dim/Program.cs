using System;


namespace _05_Array_Sort2dim
{
    class Program
    {
        static void Main()
        {
            Console.Write("\n Вывод двумерного массива, его наполнение и сортировка" +
                              "\n Задайте размерность массива!\n" +
                              "\n Введите количество столбцов: ");
            var column = Console.ReadLine();
            Console.Write(" Введите количество строк: ");
            var row = Console.ReadLine();
            int verify;
            if (int.TryParse(column, out verify) && int.TryParse(row, out verify)&&!string.IsNullOrEmpty(column)&& !string.IsNullOrEmpty(row))
            {
                var x = int.Parse(column);
                var y = int.Parse(row);
                var arr = new int[y, x];
                var random = new Random();
                Console.WriteLine($"\n Двумерный массив рандомных чисел от 1 до 100 размерность, {y}х{x}: \n");
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

                for (var j = 0; j < x; j++)
                    for (var i = 0; i < y - 1; i++)
                        for (var k = i; k < y; k++)
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
