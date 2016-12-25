using System;
using TestWCFCommon;

namespace TestWCFService
{
    public class Calc : ICalc
    {
        public int Sum(int a, int b)
        {
           // const string method = "Sum";
           // Logger.Enter(method);
            var sum = a + b;
            var value = $"   {a} + {b} = {sum}";
            //Logger.Info(method, value);
            Console.WriteLine(value);
            return sum;//Logger.Leave(method, sum);
        }

        public int Sub(int a, int b)
        {
            var sub = a - b;
            Console.WriteLine($"{a} - {b} = {sub}");
            return sub;
        }

        public double Div(double a, double b)
        {
            try
            {
                var div = a/b; 
                Console.WriteLine($"{a} / {b} = {div}");
                return div;
            }
            catch (DivideByZeroException)
            {

                return 0;
            }
            
        }

        public int Mult(int a, int b)
        {
                var mult = a*b;
                Console.WriteLine($"{a} * {b} = {mult}");
                return mult;
        }
    }
}
