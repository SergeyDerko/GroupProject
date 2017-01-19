using System;
using System.Collections.Generic;
using System.Globalization;
using CurrencyConvertLib;
using CurrencyRateServiceLibrary;

namespace CurrencyConvertWcfLib
{
    public class CurrencyConvert : ICurrencyConvert
    {

        public string ChangeCurrency(string fromCurrency, string toCurrency, int count, string action)
        {
            double result = 0;
            switch (fromCurrency)
            {
                case "UAH":
                {
                    switch (action)
                    {
                        case "buy":
                            result = GetResultPurchase(toCurrency, count);
                            break;
                        case "sell":
                            result = GetResultSell(toCurrency, count);
                            break;
                    }
                    break;
                }
            }
            return result.ToString(CultureInfo.CurrentCulture);
        }

        public double GetResultPurchase(string toCurrency, int count)
        {
            var list = new List<Currency>(new CurrencyRate().CurrentRate());
            double result = 0;
            foreach (var i in list)
            {
                if (toCurrency == i.CurrencyName)
                {
                    result = count / i.Purchase;
                }
            }
            return result;
        }

        public double GetResultSell(string toCurrency, int count)
        {
            var list = new List<Currency>(new CurrencyRate().CurrentRate());
            double result = 0;
            foreach (var i in list)
            {
                if (toCurrency == i.CurrencyName)
                {
                    result = count / i.Sale;
                }
            }
            return result;
        }
    }
}
