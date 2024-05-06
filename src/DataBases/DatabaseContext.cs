using Microsoft.EntityFrameworkCore;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserOrder> UserOrder { get; set; }
        public DbSet<Product> Product { get; set; }

        public DbSet<User> User { get; set; }

        public List<OrderItem> OrderItem;

        private IConfiguration _config;
        public DatabaseContext(IConfiguration config)
        {
            _config = config;
            OrderItem = [
                 new OrderItem(1,100),
                new OrderItem(2,200),
                new OrderItem(6,7700),
                new OrderItem(3,1300)
            ];
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Database={_config["Db:Database"]};Password={_config["Db:Password"]}")
           .UseLowerCaseNamingConvention().UseSnakeCaseNamingConvention();
        }
    }
}
