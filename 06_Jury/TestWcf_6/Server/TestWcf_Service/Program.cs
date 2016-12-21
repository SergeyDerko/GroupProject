using System;
using System.IO;
using System.Net;
using System.ServiceProcess;
using Common;
using TestWcf_Service.Windows_service;

namespace TestWcf_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += UnhandledExceptionHandler;
            Initlog(); // инициализация логгера
            var svc = new TestWcfService();
            if (Array.IndexOf(args, "console") != -1 || Array.IndexOf(args, "c") != -1) // if debug
            {
                Console.Title = "---SERVER---";
                var controller = new ServiceController(Path.GetFileNameWithoutExtension(typeof(Program).Assembly.CodeBase));
                controller.Start(); // старт службы
                var ipadress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[2]; // определение ip-адреса 
                Console.WriteLine($" Сервер запущен!\n Ip-адрес сервера: {ipadress}\n Нажмите любую клавишу для остановки сервера...");
                Console.ReadKey(true);
                controller.Stop();
                Console.Write(" Сервер остановлен!");
               
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
            Logger.Write(Level.Info, "Старт службы!");
        }

        #endregion
    }
}
