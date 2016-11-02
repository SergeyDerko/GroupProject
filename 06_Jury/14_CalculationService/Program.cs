using System;
using System.ServiceProcess;

namespace _14_CalculationService
{
    class Program
    {
        /// <summary>
        ///     Главная точка входа в программу
        /// </summary>
        static void Main(string[] args)
        {
            var currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += UnhandledExceptionHandler;

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

        private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            const string method = "UnhandledExceptionHandler";
            var ex = (Exception)args.ExceptionObject;
            Console.WriteLine(ex == null ? "Error!" : $"{method}\n{ex}");
        }

        //sc create TestService binPath="w:\repos\GroupProject\CW\501\501_srv\bin\Debug\501_srv.exe" DisplayName= "TestServiceDisplayName"
    }
}
