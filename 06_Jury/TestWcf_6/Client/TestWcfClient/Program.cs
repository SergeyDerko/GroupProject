using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestWcfCommon;

namespace TestWcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "---CLIENT---";
            // Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine(" Приложение выполняет операцию сложения двух рандомных чисел.\n");

            var address = new Uri("http://localhost:555/ICalc");
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(address);

            var factory = new ChannelFactory<ICalc>(binding, endpoint);
            var channel = factory.CreateChannel();

            try
            {
                var random = new Random();
                for (var i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    var a = random.Next(1, 1000);
                    var b = random.Next(100, 1000);
                    var sum = channel.Sum(a, b);
                    Console.WriteLine($" {a} + {b} = {sum}");
                }
            }
            catch (EndpointNotFoundException)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(" Cервер не запущен!");
                Console.ResetColor();
            }

            Console.Write("\n Нажмите любую клавышу для выхода...");
            Console.ReadKey();

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Thread.Sleep(1000);
            //        var sum = channel.Sum(i, j);
            //        Console.WriteLine($"{i} + {j} = {sum}");
            //    }
            //}
        }
    }
}
