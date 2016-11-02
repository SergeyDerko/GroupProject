using System;
using _10_Calculation_InOOP.modal;

namespace _10_Calculation_InOOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n" + new string('-', 27) + "Калькулятор арифметических выражений" + new string('-', 27) +
                              "\n\n"
                              + new string('-', 90) + "\n Порядок арифметических действий в выражении без скобок:\n" +
                              " Cначала выполняют по порядку (слева направо) умножение и деление, а затем сложение и вычитание.\n" +
                              new string('-', 90));
            //Чтение файла
            var file = new FileInOut(@"../../files/Input.txt");
            //Вывод результата чтения в консоль 
            file.Show();
            //Приведение  в формат для сепаратора
            var example = file.WriteToSeparator();
            //Отправка в сепаратор для решения
            var separator = new Separator(example);
            //Приведение формат для записи в файл 
            var result = separator.WriteOutSeparator();
            //Запись в файл
            var outfile = new FileInOut(@"../../files/Output.txt", result);
            //Вывод на консоль
            outfile.ShowResult(example);

            Console.ReadKey();
        }
    }
}
