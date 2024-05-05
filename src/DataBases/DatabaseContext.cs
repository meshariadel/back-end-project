using Microsoft.EntityFrameworkCore;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserOrder> UserOrder { get; set; }
        public DbSet<Product> Products { get; set; }

        public IEnumerable<User> Users;

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
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Database={_config["Db:Database"]};Password={_config["Db:Password"]}")
           .UseSnakeCaseNamingConvention();
        }
    }
}
