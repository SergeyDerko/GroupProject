using System;

namespace MoneySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;
            while (!finish)
            {
                Console.WriteLine("Entering pounds: ");
                var pound = Console.ReadLine();
                Console.WriteLine("Entering shillings: ");
                var shilling = Console.ReadLine();
                Console.WriteLine("Entering pens: ");
                var pens = Console.ReadLine();
                
                if (CheckMoney(pound) == true && CheckMoney(shilling) == true &&
                    CheckMoney(pens) == true)
                {
                    OldMoneySystem moneySystem = new OldMoneySystem(Decimal.Parse(pound), Decimal.Parse(shilling), Decimal.Parse(pens));
                    Console.WriteLine("Old UK money system: " + pound + '.' + shilling + '.' + pens);
                    moneySystem.GetNewSystemMoney();
                    finish = true;
                }
                else
                {
                    finish = false;
                }
            }
            Console.ReadLine();
        }
        
        internal class OldMoneySystem
        {
            public decimal Pound { get; set; }

            public decimal Shilling { get; set; }

            public decimal Pens { get; set; }

            public OldMoneySystem(decimal pound, decimal shilling, decimal pens)
            {
                this.Pound = pound;
                this.Shilling = shilling;
                this.Pens = pens;
            }
            internal void GetNewSystemMoney()
            {
                Pound *= 240;
                Shilling *= 12;
                var deflation = 2.4M;
                var money = Pens + Shilling + Pound;
                var result = (money / 100) / deflation;
                Console.WriteLine("New UK money system: " + result);
            }   
        }
        public static bool CheckMoney(string money)
        {
            char[] anyString = money.ToCharArray();
            for (var i = 0; i <= anyString.Length - 1; i++)
            {
                if (Char.IsDigit(anyString[i]))
                {
                    continue;
                }
                else if (anyString[i] == anyString.Length - 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
