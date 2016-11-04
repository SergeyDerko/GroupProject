using System;

namespace _503_EFDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Entities())
            {
                foreach (var contextCustomer in context.Customers)
                {
                    Console.WriteLine(contextCustomer);
                }
            }
        }
    }
}
