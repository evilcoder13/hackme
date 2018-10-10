using Microsoft.EntityFrameworkCore;
namespace hackme.Models
{
    public class DataContext:DbContext {
        public DbSet<Login> Logins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hackme.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Login>().HasData(new Login{ Password=System.Guid.NewGuid().ToString()});
        }
    }
    
}