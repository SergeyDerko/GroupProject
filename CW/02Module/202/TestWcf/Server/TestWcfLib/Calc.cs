using System;
using TestWcfCommon;
using TestWcfDB;
using TestWcfTypes.Expressions;

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

            SaveExpression(new Expression { A = a, B = b, MathAction = MathAction.Sum });
            return Logger.Leave(sum);
        }

        public decimal Execute(Expression expression)
        {
            SaveExpression(expression);
            return Execute(expression.A, expression.B, expression.MathAction);
        }

        private static void SaveExpression(Expression expression)
        {
            using (var ctx = new CalcContext())
            {
                ctx.Expressions.Add(expression);
                ctx.SaveChanges();
            }
        }

        public decimal Execute(decimal a, decimal b, MathAction mathAction)
        {
            Logger.Enter();
            decimal result = 0;
            switch (mathAction)
            {
                case MathAction.Sum:
                    result = a + b;
                    SaveExpression(new Expression {A = a, B = b, MathAction = MathAction.Sum});
                    break;
                case MathAction.Min:
                    result = a - b;
                    SaveExpression(new Expression {A = a, B = b, MathAction = MathAction.Min});
                    break;
            }
            return Logger.Leave(result);
        }
    }
}