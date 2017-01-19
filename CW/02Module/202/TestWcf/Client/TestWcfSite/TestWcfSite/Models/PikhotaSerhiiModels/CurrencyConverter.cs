using System;
using System.Collections.Generic;
using CurrencyConvertClientLib.CurrencyConvertServiceReference;
using CurrencyRateClientLibrary.CurrencyRateServiceReference;

namespace TestWcfSite.Models.PikhotaSerhiiModels
{
    
    public class CurrencyConverter : IDisposable
    {
        

        public CurrencyConvertClient SrvConvertCurrency = new CurrencyConvertClient();
        public CurrencyRateClient SrvCurrencyRate = new CurrencyRateClient();
        public List<Currency> CurrencyList { get; set; }

        public CurrencyConverter()
        {
            CurrencyList = new List<Currency>(SrvCurrencyRate.CurrentRate());
        }


        public List<string> GetCurrencyNames()
        {
            var listNames = new List<string>();
            foreach (var i in CurrencyList)
            {
                listNames.Add(i.CurrencyName);
            }
            return listNames;
        }

        /*public double GetResult(string fromCurrency, int count)
        {
            double result = 0;
            foreach (var i in SrvCurrencyRate.CurrentRate())
            {
                if (fromCurrency == i.CurrencyName)
                {
                    result = count * i.Purchase;
                }
            }
            return result;
        }*/


        public void Dispose()
        {
            SrvCurrencyRate.Close();
            SrvConvertCurrency.Close();   
        }
        
    }

    
    
}