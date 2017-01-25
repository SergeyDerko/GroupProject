using System.Data.Entity;
using TestWcfTypes;

namespace TestWcfDB
{
    public class StudentsContext : Context
    {
        public DbSet<Student> Students { get; set; }
    }
}
