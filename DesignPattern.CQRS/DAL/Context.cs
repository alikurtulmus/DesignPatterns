using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-QBFPK40\\SQLEXPRESS;initial catalog=DesignPattern-CQRS;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
