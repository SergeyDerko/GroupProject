using System;
using System.Collections.Generic;
using System.ServiceModel;
using CurrencyConvertClientLib.CurrencyConvertServiceReference;

namespace TestWcfSite.Models.PikhotaSerhiiModels
{
    public class CurrencyConverter
    {
        public string Msg { get; set; }
        public List<string> ListCurrency = new List<string>();

        public readonly CurrencyConvertClient Client = new CurrencyConvertClient();
        public CurrencyConverter()
        {
            try
            {
            }
            catch (CommunicationException)
            {
                Msg = "Communication Exception Error!";
                Client.Abort();
            }
            catch (TimeoutException)
            {
                Msg = "Your time is out:)";
                Client.Abort();
            }
            finally
            {
                Client.Close();
            }
        }     
    }
}