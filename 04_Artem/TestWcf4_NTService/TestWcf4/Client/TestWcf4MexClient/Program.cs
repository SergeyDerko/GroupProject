using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestWcf4MexClient.TestWcfReference;

namespace TestWcf4MexClient

{
    class Program
    {
        static void Main(string[] args)
        {
            CalcClient client = new CalcClient();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Thread.Sleep(1000);
                    var sum = client.Sum(i, j);
                    Console.WriteLine($"{i} + {j} = {sum}");

                    var sub = client.Sub(i, j);
                    Console.WriteLine($"{i} - {j} = {sub}");

                    var mul = client.Mul(i, j);
                    Console.WriteLine($"{i} * {j} = {mul}");

                    var div = client.Div(i, j);
                    Console.WriteLine($"{i} / {j} = {div}");
                }
            }
             Console.ReadKey();
            client.Close();
        }
    }
}
