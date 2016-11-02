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
                FirstName = "Вася",
                LastName = "Пупкин",
                Age = 27,
                City = "Москва",
                BirthDate = DateTime.Now.AddYears(-27)
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
        }
    }
}
