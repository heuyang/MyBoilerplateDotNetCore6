using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.Business.Helpers;
using MyBoilerplateDotNetCore6.Data.Repository;
using MyBoilerplateDotNetCore6.Entities.Product;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.Product;

namespace MyBoilerplateDotNetCore6.Business.Product
{
    public class ProductBusiness : IProductBusiness
    {

        private readonly ILogger _logger;
        private IUnitOfWork _uow;

        public ProductBusiness(ILogger logger, IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;
        }

        public SimpleResult CreateProduct(CreateProductViewModel newProductViewModel)
        {
            throw new NotImplementedException();
        }

        public SimpleResult DeleteProduct(int id)
        {
            throw new NotImplementedException();
            //var result = new SimpleResult();
            //var repositoryResult = _uow.ProductRepository.DeleteById(id);

            //if (repositoryResult != null)
            //{
            //    if (result.Success)
            //    {
            //        result.Success
            //    }
            //}
            //result.SetToFailed("Unable to complete delete operation. No details reported");
        }

        public Result<ProductDetailsViewModel> GetProduct(int id)
        {
            var viewModelResult = new Result<ProductDetailsViewModel>();

            // Get Entity
            var entityResult = _uow.ProductRepository.GetById(id);
            EntityResultHelpers.ValidateEntityResult(entityResult, viewModelResult);
            if (!viewModelResult.Success) return viewModelResult;

            // Convert Entity to ViewModel
            viewModelResult.ViewModel.ConvertFrom(entityResult.Entity);

            return viewModelResult;
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
