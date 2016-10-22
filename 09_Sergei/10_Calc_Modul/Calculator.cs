using System;
using System.Text.RegularExpressions;

namespace _10_Calc_Modul
{
    internal class Calculator
    {
        protected int Calc(string pattern, string _expression)
        {
            var result = 0;
            foreach (Match c in Regex.Matches(_expression, pattern))
            {
                var value1 = int.Parse(c.Groups[1].Value);
                var value2 = int.Parse(c.Groups[3].Value);
                var action = c.Groups[2].Value;
                switch (action)
                {
                    case "*":
                        {
                            Console.WriteLine("{0}" + "=" + "{1}", c.Value, value1 * value2);
                            result = value1 * value2;
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine("{0}" + "=" + " {1:N2}", c.Value, value1 / value2);
                            result = value1 / value2;
                            break;
                        }
                    case "+":
                        {
                            Console.WriteLine("{0} " + "=" + " {1}", c.Value, value1 + value2);
                            result = value1 + value2;
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine("{0} " + "=" + " {1}", c.Value, value1 - value2);
                            result = value1 - value2;
                            break;
                        }
                }
            }
            return result;
        }   
    }
}



