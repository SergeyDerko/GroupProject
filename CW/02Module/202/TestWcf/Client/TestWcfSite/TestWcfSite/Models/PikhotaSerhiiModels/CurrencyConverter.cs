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
                client.ChangeCurrency();
                client.Close();
            }
            catch (EndpointNotFoundException)
            {
                Msg = "Сервис CurrentConvert не запущен! :(";
            }
        }

        public string Msg { get; set; }
    }
}