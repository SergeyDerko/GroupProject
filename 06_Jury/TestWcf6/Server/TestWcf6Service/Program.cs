using System;
using System.ServiceModel;
using TestWcf6Common;
using TestWcf6Lib;

namespace TestWcf6Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Uri("http://localhost:555/ICalc");
            var binding = new BasicHttpBinding();
            var contract = typeof(ICalc);

            var host = new ServiceHost(typeof(Calc));
            host.AddServiceEndpoint(contract, binding, address);
            host.Open();

            Console.WriteLine("Сервер запущен");
            Console.ReadKey();

            host.Close();
        }
    }
}
