using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.Business.Helpers;
using MyBoilerplateDotNetCore6.Data.Repository;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult.GenericResult;
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
            var simpleResult = new SimpleResult();

            if (newProductViewModel == null)
            {
                simpleResult.SetAsFailed("Unable to create entity with null value provided");
                return simpleResult;
            }

            var entity = ProductConverters.ToProductEntity(newProductViewModel);
            if (entity == null)
            {
                simpleResult.SetAsFailed("Unable to convert to entity for creation.");
                return simpleResult;
            }

            var entityResult = _uow.ProductRepository.Create(entity);
            if (!entityResult.Success)
            {
                return new ResultViewModelNotCreated(entityResult.Message);
            }
            else if (entityResult.Entity.Id <= 0)
            {
                return new ResultViewModelNotCreated("Failed to add entity to database.");
            }

            return new ResultViewModelCreated();
        }

        public SimpleResult DeleteProduct(int id)
        {
            var viewModelResult = new Result<DeleteProductViewModel>();

            // Delete Entity
            var entityResult = _uow.ProductRepository.DeleteById(id);
            if (!entityResult.Success)
            {
                return new ResultViewModelNotDeleted<DeleteProductViewModel>(id);
            }

            return new ResultViewModeleleted();
        }

        public Result<ProductDetailsViewModel> GetProduct(int id)
        {
            var viewModelResult = new Result<ProductDetailsViewModel>();

            // Get Entity
            var entityResult = _uow.ProductRepository.GetById(id);
            EntityResultHelpers.ValidateEntityResult(entityResult, viewModelResult);
            if (!entityResult.Success)
            {
                return new ResultViewModelNotFound<ProductDetailsViewModel>();
            }

            // Get ViewModel
            viewModelResult.ViewModel = ProductConverters.ToProductDetailsViewModel(entityResult.Entity);
            viewModelResult.SetAsSucceeded();

            return viewModelResult;
        }

        public Result<ViewModelPage<ProductListViewModel>> GetProductListPage(ProductSearchConditionsViewModel conditions, int pageIndex, int pageSize = 20)
        {
            throw new NotImplementedException();
        }

        public SimpleResult UpdateProduct(UpdateProductViewModel updateProductViewModel)
        {
            var simpleResult = new SimpleResult();

            if (updateProductViewModel == null)
            {
                simpleResult.SetAsFailed("Unable to update entity with null value provided");
                return simpleResult;
            }

            var entity = ProductConverters.ToProductEntity(updateProductViewModel);
            if (entity == null)
            {
                simpleResult.SetAsFailed("Unable to convert to entity for creation.");
                return simpleResult;
            }

            var entityResult = _uow.ProductRepository.Update(entity);
            if (!entityResult.Success)
            {
                return new ResultViewModelNotUpdated(entityResult.Message);
            }
            else if (entityResult.Entity.Id <= 0)
            {
                return new ResultViewModelNotUpdated("Failed to add entity to database.");
            }

            return new ResultViewModelUpdated();
        }

    }
}
