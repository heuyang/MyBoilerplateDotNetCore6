using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.Entities.User;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.User;

namespace MyBoilerplateDotNetCore6.Business.User
{
    public interface IUserBusiness
    {
        BaseResult<UserDetailsViewModel> GetProduct(int id);
        BaseResult<ViewModelPage<UserListViewModel>> GetProductListPage(UserSearchConditionsViewModel conditions, int pageIndex, int pageSize = 20);
        BaseSimpleResult CreateProduct(CreateUserViewModel newProductViewModel);
        BaseSimpleResult UpdateProduct(UpdateUserViewModel newProductViewModel);
        BaseSimpleResult DeleteProduct(int id);
    }

}
