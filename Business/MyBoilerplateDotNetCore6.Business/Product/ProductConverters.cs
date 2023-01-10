using MyBoilerplateDotNetCore6.Entities.Product;
using MyBoilerplateDotNetCore6.ViewModel.Product;

namespace MyBoilerplateDotNetCore6.Business.Product
{
    public static class ProductConverters
    {

        public static void ConvertFrom(this ProductDetailsViewModel viewModel, ProductEntity entity)
        {
            viewModel = new ProductDetailsViewModel();

            if (entity != null)
            {
                viewModel = new ProductDetailsViewModel()
                {
                    Id = entity.Id,
                    Name = entity.ProductShortName
                };
            }

        }

    }
}
