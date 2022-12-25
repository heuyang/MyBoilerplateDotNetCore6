using Microsoft.EntityFrameworkCore;
using MyBoilerplateDotNetCore6.Entities.Product;
using MyBoilerplateDotNetCore6.Entities.User;

namespace MyBoilerplateDotNetCore6.Data.Sqlite
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<UserEntity> ProductOptions { get; set; }

        public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductEntityMapping());
            builder.ApplyConfiguration(new UserEntityMapping());
        }
    }
}