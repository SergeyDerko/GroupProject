using MeteoTempClientLib.MeteoTempServiceReference;

namespace TestWcfSite.Models.KhlopovOlegModel
{
    public class MeteoTemp
    {
        public MeteoTemp()
        {
            var client = new MeteoTempClient();
            CurrentMeteo = client.CurrentMeteoTemp();
            client.Close();
        }
        public string CurrentMeteo { get; private set; }
    }
}