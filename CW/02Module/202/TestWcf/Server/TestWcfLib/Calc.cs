using System;
using System.ServiceModel;
using TestWcfCommon;

namespace TestWcfLib
{
    public class Calc : ICalc
    {
        public int Sum(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
            return sum;
        }

        public static void Main()
        {
            var address = new Uri("http://localhost:555/ICalc");
            var binding = new BasicHttpBinding();
            var contract = typeof(ICalc);

            var host = new ServiceHost(typeof(Calc));
            host.AddServiceEndpoint(contract, binding, address);
            host.Open();

            Console.WriteLine("Сервер запущен");
            Console.ReadKey();

            var calc = new Calc();
            var a = 2;
            var b = 3;

            Console.WriteLine($"{a} + {b} = {calc.Sum(2, 3)}");
            Console.ReadKey();
        }
    }
}