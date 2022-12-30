using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.User;

namespace MyBoilerplateDotNetCore6.Business.User
{
    public class UserBusiness : IUserBusiness
    {
        public BaseSimpleResult CreateProduct(CreateUserViewModel newProductViewModel)
        {
            throw new NotImplementedException();
        }

        public BaseSimpleResult DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResult<UserDetailsViewModel> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResult<ViewModelPage<UserListViewModel>> GetProductListPage(UserSearchConditionsViewModel conditions, int pageIndex, int pageSize = 20)
        {
            throw new NotImplementedException();
        }

        public BaseSimpleResult UpdateProduct(UpdateUserViewModel newProductViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
