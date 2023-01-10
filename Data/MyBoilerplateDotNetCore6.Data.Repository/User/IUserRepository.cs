using MyBoilerplateDotNetCore6.Entities.User;

namespace MyBoilerplateDotNetCore6.Data.Repository.User
{
    public interface IUserRepository : IGenericRepository<UserEntity, UserEntitySearchConditions>
    {
    }
}
