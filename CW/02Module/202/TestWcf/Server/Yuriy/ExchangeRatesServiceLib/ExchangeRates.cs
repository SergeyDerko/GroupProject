using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesServiceLib
{
    public class ExchangeRates:IExchangeRates
    {
        public string Usd { get; set; }
        public string Eur { get; set; }
    }
}
