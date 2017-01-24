using TemperatureClientLibrary.TemperatureServiceReference;

namespace TestWcfSite.Models.ArtemModels
{
    public class Temperature
    {
        public Temperature()
        {
            var client = new TemperatureClient();
            CurrentTemp = client.Temp();
            client.Close();
        }

        public string CurrentTemp { get; private set; }
    }
}