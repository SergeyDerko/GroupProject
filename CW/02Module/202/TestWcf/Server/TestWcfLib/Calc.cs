using System;
using TestWcfCommon;

namespace TestWcfLib
{
    public class Calc : ICalc
    {
        public int Sum(int a, int b)
        {
            Logger.Enter();
            var sum = a + b;
            var value = $"{a} + {b} = {sum}";
            Logger.Info(value);
            Console.WriteLine(value);
            return Logger.Leave(sum);
        }

        public decimal Execute(Expression expression)
        {
            return Execute(expression.A, expression.B, expression.MathAction);
        }

        public decimal Execute(decimal a, decimal b, MathAction mathAction)
        {
            Logger.Enter();
            decimal result = 0;
            switch (mathAction)
            {
                case MathAction.Sum:
                    result = a + b;
                    break;
                case MathAction.Min:
                    result = a - b;
                    break;
            }
            return Logger.Leave(result);
        }
    }
}