using System;


namespace _06_init_array
{
    class Program
    {
        static void Main()
        {
            Console.Write("\n ---Инициализация двумерного массива---" +
                          "\n\n Задайте размерность массива!" +
                          "\n Введите количество строк в массиве: ");
            var row = Console.ReadLine();
            Console.Write(" Введите длину строки массива: ");
            var column = Console.ReadLine();
            int verify;
            if (int.TryParse(column, out verify) && int.TryParse(row, out verify) && !string.IsNullOrEmpty(column) &&
                !string.IsNullOrEmpty(row))
            {
                var x = int.Parse(row);
                var y = int.Parse(column);
                var arr = new int[x, y];
                var random = new Random();
                Console.WriteLine($"\n Двумерный массив проинициализирован  рандомными числами от 1 до 100. Размерность, {x}х{y}: \n");
                for (var i = 0; i < x; i++)
                {
                    for (var j = 0; j < y; j++)
                    {
                        arr[i, j] = random.Next(1, 100);
                        Console.Write($"\t {arr[i, j]}");
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
