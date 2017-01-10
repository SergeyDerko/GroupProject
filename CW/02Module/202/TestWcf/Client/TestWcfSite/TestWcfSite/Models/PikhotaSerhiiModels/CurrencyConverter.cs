using System.ServiceModel;
using CurrencyConvertClientLib.CurrencyConvertServiceReference;

namespace TestWcfSite.Models.PikhotaSerhiiModels
{
    public class CurrencyConverter
    {
        public CurrencyConverter()
        {
            try
            {
                var client = new CurrencyConvertClient();
                CurrentConvert = client.ChangeCurrency();
                client.Close();
            }
            catch (EndpointNotFoundException)
            {
                CurrentConvert = "Сервис CurrentConvert не запущен! :(";
            }
        }

        public string CurrentConvert { get; set; }
    }
}