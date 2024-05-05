using Microsoft.EntityFrameworkCore;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class UserOrderDatabaseContext : DbContext
    {
        public DbSet<UserOrder> userOrder { get; set; }
        private IConfiguration _config;
        public UserOrderDatabaseContext(IConfiguration config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Database={_config["Db:Database"]};Password={_config["Db:Password"]}")
           .UseSnakeCaseNamingConvention();
        }
    }
}
