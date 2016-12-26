using System;
using System.ServiceModel;

namespace WCFTest12
{
    class Program
    {
        static void Main()
        {
            var host = new ServiceHost(typeof(Calc));
            host.Open();

            Console.WriteLine("Сервер запущен");
            Console.ReadKey();

            host.Close();
        }
    }
}
