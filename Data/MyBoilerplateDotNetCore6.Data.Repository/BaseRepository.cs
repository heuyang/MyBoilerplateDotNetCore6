using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Entities;
using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;
using System.Xml.Linq;

namespace MyBoilerplateDotNetCore6.Data.Repository
{
    public class BaseRepository<TEntity, TConditions> : IGenericRepository<TEntity, TConditions>
        where TEntity : BaseEntity
        where TConditions : BaseEntitySearchConditions
    {
        protected readonly DbContext _context;

        public BaseRepository(DbContext dbContext, ILogger logger)
        {
            _context = dbContext;
        }

        public CreateResult Create(TEntity entity)
        {
            var result = new CreateResult();
            try
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            result.SetToSucceeded(entity.Id);
            return result;
        }

        public DeleteResult Delete(TEntity entity)
        {
            var result = new DeleteResult();

            try
            {
                _context.Set<TEntity>().Remove(entity);
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            result.SetToSucceeded(entity.Id);
            return result;
        }

        public virtual GetAllResult<TEntity> GetAll(string keywords)
        {
            throw new NotImplementedException("To be implemented or disabled");
        }

        public GetSingleResult<TEntity> GetById(int id)
        {
            var result = new GetSingleResult<TEntity>();

            try
            {
                result.Entity = _context.Set<TEntity>()
                    .AsNoTracking()
                    .First(x => x.Id == id);
                result.EntityId = id;
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            return result;
        }

        public virtual GetPagedResult<TEntity, TConditions> GetPage(TConditions conditions, int pageSize, int pageIndex)
        {
            throw new NotImplementedException("To be implemented or disabled");
        }

        public UpdateResult Update(TEntity entity)
        {
            var result = new UpdateResult();

            try
            {
                _context.Set<TEntity>().Update(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            result.SetToSucceeded();
            return result;
        }
    }
}
