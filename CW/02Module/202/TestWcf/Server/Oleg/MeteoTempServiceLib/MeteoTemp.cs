using System;
using System.Net;

namespace MeteoTempServiceLib
{
    public class MeteoTemp : IMeteoTemp
    {
        public string CurrentMeteoTemp()
        {
            string temp;
            //string value = "";
            using (WebClient client = new WebClient())
            {
                string htmlCode = client.DownloadString("https://rss.wunderground.com/auto/rss_full/global/stations/33345.xml");

                temp = htmlCode;
            }
            return $"Temp = {temp}";
        }
    }
}
