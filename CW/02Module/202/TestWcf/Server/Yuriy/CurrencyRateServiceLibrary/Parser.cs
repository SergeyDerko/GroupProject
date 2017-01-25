using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Parser.Html;

namespace CurrencyRateServiceLibrary
{
    static class Parser
    {
        public static List<double> ParserSite()
        {
            var list = new List<double>();


            var client = new WebClient();
            var source = client.DownloadString("https://privatbank.ua/");
            var parser = new HtmlParser();
            var docum = parser.Parse(source);
            var query = docum.QuerySelectorAll("tbody#selectByPB>tr>td");
            list.Add(double.Parse(query[1].TextContent, System.Globalization.CultureInfo.InvariantCulture));
            list.Add(double.Parse(query[2].TextContent, System.Globalization.CultureInfo.InvariantCulture));
            list.Add(double.Parse(query[4].TextContent, System.Globalization.CultureInfo.InvariantCulture));
            list.Add(double.Parse(query[5].TextContent, System.Globalization.CultureInfo.InvariantCulture));
            list.Add(double.Parse(query[7].TextContent, System.Globalization.CultureInfo.InvariantCulture));
            list.Add(double.Parse(query[8].TextContent, System.Globalization.CultureInfo.InvariantCulture));

            return list;

        }



       

    }
}
