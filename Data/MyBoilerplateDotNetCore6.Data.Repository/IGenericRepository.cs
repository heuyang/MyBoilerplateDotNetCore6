using MyBoilerplateDotNetCore6.Entities;
using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;

namespace MyBoilerplateDotNetCore6.Data.Repository
{
    public interface IGenericRepository<TEntity, TConditions>
        where TEntity : BaseEntity
        where TConditions : BaseSearchConditions
    {

        GetSingleResult<TEntity> GetById(int Id);
        GetPagedResult<TEntity, TConditions> GetPage(TConditions conditions, int pageSize, int pageIndex);
        GetAllResult<TEntity> GetAll(string keywords);
        CreateResult Create(TEntity entity);
        UpdateResult Update(TEntity entity);
        DeleteResult Delete(TEntity entity);


    }
}