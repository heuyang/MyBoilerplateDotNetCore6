using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.Product;

namespace MyBoilerplateDotNetCore6.Business.Product
{
    public interface IProductBusiness
    {

        Result<ProductDetailsViewModel> GetProduct(int id);
        Result<ViewModelPage<ProductListViewModel>> GetProductListPage(ProductSearchConditionsViewModel conditions, int pageIndex, int pageSize = 20);
        SimpleResult CreateProduct(CreateProductViewModel newProductViewModel);
        SimpleResult UpdateProduct(UpdateProductViewModel newProductViewModel);
        SimpleResult DeleteProduct(int id);

    }
}
