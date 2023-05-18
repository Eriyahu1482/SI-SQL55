using Microsoft.EntityFrameworkCore;

namespace SI_SQL55.Model
{
    class ModelContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = SI_SQL55");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}