using System;

namespace lesson11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n" + new string('-', 20) + "Калькулятор арифметических выражений" + new string('-', 20));
            //Чтение файла
            var file = new FileInOut(@"../../Input.txt");
            //Вывод результата чтения в консоль 
            file.Show();
            //Приведение  в формат для сепаратора
            var example = file.WriteToSeparator();
            //Отправка в сепаратор для решения
            var separator = new Separator(example);
            //Приведение формат для записи в файл 
            var result = separator.WriteOutSeparator();
            //Запись в файл
            var outfile = new FileInOut(@"../../Output.txt", result);
            //Вывод на консоль
            outfile.ShowResult();

            Console.ReadKey();

        }
        
    }
}
