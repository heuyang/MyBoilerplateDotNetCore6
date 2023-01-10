using MyBoilerplateDotNetCore6.Entities;
using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;

namespace MyBoilerplateDotNetCore6.Data.Repository
{
    public interface IGenericRepository<TEntity, TConditions>
        where TEntity : BaseEntity
        where TConditions : BaseEntitySearchConditions
    {

        GetSingleResult<TEntity> GetById(int Id);
        GetPagedResult<TEntity, TConditions> GetPage(TConditions conditions, int pageSize, int pageIndex);
        GetAllResult<TEntity> GetAll();
        CreateResult<TEntity> Create(TEntity entity);
        UpdateResult<TEntity> Update(TEntity entity);
        DeleteResult Delete(TEntity entity);
        DeleteResult DeleteById(int id);


    }
}