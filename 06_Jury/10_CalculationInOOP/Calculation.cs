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
        private int x;
        private int y;
        private char operation;
        public readonly int Result;
        
        public Calculation(int number1, int number2, char operation)
        {
            x = number1;
            y = number2;
            this.operation = operation;
            switch (operation)
            {
                case '+':
                    Result = x + y;
                    break;
                case '-':
                    Result = x - y;
                    break;
                case '/':
                    Result = x / y;
                    break;
                case '*':
                    Result = x * y;
                    break;
                default:
                    Console.WriteLine("Неправильный оператор");
                    break;
            }
            
        }

    }
}
