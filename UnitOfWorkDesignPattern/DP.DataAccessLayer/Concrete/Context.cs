using DP.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DP.UOW.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> Processes { get; set; }
    }
}
