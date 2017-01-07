using ExchangeRatesClientLibrary.ExchangeRatesServiceReference;

namespace TestWcfSite.Models.Yuriymodels
{
    public class ExchangeRates
    {
        public ExchangeRates()
        {
            var client = new ExchangeRatesClient();
            CurrentExchange = client.CurrentExchangeRates();
            client.Close();
        }

        public string CurrentExchange { get; private set; }
    }
}