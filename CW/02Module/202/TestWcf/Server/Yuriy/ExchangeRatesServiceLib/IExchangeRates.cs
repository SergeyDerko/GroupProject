using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesServiceLib
{
    interface IExchangeRates
    {
         string Usd { get; set; }
         string Eur { get; set; }
    }
}
