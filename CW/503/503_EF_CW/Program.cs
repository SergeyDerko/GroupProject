
using System;
using System.Data.Entity;

namespace _503_EF_CW
{
    class Program
    {
        static void Main()
        {
            var user = new User
            {
                Name = Guid.NewGuid().ToString("N").ToUpper(),
                SName = Guid.NewGuid().ToString("N").ToUpper(),
                Age = 25
            };

            using (var context = new EfContext())
            {
                context.Users.Add(user);
                foreach (var contextUser in context.Users)
                {
                    var t = contextUser;
                }
                context.SaveChanges();
            }
        }
    }

    internal class EfContext : DbContext//, IDisposable
    {
        public DbSet<User> Users { get; set; }

        //public void Dispose()
        //{
        //    Console.WriteLine("Освобождение не управляемых русурсов");
        //}
    }
}
