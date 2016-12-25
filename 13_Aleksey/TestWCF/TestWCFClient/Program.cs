using System;
using System.ServiceModel;
using System.Threading;
using TestWCFCommon;

namespace TestWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);

            //var address = new Uri("http://localhost:777/ICalc");
            //var binding = new BasicHttpBinding();
            //var endpoint = new EndpointAddress(address);
            //var factory = new ChannelFactory<ICalc>(binding, endpoint);
            var factory = new ChannelFactory<ICalc>("WSHttpBinding_ICalc");
            var channel = factory.CreateChannel();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Thread.Sleep(1000);

                    var sum = channel.Sum(i, j);
                    var sub = channel.Sub(i, j);
                    var div = channel.Div(i, j);
                    var mult = channel.Mult(i, j);
                    Console.Write(($"{i}+{j}={sum}"));
                    Console.Write(($"   {i}-{j}={sub}"));
                    Console.Write(($"   {i}/{j}={div}"));
                    Console.WriteLine(($"   {i}*{j}={mult}"));
                }
            }

        }
    }
}
