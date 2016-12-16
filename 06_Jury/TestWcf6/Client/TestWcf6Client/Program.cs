using System;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestWcf6Common;

namespace TestWcf6Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CLIENT";
            Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);

            var factory = new ChannelFactory<ICalc>(new BasicHttpBinding(),
                new EndpointAddress("http://localhost:555/ICalc"));
            var channel = factory.CreateChannel();

            var random = new Random();
            var a = random.Next(1, 99);
            var b = random.Next(100, 1000);
            var sum = channel.Sum(a, b);
            Console.WriteLine($"{a} + {b} = {sum}");

            Console.ReadKey();
            //for (var i = 0; i < 10; i++)
            //{
            //    for (var j = 0; j < 10; j++)
            //    {
            //        Thread.Sleep(1000);
            //        var sum = channel.Sum(i, j);
            //        Console.WriteLine($"{i} + {j} = {sum}");
            //    }
            //}
        }
    }
}
