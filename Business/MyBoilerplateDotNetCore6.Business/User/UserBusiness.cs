using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.User;

namespace MyBoilerplateDotNetCore6.Business.User
{
    public class UserBusiness : IUserBusiness
    {
        public SimpleResult CreateProduct(CreateUserViewModel newProductViewModel)
        {
            throw new NotImplementedException();
        }

        public SimpleResult DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Result<UserDetailsViewModel> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Result<ViewModelPage<UserListViewModel>> GetProductListPage(UserSearchConditionsViewModel conditions, int pageIndex, int pageSize = 20)
        {
            throw new NotImplementedException();
        }

        public SimpleResult UpdateProduct(UpdateUserViewModel newProductViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
