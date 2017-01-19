using System;
using System.Net;

namespace MeteoTempServiceLib
{
    public class MeteoTemp : IMeteoTemp
    {
        public string CurrentMeteoTemp()
        {
            string temp;
            using (WebClient client = new WebClient())
            {
                string htmlCode = client.DownloadString("https://www.wunderground.com/personal-weather-station/dashboard?ID=I30KYIV4");
                temp = htmlCode;
            }
            return $"Temp = {temp}";
        }
    }
}
