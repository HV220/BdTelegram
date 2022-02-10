using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BdTelegram
{
    internal class Context : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=;database=;user=;password=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItem>().Property(s => s.Status).HasDefaultValue(true);
            modelBuilder.Entity<Product>().Property(p => p.Status).HasDefaultValue(true);
        }
        
    }
}
