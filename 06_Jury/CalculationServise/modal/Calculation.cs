using System;

namespace CalculationServise.modal
{
    internal class Calculation
    {
        internal readonly int Result;
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
                    break;
            }

        }

    }
}
