using System;
namespace task6
{
    class Program
    {
        static void Main()
        {
            var gbr = 1.487M;
            var chf = 0.172M;
            var dm = 0.584M;
            var jpy = 0.00955M;
            var today = DateTime.Now;
            Console.WriteLine($" Конвертер валюты\n Курс на {today.ToShortDateString()}\n" +
                              $" 1 USD (Доллар США):" +
                              $"\n\t\t1.487 GBR (Фунт стерлингов)" +
                              $"\n\t\t0.172 CHF (Швейцарский франк)" +
                              $"\n\t\t0.584 DM (Немецкая марка)" +
                              $"\n\t\t0.00955 JPY (Японская йена)");
            Console.Write(" Введите сумму USD для конвертации: ");
            var usd = Console.ReadLine();
            int verify;
            if (!string.IsNullOrEmpty(usd)&&int.TryParse(usd, out verify))
            {
                var usdDemical = decimal.Parse(usd);
                var gbrcalc = gbr * usdDemical;
                var chfcalc = chf * usdDemical;
                var dmcalc = dm * usdDemical;
                var jpycalc = jpy * usdDemical;
                Console.WriteLine($" {usd} USD:\n\t{gbrcalc} GBR\n\t{chfcalc} CHF\n\t{dmcalc} DM\n\t{jpycalc} JPY");
            }
            else
            {
                Console.WriteLine("\a\n Вы ввели некоректное значение!");
            }
            Console.Write(" Нажмите любую клавишу для выхода...");
            Console.ReadKey();

        }
    }
}
