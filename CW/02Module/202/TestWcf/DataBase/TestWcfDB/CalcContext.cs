using System.Data.Entity;
using TestWcfTypes.Expressions;

namespace TestWcfDB
{
    public class CalcContext : Context
    {
        public DbSet<Expression> Expressions { get; set; }
    }
}