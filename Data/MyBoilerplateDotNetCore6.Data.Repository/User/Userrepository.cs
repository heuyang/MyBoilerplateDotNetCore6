using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Data.SqlServer;
using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;
using MyBoilerplateDotNetCore6.Entities.User;

namespace MyBoilerplateDotNetCore6.Data.Repository.User
{
    public class UserRepository : BaseRepository<UserEntity, UserEntitySearchConditions>, IUserRepository
    {

        public UserRepository(SqlServerDbContext dbContext, ILogger logger)
            : base(dbContext, logger)
        {

        }

        public override GetAllResult<UserEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public override GetPagedResult<UserEntity, UserEntitySearchConditions> GetPage(UserEntitySearchConditions conditions, int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }

    }
}
