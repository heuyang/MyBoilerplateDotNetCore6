using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Entities;
using MyBoilerplateDotNetCore6.Entities.Product;
using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;

namespace MyBoilerplateDotNetCore6.Data.Repository.Product
{
    public class ProductRepository : BaseRepository<ProductEntity, ProductEntitySearchConditions>
    {

        public ProductRepository(DbContext dbContext, ILogger logger)
            : base(dbContext, logger)
        {

        }

        public override GetAllResult<ProductEntity> GetAll(string keywords)
        {
            throw new NotImplementedException();
        }

        public override GetPagedResult<ProductEntity, ProductEntitySearchConditions> GetPage(ProductEntitySearchConditions conditions, int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

    }
}
