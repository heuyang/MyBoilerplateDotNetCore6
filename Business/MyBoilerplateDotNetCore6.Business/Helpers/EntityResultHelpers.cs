using MyBoilerplateDotNetCore6.Business.BusinessActionResult;
using MyBoilerplateDotNetCore6.Entities;
using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;
using MyBoilerplateDotNetCore6.ViewModel;

namespace MyBoilerplateDotNetCore6.Business.Helpers
{
    public static class EntityResultHelpers
    {

        public static void ValidateEntityResult<TEntity, TViewModel>(GetSingleResult<TEntity> entityResult, Result<TViewModel> viewModelResult)
            where TEntity : BaseEntity
            where TViewModel : IViewModel
        {

            if (entityResult == null)
            {
                viewModelResult.SetAsFailed("Failed to fetch data from database");
                return;
            }
            if (!entityResult.Success)
            {
                viewModelResult.SetAsFailed(entityResult.Message);
                return;
            }

        }

    }
}
