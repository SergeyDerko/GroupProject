using System;
using System.IO;
using System.ServiceProcess;
using TestWsf_11_Common;
using System.ServiceModel;

namespace TestWsf_11_Servise
{
    class Program
    {
        /// <summary>
        ///     Главная точка входа в программу
        /// </summary>
        static void Main(string[] args)
        {


            var address = new Uri("http://localhost:555/ICalc");
            var binding = new BasicHttpBinding();

            var host = new ServiceHost(typeof(Calc));
            host.AddServiceEndpoint(typeof(ICalc), binding, address);
            host.Open();

            Console.WriteLine("Сервер запущен");
            Console.ReadKey();

            host.Close();

            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += UnhandledExceptionHandler;
            Init();
            var svc = new MainService();
            if (Array.IndexOf(args, "console") != -1 || Array.IndexOf(args, "c") != -1)
            {
                svc.StartSvc();
                Console.WriteLine("Press a key for exit...");
                Console.ReadKey(true);
                svc.StopSvc();
            }
            else
            {
                ServiceBase.Run(svc);
            }
        }

        private static void Init()
        {
            #region Инициализация логгера

            Logger.Level = Config.Get.Log.Level;

            // Определение пути доступа к журналу событий

            try
            {
                Logger.Dir = Config.Get.Log.Dir;
                if (!Directory.Exists(Logger.Dir))
                    Directory.CreateDirectory(Logger.Dir);
            }
            catch
            {
            }

            Logger.Prefix = Config.Get.Log.Prefix;
            Logger.Start();

            Logger.Write(Level.Info, "Старт сервера");

            #endregion

        }

        private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            const string method = "UnhandledExceptionHandler";
            var ex = (Exception)args.ExceptionObject;
            Console.WriteLine(ex == null ? "Error!" : $"{method}\n{ex}");
        }

        //sc create TestService binPath="w:\repos\GroupProject\CW\501\501_srv\bin\Debug\501_srv.exe" DisplayName= "TestServiceDisplayName"
    }
}
