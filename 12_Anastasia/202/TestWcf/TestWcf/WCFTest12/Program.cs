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
            var host = new ServiceHost(typeof(Calc));
            host.Open();

            Console.WriteLine("Сервер запущен");
            Console.ReadKey();

            host.Close();
        }
    }
}
