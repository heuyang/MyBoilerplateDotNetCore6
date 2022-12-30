using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Entities.Product;
using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;
using MyBoilerplateDotNetCore6.Entities.User;

namespace MyBoilerplateDotNetCore6.Data.Repository.User
{
    public class UserRepository : BaseRepository<UserEntity, UserSearchConditions>
    {

        public UserRepository(DbContext dbContext, ILogger logger)
            : base(dbContext, logger)
        {

        }

        public override GetAllResult<UserEntity> GetAll(string keywords)
        {
            throw new NotImplementedException();
        }

        public override GetPagedResult<UserEntity, UserSearchConditions> GetPage(UserSearchConditions conditions, int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

    }
}
