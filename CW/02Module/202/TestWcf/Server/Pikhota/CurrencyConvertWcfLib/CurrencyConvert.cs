using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyConvertLib;

namespace CurrencyConvertWcfLib
{
    public class CurrencyConvert : ICurrencyConvert
    {
        public string Usd = "USD";
        public string Euro = "EUR";
        public string Uah = "UAH";
        public decimal ChangeCurrency(string fromCurrency, string toCurrency)
        {
            decimal result = 0;
            if (fromCurrency == Usd)
            {
                
            }
            return result;
        }
    }
}
