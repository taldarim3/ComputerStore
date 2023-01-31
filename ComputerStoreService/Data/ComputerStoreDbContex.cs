using Microsoft.EntityFrameworkCore;

namespace ComputerStoreService.Data
{
    public class ComputerStoreDbContex : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Item> Items { get; set; }

        public ComputerStoreDbContex()
        {

        }
        // подключение к бд
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=StoreServiceDb;Username=postgres;Password=Jopa18102001");
        }
    }
}