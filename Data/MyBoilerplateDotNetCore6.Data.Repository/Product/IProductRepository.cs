using MyBoilerplateDotNetCore6.Entities.Product;

namespace MyBoilerplateDotNetCore6.Data.Repository.Product
{
    public interface IProductRepository : IGenericRepository<ProductEntity, ProductEntitySearchConditions>
    {
    }
}
