using _503_EF.model;
using System;

namespace _503_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать объект для записи в БД
            var customer = new Customer
            {
                FirstName = "Вася",
                LastName = "Пупкин",
                Age = 27,
                City = "Москва",
                BirthDate = DateTime.Now.AddYears(27)
            };

            var orderr = new Order
            {
                ProductName = "GALYA",
                Description = "MOLODAYA",
                Quantity = 23,
                PurchaseDate = DateTime.Now.AddDays(10)
            };

            // Создать объект контекста
            using (var context = new Context())
            {
                // Вставить объект в БД и сохранить изменения
                context.Customers.Add(customer);
                context.SaveChanges();
                foreach (var contextCustomer in context.Customers)
                {
                    var t = contextCustomer;
                }
                context.Orders.Add(orderr);
                context.SaveChanges();
                foreach (var oderCustomer in context.Orders)
                {
                    var t = oderCustomer;
                }
            }
            
        }
    }
}
