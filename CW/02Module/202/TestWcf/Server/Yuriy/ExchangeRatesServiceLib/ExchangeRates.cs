using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesServiceLib
{
    public class ExchangeRates:IExchangeRates
    {
        public decimal Usd { get; set; }
        public decimal Eur { get; set; }
        public string Value()
        {
            var random = new Random();
            Usd = random.Next(25, 30);
            Eur = random.Next(30, 35);
            return $"Usd = {Usd}, Eur = {Eur}";
        }
    }
}
