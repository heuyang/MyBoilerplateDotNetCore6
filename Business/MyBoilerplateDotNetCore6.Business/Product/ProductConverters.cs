using MyBoilerplateDotNetCore6.Entities.Product;
using MyBoilerplateDotNetCore6.ViewModel.Product;

namespace MyBoilerplateDotNetCore6.Business.Product
{
    public static class ProductConverters
    {

        public static ProductDetailsViewModel ToProductDetailsViewModel(ProductEntity entity)
        {
            if (entity == null) return null;

            var viewModel = new ProductDetailsViewModel()
            {
                Id = entity.Id,
                Name = entity.ProductShortName
            };

            return viewModel;
        }

        public static ProductEntity ToProductEntity(CreateProductViewModel viewModel)
        {
            if (viewModel == null) return null;

            var entity = new ProductEntity()
            {
                ProductShortName = viewModel.ProductShortName,
                ProductFullName = viewModel.ProductFullName,
                Description = viewModel.Description,
                StandardUnitPrice = viewModel.StandardUnitPrice,
                StandardUnitCost = viewModel.StandardUnitCost,
                StandardUnitOfMeasure = viewModel.StandardUnitOfMeasure
            };

            return entity;
        }

    }
}
