
using System;
using System.Data.Entity;

namespace _503_EF_CW
{
    class Program
    {
        static void Main()
        {
            var user = new User();
            user.IdUser = 0;
            user.Name = Guid.NewGuid().ToString("N").ToUpper();
            user.SName = Guid.NewGuid().ToString("N").ToUpper();
            user.Age = 25;

            using (new EFContext())
            {
                
            }
        }
    }

    internal class EFContext : DbContext, IDisposable
    {
        public DbSet<User> Users { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Освобождение не управляемых русурсов");
        }
    }
}
