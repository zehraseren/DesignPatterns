using Microsoft.EntityFrameworkCore;

namespace DP.ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Zehra;initial catalog=ChainOR;integrated security=true;");
        }
        public DbSet<CustomerProcess>? CustomerProcesses { get; set; }
    }
}
