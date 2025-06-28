using DP.Repo.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DP.Repo.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
