using Microsoft.EntityFrameworkCore;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Products { get; set; }

        public IEnumerable<User> Users;

        public List<OrderItem> OrderItem;

        private IConfiguration _config;
        public DatabaseContext(IConfiguration config)
        {
            _config = config;
            Users = [
               new User("1","Jon Jones","User","JonJones@gmail.com","1234"),
                new User("2","Stepe Miocic","User","StepeMiocic@gmail.com","1234"),
                new User("3","Max Holloway","User","MaxHolloway@gmail.com","1234"),
                new User("4","Dana White","Admin","DanaWhite@gmail.com","1234")
           ];
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
           .UseSnakeCaseNamingConvention();
        }
    }
}
