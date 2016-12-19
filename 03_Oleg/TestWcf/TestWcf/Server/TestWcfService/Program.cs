using System;
using System.IO;
using System.ServiceProcess;
using Common;
using System.Net;


namespace TestWcfService
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += UnhandledExceptionHandler;
            Initlog(); // инициализация логгера
            var svc = new MainService();
            if (Array.IndexOf(args, "console") != -1 || Array.IndexOf(args, "c") != -1) // debug
            {
                Console.Title = "---SERVER---";
                svc.StartSvc(); // старт службы
                var ipadress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1]; // определение ip-адреса 
                Console.WriteLine($" Сервер запущен!\n Ip-адрес сервера: {ipadress}\n Нажмите любую клавишу для остановки сервера...");
                Console.ReadKey(true);
                svc.StopSvc(); // остановка службы

                Console.Write(" Сервер остановлен!");
                Logger.Write(Level.Info, "Сервер остановлен!");
            }
            else // запуск службы windows
            {
                ServiceBase.Run(svc);
            }
        }

        #region Exception
        private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            const string method = "UnhandledExceptionHandler";
            var ex = (Exception)args.ExceptionObject;
            Console.WriteLine(ex == null ? "Error!" : $"{method}\n{ex}");
        }


        #endregion


        #region Инициализация логгера

        private static void Initlog()
        {
            Logger.Level = Config.Get.Log.Level;
            // Определение пути доступа к журналу событий
            try
            {
                Logger.Dir = Config.Get.Log.Dir;
                Directory.CreateDirectory(Logger.Dir); // если каталог не существует - создаст
            }
            catch
            {
            }
            Logger.Prefix = Config.Get.Log.Prefix;
            Logger.Start();
            Logger.Write(Level.Info, "Старт службы. Сервер запущен!");
        }

        #endregion
    }
}