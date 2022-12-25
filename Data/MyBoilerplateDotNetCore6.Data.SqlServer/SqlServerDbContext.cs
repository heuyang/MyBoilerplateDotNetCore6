using Microsoft.EntityFrameworkCore;
using MyBoilerplateDotNetCore6.Entities.Product;
using MyBoilerplateDotNetCore6.Entities.User;

namespace MyBoilerplateDotNetCore6.Data.SqlServer
{
    public class SqlServerDbContext : DbContext
    {

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<UserEntity> ProductOptions { get; set; }

        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
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
