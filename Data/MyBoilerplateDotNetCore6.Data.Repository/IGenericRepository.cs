using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;

namespace MyBoilerplateDotNetCore6.Data.Repository
{
    public interface IGenericRepository<T, TConditions>
        where T : class
        where TConditions : class
    {

        T GetById(Guid id);
        GetSingleResult<T> GetById(int Id);
        GetPagedResult<T, TConditions> GetPage(TConditions conditions, int pageSize, int pageIndex);
        GetAllResult<T> GetAll(string keywords);
        CreateResult Create(T entity);
        UpdateResult Update(T entity);
        DeleteResult Delete(T entity);


    }
}