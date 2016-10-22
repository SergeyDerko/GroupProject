using System;

namespace lesson11
{
    internal class Calculation
    {
        public readonly int Result;

        public Calculation(int x, int y, string operation)
        {
            switch (operation)
            {
                case "+":
                    Result = x + y;
                    break;
                case "-":
                    Result = x - y;
                    break;
                case "/":
                    Result = x / y;
                    break;
                case "*":
                    Result = x * y;
                    break;
                default:
                    Console.WriteLine("Неправильный оператор");
                    break;
            }

        }

    }
}
