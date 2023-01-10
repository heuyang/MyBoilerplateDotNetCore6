using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Data.SqlServer;
using MyBoilerplateDotNetCore6.Entities.Product;
using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;

namespace MyBoilerplateDotNetCore6.Data.Repository.Product
{
    public class ProductRepository : BaseRepository<ProductEntity, ProductEntitySearchConditions>, IProductRepository
    {

        public ProductRepository(SqlServerDbContext dbContext, ILogger logger)
            : base(dbContext, logger)
        {

        }

        public override GetAllResult<ProductEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public override GetPagedResult<ProductEntity, ProductEntitySearchConditions> GetPage(ProductEntitySearchConditions conditions, int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

    }
}
