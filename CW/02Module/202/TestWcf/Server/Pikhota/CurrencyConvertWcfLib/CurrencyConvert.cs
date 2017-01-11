using System.Collections.Generic;
using CurrencyConvertLib;

namespace CurrencyConvertWcfLib
{
    public class CurrencyConvert : ICurrencyConvert
    {
        public int Count { get; set; }

        public List<string> Li { get; set; }

        public CurrencyConvert()
        {
            Li = new List<string> { "USD", "EUR", "UAH" };
            Count = 1;
        }

        public decimal UsdToEuro()
        {
            
            decimal result;
            if (Count <= 1)
            {
                result = (decimal)0.9516;
            }
            else
            {
                result = Count * (decimal)0.9516;
            }
            return result;
        }

        public decimal UsdToUah()
        {
            decimal result;
            if (Count <= 1)
            {
                result = (decimal)27.2350;
            }
            else
            {
                result = Count * (decimal)27.2350;
            }
            return result;
        }

        public decimal EuroToUsd()
        {
            decimal result;
            if (Count <= 1)
            {
                result = (decimal)1.0512;
            }
            else
            {
                result = Count*(decimal)1.0512;
            }
            return result;
        }

        public decimal EuroToUah()
        {
            decimal result;
            if (Count <= 1)
            {
                result = (decimal)28.6226;
            }
            else
            {
                result = Count * (decimal)28.6226;
            }
            return result;
        }

        public decimal UahToUsd()
        {
            decimal result;
            if (Count <= 1)
            {
                result = (decimal)0.0367;
            }
            else
            {
                result = Count * (decimal)0.0367;
            }
            return result;
        }

        public decimal UahToEuro()
        {
            decimal result;
            if (Count <= 1)
            {
                result = (decimal)0.0349;
            }
            else
            {
                result = Count * (decimal)0.0349;
            }
            return result;
        }
    }
}
