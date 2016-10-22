using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
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
