using System.Globalization;
using CurrencyConvertLib;

namespace CurrencyConvertWcfLib
{
    public class CurrencyConvert : ICurrencyConvert
    {
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public int Count { get; set; }

        public string ChangeCurrency(string fromCurrency, string toCurrency, int count)
        {
            decimal result = 0;
            switch (fromCurrency)
            {
                case "USD":
                    result = ToCurUsd(toCurrency,count);
                    break;
                case "UAH":
                    result = ToCurUah(toCurrency,count);
                    break;
                case "EUR":
                    result = ToCurEur(toCurrency,count);
                    break;
            }
            return result.ToString(CultureInfo.InvariantCulture);
        }
        
        private decimal UsdToEuro(int count)
        {
            var result = count * (decimal)0.9516;
            return result;
        }

        private decimal UsdToUah(int count)
        {
            var result = count * (decimal)27.2350;
            return result;
        }

        private decimal EuroToUsd(int count)
        {
            var result = count * (decimal)1.0512;
            return result;
        }

        private decimal EuroToUah(int count)
        {
            var result = count * (decimal)28.6226;
            return result;
        }

        private decimal UahToUsd(int count)
        {
            var result = count * (decimal)0.0367;
            return result;
        }

        private decimal UahToEuro(int count)
        {
            var result = count * (decimal)0.0349;
            return result;
        }

        private decimal ToCurUsd(string toCurrency,int count)
        {
            decimal result = 0;
            switch (toCurrency)
            {
                case "USD":
                    {
                        result = count * 1;
                        break;
                    }
                case "UAH":
                    {
                        result = UsdToUah(count);
                        break;
                    }
                case "EUR":
                    {
                        result = UsdToEuro(count);
                        break;
                    }
            }
            return result;
        }
        private decimal ToCurUah(string toCurrency, int count)
        {
            decimal result = 0;
            switch (toCurrency)
            {
                case "USD":
                    {
                        result = UahToUsd(count);
                        break;
                    }
                case "UAH":
                    {
                        result = count*1;
                        break;
                    }
                case "EUR":
                    {
                        result = UahToEuro(count);
                        break;
                    }
            }
            return result;
        }
        private decimal ToCurEur(string toCurrency,int count)
        {
            decimal result = 0;
            switch (toCurrency)
            {
                case "USD":
                    {
                        result = EuroToUsd(count);
                        break;
                    }
                case "UAH":
                    {
                        result = EuroToUah(count);
                        break;
                    }
                case "EUR":
                    {
                        result = count*1;
                        break;
                    }
            }
            return result;
        }
    }
}
