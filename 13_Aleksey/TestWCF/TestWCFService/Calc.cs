using System;
using TestWCFCommon;

namespace TestWCFService
{
    public class Calc : ICalc
    {
        public int Sum(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
            return sum;
        }

        public int Sub(int a, int b)
        {
            var sub = a - b;
            Console.WriteLine($"{a} - {b} = {sub}");
            return sub;
        }

        public int Div(int a, int b)
        {
            // var divInt = a/b;
            //var divFloat = a%b;
            try
            {
                var div = a/b; //divInt + divFloat;
                Console.WriteLine($"{a} / {b} = {div}");
                return div;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Деление на ноль не допустимо");
                return 0;
            }
           
            
        }

        public int Mult(int a, int b)
        {
            try
            {
                var mult = a*b;
                Console.WriteLine($"{a} * {b} = {mult}");
                return mult;
            }
            catch (Exception e)
            {
                Console.WriteLine($"умножение на ноль не допустимо");
                return 0;
            }

        }
    }
}
