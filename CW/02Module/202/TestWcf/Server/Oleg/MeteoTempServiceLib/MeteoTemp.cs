using System;
using System.Linq;
using System.Xml.Linq;
using TestWcfCommon;

namespace MeteoTempServiceLib
{
    public class MeteoTemp : IMeteoTemp
    {
        public string CurrentMeteoTemp()
        {
            try
            {
                Logger.Enter("Enter to CurrentMeteoTemp");
                XDocument feedXML = XDocument.Load("https://rss.wunderground.com/auto/rss_full/global/stations/33345.xml");
                var feedValue = (from feed in feedXML.Descendants("item")
                                 select new
                                 {
                                     Title = feed.Element("title").Value,
                                     Link = feed.Element("link").Value,
                                     Description = feed.Element("description").Value,
                                 }).FirstOrDefault();
                string value = String.Format("{0}:\n\n {1}", feedValue.Title, feedValue.Description);
                Logger.Info(String.Format("Return value: {0}", value));
                Logger.Leave("Leave from CurrentMeteoTemp");
                return value;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return "Ошибка при работе сервиса!";
            }
        }
    }
}
