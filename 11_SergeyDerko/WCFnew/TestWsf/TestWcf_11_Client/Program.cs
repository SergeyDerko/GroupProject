﻿using System;
using System.ServiceModel;
using System.Threading;
using TestWsf_11_Common;

namespace TestWcf_11_Client
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
                for (int j = 0; j < 10; j++)
                {
                    Thread.Sleep(1000);
                    var sum = channel.Sum(i, j);
                    Console.WriteLine($"{i} + {j} = {sum}");
                }
            }
            Console.ReadKey();
        }
    }
}
