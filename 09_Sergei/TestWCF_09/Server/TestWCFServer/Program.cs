using System;
using System.ServiceModel;
using TestWCFLib;

namespace TestWCFServer
{
    internal class Program
    {
        private static void Main()
        {
            var host = new ServiceHost(typeof(Calc));
            host.Open();
            Console.WriteLine("Сервер запущен");
            Console.ReadKey();
            host.Close();
        }
    }
}
