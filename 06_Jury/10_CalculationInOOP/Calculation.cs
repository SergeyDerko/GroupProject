using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    
    class Calculation
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
