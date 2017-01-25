using System.Collections.Generic;

namespace CurrencyRateServiceLibrary
{
    public class CurrencyRate : ICurrencyRate
    {
        public List<Currency> CurrentRate()
        {
            var datalist = Parser.ParserSite();
            var list = new List<Currency>
            {
                new Currency
                {
                    Id = 1,
                    CurrencyName = "USD",
                    CurrencyDescription = "Доллар",
                    Purchase = datalist[0],
                    Sale = datalist[1]
                },
                new Currency
                {
                    Id = 2,
                    CurrencyName = "EUR",
                    CurrencyDescription = "Евро",
                    Purchase = datalist[2],
                    Sale = datalist[3]
                },
                new Currency
                {
                    Id = 3,
                    CurrencyName = "RUB",
                    CurrencyDescription = "Рубль",
                    Purchase = datalist[4],
                    Sale = datalist[5]
                }
            };
            return list;
        }
    }
}
