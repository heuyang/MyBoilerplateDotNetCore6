using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.Entities.User;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.User;

namespace MyBoilerplateDotNetCore6.Business.User
{
    public interface IUserBusiness
    {
        Result<UserDetailsViewModel> GetProduct(int id);
        Result<ViewModelPage<UserListViewModel>> GetProductListPage(UserSearchConditionsViewModel conditions, int pageIndex, int pageSize = 20);
        SimpleResult CreateProduct(CreateUserViewModel newProductViewModel);
        SimpleResult UpdateProduct(UpdateUserViewModel newProductViewModel);
        SimpleResult DeleteProduct(int id);
    }

}
