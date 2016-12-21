using System;
using TestWsf_11_Common;

namespace TestWsf_11_Servise
{
    public class Calc : ICalc
    {
        public double Sum(double a, double b)// сложение 
        {
            var sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
            return sum;
        }

        public double Sub(double a, double b)// Вычитание
        {
            var sub = a - b;
            Console.WriteLine($"{a} - {b} = {sub}");
            return sub;
        }

        public double Mult(double a, double b) //Умножение
        {
            var mult = a * b;
            Console.WriteLine($"{a} * {b} = {mult}");
            return mult;
        }

        public double Div(double a, double b) // деление
        {
            var div = a / b;
            Console.WriteLine($"{a} / {b} = {div}");
            return div;
        }
    }
}