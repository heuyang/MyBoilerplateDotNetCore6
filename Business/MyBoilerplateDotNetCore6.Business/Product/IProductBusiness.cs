using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.Product;

namespace MyBoilerplateDotNetCore6.Business.Product
{
    public interface IProductBusiness
    {

        BaseResult<ProductDetailsViewModel> GetProduct(int id);
        BaseResult<ViewModelPage<ProductListViewModel>> GetProductListPage(ProductSearchConditionsViewModel conditions, int pageIndex, int pageSize = 20);
        BaseSimpleResult CreateProduct(CreateProductViewModel newProductViewModel);
        BaseSimpleResult UpdateProduct(UpdateProductViewModel newProductViewModel);
        BaseSimpleResult DeleteProduct(int id);

    }
}
