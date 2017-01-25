using System.Data.Entity;
using TestWcfCommon.Types;

namespace TestWcfDB.Models
{
    public class StudentsContext : DbContext
    {
        public StudentsContext() : base("DBConnection")
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
