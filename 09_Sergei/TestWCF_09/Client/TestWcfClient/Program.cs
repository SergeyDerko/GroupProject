using System;
using System.ServiceModel;
using System.Threading;
using TestWCFCommon;



namespace TestWcfClient
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);
            var address = new Uri("http://localhost:555/ICalc");
            
            var factory = new ChannelFactory<ICalc>(new BasicHttpBinding(), new EndpointAddress(address));
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
