using System;

namespace _503_EF_CW
{
    class Program
    {
        static void Main()
        {
            using (var e = new Entities())
            {
                foreach (var customer in e.Customers)
                {
                    Console.WriteLine(customer);
                }
            }
            Console.ReadKey();
        }
    }
}
