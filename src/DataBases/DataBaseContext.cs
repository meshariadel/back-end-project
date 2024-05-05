
using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        private IConfiguration _config;
        public DatabaseContext(IConfiguration config)
        {
            _config = config;

        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host: localhost; Username=postgres; Password=mM121233; Database= ecommerce")
        .UseSnakeCaseNamingConvention();

    }
}