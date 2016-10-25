using System;
using System.Threading;

namespace _10_Calc_Modul
{
    internal class Program
    {
        private static void Main()
        {
            string tab2 = new string('\t', 2);
            string tab5 = new string('\t',5);
            startmenu:
            Console.Write(new string('\t', 2) + "Программа для считывания с файлов данные в виде математических выражений и их просчета.\n" +
            tab5 + "Меню:\n" +
            tab5 + "1. Старт.\n" +
            tab5 + "2. О программе.\n" +
            tab5 + "3. Автор\n" +
            tab5 + "4. Выход\n");
            switch(Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Start();//Метод старт программы        
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.Write(tab2 + "Программа сканирует директорию, и обрабатывает все файлы в ней"+"\n"+tab2+
                        ",находит там математическиевыражения считает их и сохраняет в определенный файл."+"\n"+tab2+
                        " После чего удаляет файл с которым отработала из данной директории.\n");
                    Console.ReadKey();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.Write(tab5 + "Created by Pikhota Serhii."+"\n"+tab5+ "all right reserved "+'\n');
                    Console.ReadKey();
                    break;
                case ConsoleKey.D4:
                    break;
                default:
                    Console.Clear();
                    goto startmenu;
            }
            
        }
        #region Start
        private static void Start()
        {
            do
            {
                var s = new ScanDirectory();
                s.Scan(s.PathDir);
                Thread.Sleep(20000);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        #endregion
    }
}
