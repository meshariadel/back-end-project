<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;
=======
>>>>>>> 5d04b37a6f7392ad42bc518d6e9190822d193017
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
        => optionsBuilder.UseNpgsql(@"Host: localhost; Username=myLogin; Password=mM121233; Database= ecommerce");


    }
}
