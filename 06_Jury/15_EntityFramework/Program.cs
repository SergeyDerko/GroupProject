//материал взят с сайта http://professorweb.ru/my/entity-framework/6/level1/

using System;
using _503_EntityFramework.Model;

namespace _503_EntityFramework
{
    class Program
    {
        static void Main()
        {
            //var customer = new Customer
            //{
            //    FirstName = "Henry",
            //    LastName = "Second",
            //    Age = 30,
            //    City = "Odessa",
            //    BirthDate = DateTime.Now.AddYears(-30)
            //};
            //var order = new Order
            //{
            //    ProductName = "Cheese",
            //    Description = "Swiss",
            //    PurchaseDate = DateTime.Now.AddDays(-10),
            //    Quantity = 2
            //};
            using (var context = new SampleContext())
            {
                //context.Customers.Add(customer);
                //context.Orders.Add(order);
                //context.SaveChanges();

               
                foreach (var contextCustomer in context.Customers)
                {
                    Console.WriteLine(
                        $" {contextCustomer.IdCustomer} {contextCustomer.FirstName} {contextCustomer.LastName} {contextCustomer.City} {contextCustomer.BirthDate}");
                }
                Console.WriteLine();
                foreach (var contextOrder in context.Orders)
                {
                    Console.WriteLine($" {contextOrder.OrderId} {contextOrder.ProductName} {contextOrder.Description} {contextOrder.PurchaseDate} {contextOrder.Quantity}");
                }



            }


            Console.ReadKey();
        }
    }
}
