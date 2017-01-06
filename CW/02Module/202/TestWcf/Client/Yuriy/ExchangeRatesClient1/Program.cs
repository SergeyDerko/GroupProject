using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExchangeRatesClient1.ServiceReference1;

namespace ExchangeRatesClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExchangeRatesClient client = new ExchangeRatesClient();

           var ext =  client.CurrentExchangeRates();
            Console.WriteLine(ext);
            Console.ReadKey();
            client.Close();

        }
    }
}
