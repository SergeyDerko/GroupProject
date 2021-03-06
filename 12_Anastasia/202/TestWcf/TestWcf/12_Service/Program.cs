﻿using System;
using System.IO;
using System.ServiceProcess;
using Common;

namespace TestService
{
    class Program
    {
        /// <summary>
        ///     Главная точка входа в программу
        /// </summary>
        static void Main(string[] args)
        {
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
                {
                    Directory.CreateDirectory(Logger.Dir);
                }
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
    }
}
