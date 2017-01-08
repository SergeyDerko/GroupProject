using System;
using System.Configuration;
using System.ServiceModel;
using ExchangeRatesClientLibrary.ExchangeRatesServiceReference;

namespace TestWcfSite.Models.Yuriymodels
{
    public class ExchangeRates
    {
        public ExchangeRates()
        {
            try
            {
                var client = new ExchangeRatesClient();
                CurrentExchange = client.CurrentExchangeRates();
                client.Close();
            }
            catch (EndpointNotFoundException)
            {
                CurrentExchange = "Сервис Exchange Rates не запущен! :(";
            }
        }

        public string CurrentExchange { get; private set; }
    }
}