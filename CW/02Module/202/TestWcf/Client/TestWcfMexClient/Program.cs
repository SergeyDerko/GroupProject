using System;
using TestWcfMexClient.TestWcfReference;

namespace TestWcfMexClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcClient client = new CalcClient();

            var sum = client.Sum(8, 4);
            Console.ReadKey();
            // Use the 'client' variable to call operations on the service.

            // Always close the client.
            client.Close();
        }
    }
}
