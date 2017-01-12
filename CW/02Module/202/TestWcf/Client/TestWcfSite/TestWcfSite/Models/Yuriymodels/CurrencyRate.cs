using System.Collections.Generic;
using CurrencyRateClientLibrary.CurrencyRateServiceReference;

namespace TestWcfSite.Models.Yuriymodels
{
    public class CurrencyRate
    {
        public List<Currency> Current { get; private set; }

        public CurrencyRate()
        {
            var client = new CurrencyRateClient();
            Current = new List<Currency>(client.CurrentRate());

            client.Close();
        }
    }
}