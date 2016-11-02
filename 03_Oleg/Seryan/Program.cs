using System.ServiceProcess;
using System;

namespace Seryan
{
    class Program
    {
        static void Main(string[] args)
        {
            /*AppDomain currentDomain = AppDomain.CurrentDomain;
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
            Console.WriteLine(ex == null ? "Error!" : $"{method}\n{ex}");*/
            /*for(int i = 0; i <100; i++)
            {
                Console.WriteLine((char)i);
            }
            Console.ReadLine();*/
            string df = "4+5";
            var m = df.IndexOf("+");
            int fg = ((int)(df[m] - 1)-39) + ((int)(df[m] + 1)-39);
            Console.WriteLine(fg);
            //Console.WriteLine(((int(string))'4')));
            Console.ReadLine();

            var stack = new 
            
        }
    }
}
