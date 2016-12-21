using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TestWcf4Common;
using TestWcf4Lib;

namespace TestWcf4Service
{
    class Program
    {
        static void Main(string[] args)
        {

            var host = new ServiceHost(typeof(Calc));
            
            host.Open();

            Console.WriteLine("Сервер запущен");
            Console.ReadKey();

            host.Close();
        }
    }
}
