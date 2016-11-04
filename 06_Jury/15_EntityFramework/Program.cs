//материал взят с сайта http://professorweb.ru/my/entity-framework/6/level1/

using System;
using _503_EntityFramework.Model;

namespace _503_EntityFramework
{
    class Program
    {
        static void Main()
        {
            // Создать объект для записи в БД
            var customer = new Customer
            {
                FirstName = "Henry",
                LastName = "Second",
                Age = 30,
                City = "Odessa",
                BirthDate = DateTime.Now.AddYears(-30)
            };
            var order = new Order
            {
                ProductName = "Cheese",
                Description = "Swiss",
                PurchaseDate = DateTime.Now.AddDays(-10),
                Quantity = 2
            };
            using (var context = new SampleContext())
            {
                context.Customers.Add(customer);
                context.Orders.Add(order);
                context.SaveChanges();
                foreach (var contextCustomer in context.Customers)
                {
                    var t = contextCustomer;
                    Console.WriteLine($"{t.FirstName}, {t.City}");
                }
                foreach (var contextOrder in context.Orders)
                {
                    var t = contextOrder;
                    Console.WriteLine($"{t.ProductName}, {t.Description}");
                }
            }
            

            Console.ReadKey();
        }
    }
}
