using System;
using System.ServiceModel;
using ExchangeRatesServiceLib;

namespace ExchangeRatesClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ExchangeRatesClient client = new ExchangeRatesClient();

            // Use the 'client' variable to call operations on the service.

            // Always close the client.
            client.Close();






            //var channel = new ChannelFactory<IExchangeRates>(new BasicHttpBinding(), new EndpointAddress("http://localhost:555/ExchangeRates")).CreateChannel();
            //var result = channel.CurrentExchangeRates();
            //Console.WriteLine(result);
            //Console.ReadKey();
        }
    }
}