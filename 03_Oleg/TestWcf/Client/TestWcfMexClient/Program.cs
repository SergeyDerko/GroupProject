using System;
using System.ServiceModel;
using System.Threading;
using TestMEXClient.TestWcfClientMex;


namespace TestWcfMexClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcClient client = new CalcClient();
            /*
            client.Sum(4 ,5);
            client.Substraction(10, 2);
            client.Multiplication(5, 4);
            client.Division(6, 7);
            */
            try
            {
                var random = new Random();
                for (var i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    var a = random.Next(1, 1000);
                    var b = random.Next(100, 1000);
                    var sum = client.Sum(a, b);
                    Console.WriteLine($" {a} + {b} = {sum}");
                    var sub = client.Substraction(a, b);
                    Console.WriteLine($" {a} - {b} = {sub}");
                    var mul = client.Multiplication(a, b);
                    Console.WriteLine($" {a} * {b} = {mul}");
                    var div = client.Division(a, b);
                    Console.WriteLine($" {a} / {b} = {div}");

                }
            }
            catch (EndpointNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Cервер не запущен!");
                Console.ResetColor();
            }

            Console.Write("\n Нажмите любую клавышу для выхода...");
            Console.ReadKey();
            
            // Всегда закройте клиент.
            client.Close();
        }
    }
}
