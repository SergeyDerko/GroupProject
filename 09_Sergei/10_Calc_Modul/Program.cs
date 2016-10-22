namespace _10_Calc_Modul
{
    internal class Program
    {
        private static void Main( /*string[] args*/)
        {
            //StartProgram();

            MethodStart();
        }

        //#region StartProgram

        //private static void StartProgram()
        //{
        //    var exit = false;
        //    while (!exit)
        //    {
        //        var str = new string(' ', 40);
        //        Console.Write(
        //            str + "Меню \n"
        //            + str + "1.Старт программы.\n"
        //            + str + "2.Инструкция по использованию.\n"
        //            + str + "3.О программе.\n"
        //            + str + "4.Выход из программы.\n");
        //        switch (Console.ReadKey().Key)
        //        {
        //            case ConsoleKey.D1:
        //            {
        //                MethodStart();
        //                break;
        //            }
        //            case ConsoleKey.D2:
        //            {
        //                Console.Clear();
        //                Console.Write(str + "Программа еще не готова к полной работе поэтому инструкция будет позже.");
        //                Console.ReadKey();
        //                break;
        //            }
        //            case ConsoleKey.D3:
        //            {
        //                Console.Clear();
        //                Console.Write(str +
        //                              "Эта программа была сделана для решения матиматических выражений. Версия 0.8");
        //                Console.ReadKey();
        //                break;
        //            }
        //            case ConsoleKey.D4:
        //            {
        //                exit = true;
        //                break;
        //            }
        //            default:
        //                Console.Clear();
        //                Console.WriteLine("Сделайте выбор с помощью кнопок от 1 до 4.");
        //                break;
        //        }
        //    }
        //}

        //#endregion

        #region MethodStart

        private static void MethodStart()
        {
            var s = new ScanDirectory();
            s.Scan(s.PathDir);
        }

        #endregion
    }
}
