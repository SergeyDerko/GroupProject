using System;


namespace _06_jaggedArray
{
    class Program
    {
        static void Main()
        {
            Console.Write("\n ---Вывод зубчатого двумерного массива---" +
                              "\n\n Задайте размерность массива!" +
                              "\n Введите количество строк: ");
            var row = Console.ReadLine();
            int verify;
            if (int.TryParse(row, out verify)&& !string.IsNullOrEmpty(row))
            {
                var random = new Random();
                var x = int.Parse(row);
                var random1 = new Random();
                int y = 15;
                var arr = new int[x, y];
                Console.WriteLine($"\n Двумерный зубчатый массив рандомных чисел от 1 до 100, размерностью {row} " +
                                  $"строк и рандомной длиной строки от 1 до 15: \n");
                
                for (var i = 0; i < x; i++)
                {
                    y = random1.Next(1, 15);
                    for (var j = 0; j < y; j++)
                    {
                        arr[i, j] = random.Next(1, 100);
                        Console.Write($" {arr[i, j]}\t ");
                    }
                    Console.WriteLine();
                }

               

            }
            else
            {
                Console.WriteLine(" Вы ввели некоректное значение!");
            }







            Console.ReadKey();
        }
    }
}
