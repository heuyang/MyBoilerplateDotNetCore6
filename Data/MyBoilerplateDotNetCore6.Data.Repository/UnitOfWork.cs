using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Data.Repository.Product;
using MyBoilerplateDotNetCore6.Data.Repository.User;
using MyBoilerplateDotNetCore6.Data.SqlServer;

namespace MyBoilerplateDotNetCore6.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly SqlServerDbContext _context;

        public IProductRepository ProductRepository { get; set; }
        public IUserRepository UserRepository { get; set; }

        public UnitOfWork(SqlServerDbContext context, ILogger<UnitOfWork> logger)
        {
            _context = context;

            ProductRepository = new ProductRepository(_context, logger);
            UserRepository = new UserRepository(_context, logger);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
