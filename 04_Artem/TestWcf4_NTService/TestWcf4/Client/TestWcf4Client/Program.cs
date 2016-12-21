using System;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestWcf4Common;


namespace TestWcf4Client
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
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Thread.Sleep(1000);
                    var sum = channel.Sum(i, j);
                    Console.WriteLine($"{i} + {j} = {sum}");

                    var sub = channel.Sub(i, j);
                    Console.WriteLine($"{i} - {j} = {sub}");

                    var mul = channel.Mul(i, j);
                    Console.WriteLine($"{i} * {j} = {mul}");

                    var div = channel.Div(i, j);
                    Console.WriteLine($"{i} / {j} = {div}");

                    
                }
            }
            Console.ReadKey();
        }
        
    }
}