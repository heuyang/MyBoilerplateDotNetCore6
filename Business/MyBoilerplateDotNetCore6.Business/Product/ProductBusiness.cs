using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.Product;

namespace MyBoilerplateDotNetCore6.Business.Product
{
    public class ProductBusiness : IProductBusiness
    {
        public BaseSimpleResult CreateProduct(CreateProductViewModel newProductViewModel)
        {
            throw new NotImplementedException();
        }

        public BaseSimpleResult DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResult<ProductDetailsViewModel> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResult<ViewModelPage<ProductListViewModel>> GetProductListPage(ProductSearchConditionsViewModel conditions, int pageIndex, int pageSize = 20)
        {
            throw new NotImplementedException();
        }

        public BaseSimpleResult UpdateProduct(UpdateProductViewModel newProductViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
