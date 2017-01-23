//using TemperatureClientLib.TemperatureServiceReference;

namespace TestWcfSite.Models.ArtemModels
{
    public class Temperature
    {
        public Temperature()
        {
            //var client = new TemperatureClient();
            //CurrentTemperature = client.CurrentTemperature();
        }
        public string CurrentTemperature { get; private set; }
    }
}