using System.Collections.Generic;
using CurrencyConvertLib;
using CurrencyRateServiceLibrary;
using TestWcfCommon;

namespace CurrencyConvertWcfLib
{
    public class CurrencyConvert : ICurrencyConvert
    {

        public double ChangeCurrency(string fromCurrency, string toCurrency, int count, string action)
        {
            Logger.Enter();
            var list = new List<Currency>(new CurrencyRate().CurrentRate());
            double result = 0;
            foreach (var item in list)
            {
                Logger.Write(Level.Debug, "Выбор валюты для покупки/продажи");
                if (fromCurrency == item.CurrencyName)
                {
                    Logger.Write(Level.Info, $"Выбрана валюта {fromCurrency}");
                    Logger.Write(Level.Debug, "Выбор действия");
                    switch (action)
                    {
                        case "buy":
                            Logger.Write(Level.Info, $"Выбрано действие купить {count} {fromCurrency} за {toCurrency}");
                            result = GetResultPurchase(fromCurrency, toCurrency, count);
                            break;
                        case "sell":
                            Logger.Write(Level.Info, $"Выбрано действие продать {count} {fromCurrency} за {toCurrency}");
                            result = GetResultSell(fromCurrency, toCurrency, count);
                            break;
                    }
                }
                else
                {
                    //Если выбрана гривна
                    Logger.Write(Level.Info, $"Выбрана валюта {fromCurrency}");
                    Logger.Write(Level.Debug, "Выбор действия");
                    switch (action)
                    {
                        case "buy":
                            Logger.Write(Level.Info, $"Выбрано действие купить {count} {fromCurrency} за {toCurrency}");
                            result = GetResultPurchase(fromCurrency, toCurrency, count);
                            break;
                        case "sell":
                            Logger.Write(Level.Info, $"Выбрано действие продать {count} {fromCurrency} за {toCurrency}");
                            result = GetResultSell(fromCurrency, toCurrency, count);
                            break;
                    }
                }
                
            }
            Logger.Leave(result);
            return result;
        }

        public double GetResultPurchase(string fromCurrency, string toCurrency, int count)
        {
            var list = new List<Currency>(new CurrencyRate().CurrentRate());
            double result = 0;
            foreach (var f in list)
            {
                if (fromCurrency == f.CurrencyName || fromCurrency == "UAH")
                {
                    foreach (var t in list)
                    {
                        if (fromCurrency == "UAH")
                        {
                            result = count / t.Sale;
                            break;
                        }
                        if (toCurrency == "UAH")
                        {
                            result = count * t.Sale;
                            break;
                        }
                        if (toCurrency == t.CurrencyName)
                        {
                            result = count * f.Sale / t.Sale;
                            break;
                        }
                    }
                }
            }
            return result;
        }

        public double GetResultSell(string fromCurrency, string toCurrency, int count)
        {
            var list = new List<Currency>(new CurrencyRate().CurrentRate());
            double result = 0;
            foreach (var f in list)
            {
                if (fromCurrency == f.CurrencyName || fromCurrency == "UAH")
                {
                    foreach (var t in list)
                    {
                        if (toCurrency == t.CurrencyName)
                        {
                            result = count * f.Purchase / t.Purchase;
                            break;
                        }
                        if (fromCurrency == "UAH")
                        {
                            result = count * t.Purchase;
                            break;
                        }
                        if (toCurrency == "UAH")
                        {
                            result = count * t.Purchase;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
