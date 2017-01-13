using System.Collections.Generic;
using System.ServiceModel;
using System.Web.Mvc;
using CurrencyConvertClientLib.CurrencyConvertServiceReference;

namespace TestWcfSite.Models.PikhotaSerhiiModels
{
    public class CurrencyConverter
    {
        public readonly CurrencyConvertClient Client = new CurrencyConvertClient();
        public string Msg { get; set; }

        public CurrencyConverter()
        {
            try
            {
            }
            catch (EndpointNotFoundException)
            {
                Msg = "Сервис CurrentConvert не запущен! :(";
            }
        }
    }
}