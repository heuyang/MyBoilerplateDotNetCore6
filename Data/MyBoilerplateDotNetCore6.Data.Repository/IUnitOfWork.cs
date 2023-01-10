using MyBoilerplateDotNetCore6.Data.Repository.Product;
using MyBoilerplateDotNetCore6.Data.Repository.User;

namespace MyBoilerplateDotNetCore6.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {

        IProductRepository ProductRepository { get; }
        IUserRepository UserRepository { get; }

        int Commit();

    }
}
