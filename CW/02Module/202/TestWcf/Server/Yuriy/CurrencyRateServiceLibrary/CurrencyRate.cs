using System.Collections.Generic;

namespace CurrencyRateServiceLibrary
{
    public class CurrencyRate : ICurrencyRate
    {
        public List<Currency> CurrentRate()
        {
            var list = new List<Currency>
            {
                new Currency
                {
                    Id = 1,
                    CurrencyName = "USD",
                    CurrencyDescription = "Доллар",
                    Purchase = 27.615,
                    Sale = 28.446
                },
                new Currency
                {
                    Id = 2,
                    CurrencyName = "EUR",
                    CurrencyDescription = "Евро",
                    Purchase = 28.967,
                    Sale = 30.201
                },
                new Currency
                {
                    Id = 3,
                    CurrencyName = "RUB",
                    CurrencyDescription = "Рубль",
                    Purchase = 0.432,
                    Sale = 0.475
                },
                new Currency
                {
                    Id = 4,
                    CurrencyName = "GBP",
                    CurrencyDescription = "Фунт стерлингов",
                    Purchase = 32.388,
                    Sale = 34.718
                },
                new Currency
                {
                    Id = 5,
                    CurrencyName = "CHF",
                    CurrencyDescription = "Швейцарский франк",
                    Purchase = 26.333,
                    Sale = 27.897
                },
                new Currency
                {
                    Id = 6,
                    CurrencyName = "CZK",
                    CurrencyDescription = "Чешская крона",
                    Purchase = 0.933,
                    Sale = 1.140
                },
                new Currency
                {
                    Id = 7,
                    CurrencyName = "CNY",
                    CurrencyDescription = "Китайский юань",
                    Purchase = 3.021,
                    Sale = 4.034
                },
                new Currency
                {
                    Id = 8,
                    CurrencyName = "JPY",
                    CurrencyDescription = "Японская йена",
                    Purchase = 0.222,
                    Sale = 0.250
                },
                new Currency
                {
                    Id = 9,
                    CurrencyName = "PLN",
                    CurrencyDescription = "Польский злотый",
                    Purchase = 6.133,
                    Sale = 6.891
                },
                new Currency
                {
                    Id = 10,
                    CurrencyName = "ILS",
                    CurrencyDescription = "Израильский шекель",
                    Purchase = 6.300,
                    Sale = 7.300
                }
            };


            return list;
        }
    }
}
