using System;
using System.ServiceModel;
using TestWcfCommon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFTest12
{
    class Program
    {
        static void Main()
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

    internal class Calc : ICalc
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
