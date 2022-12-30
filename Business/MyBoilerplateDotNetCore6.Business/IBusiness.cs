using Microsoft.EntityFrameworkCore.Metadata;
using MyBoilerplateDotNetCore6.Entities;
using MyBoilerplateDotNetCore6.ViewModel;

namespace MyBoilerplateDotNetCore6.Business
{
    public interface IBusiness<TEntity, TEntityConditions, TViewModel, TSearchConfitionsViewModel>
        where TEntity : BaseEntity
        where TEntityConditions : BaseEntitySearchConditions
        where TViewModel : IViewModel
        where TSearchConfitionsViewModel : ISearchConditionsViewModel
    {

        // CRUD

    }
}
