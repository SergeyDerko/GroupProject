using System;
using _10_Calculation_ScanDirectory.modal;

namespace _10_Calculation_ScanDirectory
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n" + new string('~', 27) + "Калькулятор арифметических выражений" + new string('~', 27) + "\n\n" +
                              @" Папка с файлами для сканирования: files\Tocount" + "\n"+
                              @" Папка с результатами: files\Result" + "\n"+
                              @" Папка с решенными примерами: files\Completed\" + "\n" +
                              new string('-', 90) + "\n Порядок арифметических действий в выражении без скобок:\n" +
                              " Cначала выполняют по порядку (слева направо) умножение и деление, а затем сложение и вычитание.\n" +
                              new string('-', 90));


            Scan.StartCalculation();

            Console.ReadKey();
        }
    }
}
