using System;

using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace GeneratorOfMathExpression
{
    internal static class Generator
    {

        internal static void GetExpression()
        {
            var rand = new Random();
            var arr = new[] { '*', '/', '+', '-' };
            const string outFile = @"D:\Gitprojects\GroupProject\09_Sergei\GeneratorOfMathExpression\OutFile.txt";
            var expression = string.Empty;
            var lenght = rand.Next(3, 10);
            for (var i = 0; i <= lenght; i++)
            {
                if (i == 0)
                {
                    expression += rand.Next(1, 1000).ToString();
                    continue;
                }
                expression += GetOperator(arr);
                expression += rand.Next(1, 1000).ToString();
                if (i == lenght)
                {
                    expression += '=';
                    break;
                }
                Thread.Sleep(1000);
            }
            File.AppendAllText(outFile, "\r\n" + expression);
        }

        private static char GetOperator(IReadOnlyList<char> op)
        {
            var rand = new Random();
            return op[rand.Next(3)];
        }
    }
}