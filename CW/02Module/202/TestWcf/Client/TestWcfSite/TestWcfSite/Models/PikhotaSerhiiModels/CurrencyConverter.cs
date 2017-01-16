using System.Net.Configuration;
using CurrencyConvertClientLib.CurrencyConvertServiceReference;

namespace TestWcfSite.Models.PikhotaSerhiiModels
{
    public class CurrencyConverter
    {
        public string Msg { get; set; }
        public readonly CurrencyConvertClient Client = new CurrencyConvertClient();
    }
}