using System;

namespace ExchangeRatesServiceLib
{
    public class ExchangeRates : IExchangeRates
    {
        public string CurrentExchangeRates()
        {
            var random = new Random();
            var usd = random.Next(25, 30);
            var eur = random.Next(30, 35);
            return $"Usd = {usd}, Eur = {eur}";
        }
    }
}
