using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestWcfClient_Mex.ServiceReference1;

namespace TestWcfClient_Mex
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CalcClient();

            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                var a = random.Next(1, 1000);
                var b = random.Next(100, 1000);
                var sum = client.Sum(a, b);
                Console.WriteLine($" {a} + {b} = {sum}");
            }

            Console.Write("\n Нажмите любую клавышу для выхода...");
            Console.ReadKey();


            client.Close();
        }
    }
}
