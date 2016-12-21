using System;
using System.ServiceModel;
using System.Threading;
using TestWCFCommon;

namespace TestWcfClient
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);
            var address = new Uri("http://localhost:555/ICalc");
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(address);

            var factory = new ChannelFactory<ICalc>(binding, endpoint);
            var channel = factory.CreateChannel();
            var r = new Random();
            
            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                var a = r.Next(1, 1000);
                var b = r.Next(1, 1000);
                
                var sum = channel.Sum(a, b);
                Console.WriteLine($"{a} + {b} = {sum}");
            }
            Console.ReadKey();
        }
    }
}
