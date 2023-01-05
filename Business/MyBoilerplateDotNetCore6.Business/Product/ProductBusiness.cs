using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.Product;

namespace MyBoilerplateDotNetCore6.Business.Product
{
    public class ProductBusiness : IProductBusiness
    {

        private readonly ILogger _logger;

        public ProductBusiness(ILogger logger)
        {
            _logger = logger;
        }

        public SimpleResult CreateProduct(CreateProductViewModel newProductViewModel)
        {
            throw new NotImplementedException();
        }

        public SimpleResult DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Result<ProductDetailsViewModel> GetProduct(int id)
        {
            var result = new Result<ProductDetailsViewModel>();
            result.ViewModel = new ProductDetailsViewModel()
            {
                Id = 1,
                Name = "Ice lolly"
            };
            result.SetToSucceeded();

            return result;
        }

        public Result<ViewModelPage<ProductListViewModel>> GetProductListPage(ProductSearchConditionsViewModel conditions, int pageIndex, int pageSize = 20)
        {
            throw new NotImplementedException();
        }

        public SimpleResult UpdateProduct(UpdateProductViewModel newProductViewModel)
        {
            throw new NotImplementedException();
        }

    }
}
