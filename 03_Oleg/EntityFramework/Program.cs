﻿//материал взят с сайта http://professorweb.ru/my/entity-framework/6/level1/

using System;
using EntityFramework.Model;

namespace EntityFramework
{
    class Program
    {
        static void Main()
        {
            // Создать объект для записи в БД
            var customer = new Customer
            {
                FirstName = "Вася",
                LastName = "Пупкин",
                Age = 27,
                City = "Москва",
                BirthDate = DateTime.Now.AddYears(-27)
            };

            var orderr = new Order
            {
               ProductName = "GALYA",
               Description = "MOLODAYA",
               Quantity = 23
            };

            // Создать объект контекста
            using (var context = new SampleContext())
            {
                // Вставить объект в БД и сохранить изменения
                context.Customers.Add(customer);
                context.SaveChanges();
                foreach (var contextCustomer in context.Customers)
                {
                    var t = contextCustomer;
                }
            }

            using (var oRcontext = new SampleContext())
            {
                // Вставить объект в БД и сохранить изменения
                oRcontext.Orders.Add(orderr);
                oRcontext.SaveChanges();
                foreach (var oderCustomer in oRcontext.Orders)
                {
                    var p = oderCustomer;
                }
            }
        }
    }
}
