using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-QBFPK40\\SQLEXPRESS;initial catalog=DesignPattern-Mediator;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
