using System.Globalization;
using CurrencyConvertLib;

namespace CurrencyConvertWcfLib
{
    public class CurrencyConvert : ICurrencyConvert
    {
        public string ChangeCurrency(string fromCurrency, string toCurrency, int count)
        {
            string result;
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
                default:
                    result = "";
                    break;
            }
            return result.ToString(CultureInfo.CurrentCulture);
        }

        private static string ToCurUsd(string toCurrency,int count)
        {
            decimal result;
            switch (toCurrency)
            {
                case "USD":
                    {
                        result = count * 1;
                        break;
                    }
                case "UAH":
                    {
                        result = count * (decimal)27.2350;
                        break;
                    }
                case "EUR":
                    {
                        result = count * (decimal)0.9516; ;
                        break;
                    }
                    default:
                    result = 0;
                    break;
            }
            return result.ToString(CultureInfo.CurrentCulture);
        }
        private static string ToCurUah(string toCurrency, int count)
        {
            decimal result;
            switch (toCurrency)
            {
                case "USD":
                    {
                        result = count * (decimal)0.0367;
                        break;
                    }
                case "UAH":
                    {
                        result = count*1;
                        break;
                    }
                case "EUR":
                    {
                        result = count * (decimal)0.0349;
                        break;
                    }
                default:
                    result = 0;
                    break;
            }
            return result.ToString(CultureInfo.CurrentCulture);
        }
        private static string ToCurEur(string toCurrency,int count)
        {
            decimal result = 0;
            switch (toCurrency)
            {
                case "USD":
                    {
                        result = count * (decimal)1.0512;
                        break;
                    }
                case "UAH":
                    {
                        result = count * (decimal)28.6226;
                        break;
                    }
                case "EUR":
                    {
                        result = count*1;
                        break;
                    }
                default:
                    result = 0;
                    break;
            }
            return result.ToString(CultureInfo.CurrentCulture);
        }
    }
}
