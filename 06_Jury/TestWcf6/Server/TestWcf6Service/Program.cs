using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceModel;
using TestWcf6Common;
using TestWcf6Lib;

namespace TestWcf6Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SERVER";

            var host = new ServiceHost(typeof(Calc));
            host.Open();
            var ipadress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[2];

            Console.WriteLine($"Сервер запущен! ip: {ipadress}");
            Console.ReadKey();

            host.Close();
        }
    }
}
