using System;

namespace lesson11
{
    class Program
    {
        static void Main()
        {

            string name, lastname;
            int age;
            Console.WriteLine("Введiть iм'я");
            name = Console.ReadLine();

            Console.WriteLine("Введiть прiзвище");
            lastname = Console.ReadLine();

            Console.WriteLine("Введiть вiк");
            age = Convert.ToInt32(Console.ReadLine());

            //Читаем файл
            var file = new FileInOut(@"../../Input.txt");
            //Вывод в консоль результат чтения
            file.Show();
            //Отправляем в сепаратор для решения
            var example = file.WriteToSeparator();
            var separator = new Separator(example);
            //Вывод промежуточного результата
            separator.ShowSeparate();
            //отправляем на запись в файл и выводим на консоль
            var result = separator.WriteOutSeparator();
            var outfile = new FileInOut(@"../../Output.txt", result);
            outfile.ShowResult();

            Console.ReadKey();

        }
        
    }
}
