using System.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class DatabaseContext : Db_Context
    {
        public Db_Set<Order> Order { get; set; }
        public Db_Set<Product> Product { get; set; }
        public Db_Set<User> User { get; set; }
        public Db_Set<OrderItem> OrderItem { get; set; }

        public Db_Set<Category> Category { get; set; }
        // public Db_Set<Payment> Payment { get; set; }
        public DatabaseContext(Db_ContextOptions<DatabaseContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<Role>();
            modelBuilder.HasPostgresEnum<ProductSize>();


        }
    }
}