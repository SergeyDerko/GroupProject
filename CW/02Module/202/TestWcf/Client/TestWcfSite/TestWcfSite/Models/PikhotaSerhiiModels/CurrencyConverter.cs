using System;
using System.Collections.Generic;
using CurrencyConvertClientLib.CurrencyConvertServiceReference;
using CurrencyRateClientLibrary.CurrencyRateServiceReference;

namespace TestWcfSite.Models.PikhotaSerhiiModels
{
    
    public class CurrencyConverter : IDisposable
    {
        

        public CurrencyConvertClient SrvConvertCurrency = new CurrencyConvertClient();
        public CurrencyRateClient SrvCurrencyRate;
        public List<Currency> Current { get; }

        public CurrencyConverter()
        {
            
        }

        public CurrencyConverter(CurrencyRateClient srvCurrencyRate)
        {
            SrvCurrencyRate = srvCurrencyRate;
            Current = new List<Currency>(SrvCurrencyRate.CurrentRate());
        }

        public void Dispose()
        {
            SrvConvertCurrency.Close();   
        }
        
    }

    
    
}