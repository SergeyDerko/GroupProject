using System.Collections.Generic;
using CurrencyConvertLib;
using CurrencyRateServiceLibrary;
using TestWcfCommon;

namespace CurrencyConvertWcfLib
{
    public class CurrencyConvert : ICurrencyConvert
    {
        private string Operation { get; set; }
        private List<Currency> List { get; set; }
        private string FromCurrency { get; set; }
        private string ToCurrency { get; set; }
        private int Count { get; set; }
        private string Change { get; set; }
        private string Action { get; set; }
        private double Result { get; set; }

        public string ChangeCurrency(string fromCurrency, string toCurrency, int count, string action)
        {
            Logger.Enter();
            Logger.Write(Level.Debug, "Иницаилизация переменных...");
            InitProperties(fromCurrency, toCurrency, count, action);
            Logger.Write(Level.Info, "Инициализация прошла успешно!");

            Logger.Write(Level.Debug, "Выбор валюты для покупки/продажи...");
            foreach (var item in List)
            {
                if (FromCurrency != item.CurrencyName) continue;
                {
                    Logger.Write(Level.Info, $"Выбрана валюта {FromCurrency}");
                    Result = GetResult(FromCurrency, ToCurrency, Count);
                    Logger.Write(Level.Info, $"Операция {Operation} прошла успешно!");
                }
            }
            Logger.Leave($"Результат {Result:N2} {ToCurrency}");
            return $"{Result:N2} {ToCurrency}";

        }
        #region Methods
        private void InitProperties(string fromCurrency, string toCurrency, int count, string action)
        {
            FromCurrency = fromCurrency;
            ToCurrency = toCurrency;
            Count = count;
            Action = action;
            Operation = action == "buy" ? "покупка" : "продажа";
            Change = Action == "buy" ? $"Выбрана операция купить {Count} {FromCurrency} за {ToCurrency}" :
            $"Выбрана операция продать {Count} {FromCurrency} за {ToCurrency}";

            List = new List<Currency>(new CurrencyRate().CurrentRate())
            {
                new Currency
                {
                    Id = 11,
                    CurrencyDescription = "Украинская гривна",
                    CurrencyName = "UAH",
                    Purchase = 1,
                    Sale = 1
                }
            };
        }

        private double GetResult(string fromCurrency, string toCurrency, int count)
        {
            double result = 0;
            foreach (var f in List)
            {
                if (fromCurrency != f.CurrencyName) continue;
                foreach (var t in List)
                {
                    if (toCurrency != t.CurrencyName) continue;
                    Logger.Write(Level.Debug, $"Выбор операции над валютой {FromCurrency}...");
                    Logger.Write(Level.Info, Change);
                    Logger.Write(Level.Debug, $"Пробую провести операцию {Operation} {Count} {FromCurrency} за {toCurrency}...");
                    result = Action == "buy" ? count * f.Sale / t.Sale : count * f.Purchase / t.Purchase;
                    break;
                }
            }
            return result;
        }

        #endregion
    }
}
