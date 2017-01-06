using System.ServiceModel;
using ExchangeRatesClientLibrary.ServiceReference1;

namespace TestWcfSite.Models.Yuriymodels
{
    public class ExchangeRates
    {
        public string CurrentExchange { get; set; }

        public ExchangeRates()
        {
            var channel = new ChannelFactory<IExchangeRates>(new BasicHttpBinding(), new EndpointAddress("http://localhost:555/ExchangeRates")).CreateChannel();
            CurrentExchange = channel.CurrentExchangeRates();

            //var client = new ExchangeRatesClient();
            //CurrentExchange = client.CurrentExchangeRates();
            //client.Close();
        }
    }
}