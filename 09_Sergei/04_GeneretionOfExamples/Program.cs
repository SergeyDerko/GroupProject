
using System;

namespace _04_GeneretionOfExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввести первое число: ");
            var number1 = int.Parse(Console.ReadLine());
            Console.Write("Ввести второе число: ");
            var number2 = int.Parse(Console.ReadLine());
            var example = new Example(number1, number2);
            example.Next();
        }
    }
}
