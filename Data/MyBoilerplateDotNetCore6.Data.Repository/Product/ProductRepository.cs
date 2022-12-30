using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Entities;
using MyBoilerplateDotNetCore6.Entities.Product;
using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;

namespace MyBoilerplateDotNetCore6.Data.Repository.Product
{
    public class ProductRepository : BaseRepository<ProductEntity, ProductSearchConditions>
    {

        public ProductRepository(DbContext dbContext, ILogger logger)
            : base(dbContext, logger)
        {

        }

        public override GetAllResult<ProductEntity> GetAll(string keywords)
        {
            throw new NotImplementedException();
        }

        public override GetPagedResult<ProductEntity, ProductSearchConditions> GetPage(ProductSearchConditions conditions, int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

    }
}
