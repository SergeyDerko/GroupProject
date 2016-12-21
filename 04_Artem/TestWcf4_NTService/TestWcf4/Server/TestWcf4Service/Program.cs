using System;
using System.ServiceModel;
using TestWcf4Common;
using TestWcf4Lib;

namespace TestWcf4Service
{
    class Program
    {
        static void Main()
        {
            
            //var address = new Uri("http://localhost:555/ICalc");
            //var binding = new BasicHttpBinding();
            //var contract = typeof(ICalc);

            var host = new ServiceHost(typeof(Calc));
            //host.AddServiceEndpoint(contract, binding, address);
            host.Open();

            Console.WriteLine("Сервер запущен");
            Console.ReadKey();

            host.Close();
        }
    }
}
