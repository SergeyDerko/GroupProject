using System;
using System.Threading;

namespace GeneratorOfMathExpression
{
    public static class Generator
    {

        public static string GetExpression()
        {
            var rand = new Random();
            var expression = string.Empty;
            var lenght = rand.Next(3, 10);
            for (var i = 0; i <= lenght; i++)
            {
                if (i == 0)
                {
                    expression += rand.Next(1, 1000).ToString();
                    continue;
                }
                expression += GetOperator();
                expression += rand.Next(1, 1000).ToString();
                if (i == lenght)
                {
                    expression += '=';
                    break;
                }
                Thread.Sleep(1000);
            }
            return expression;
        }

        private static char GetOperator()
        {
            var op = new[] { '*', '/', '+', '-' };
            var rand = new Random();
            return op[rand.Next(3)];
        }
    }
}