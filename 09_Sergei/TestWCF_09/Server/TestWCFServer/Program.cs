using System;
using System.ServiceModel;
using TestWCFLib;

namespace TestWCFServer
{
    public class Program
    {
        private static void Main()
        {
            var host = new ServiceHost(typeof(Calc));
            host.Open();
            Console.Title = "Server";
            Console.WriteLine("Сервер запущен");
            Console.ReadKey();
            host.Close();
        }
    }
}
