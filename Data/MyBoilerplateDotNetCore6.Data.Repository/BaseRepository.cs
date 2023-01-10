using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyBoilerplateDotNetCore6.Data.SqlServer;
using MyBoilerplateDotNetCore6.Entities;
using MyBoilerplateDotNetCore6.Entities.RepositoryActionResult;
using System.Xml.Linq;

namespace MyBoilerplateDotNetCore6.Data.Repository
{
    public class BaseRepository<TEntity, TConditions> : IGenericRepository<TEntity, TConditions>
        where TEntity : BaseEntity
        where TConditions : BaseEntitySearchConditions
    {
        private readonly ILogger _logger;
        protected readonly SqlServerDbContext _context;

        public BaseRepository(SqlServerDbContext dbContext, ILogger logger)
        {
            _context = dbContext;

            _context.Database.EnsureCreated();
        }

        public CreateResult<TEntity> Create(TEntity entity)
        {
            var result = new CreateResult<TEntity>();
            try
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            result.SetToSucceeded(entity);
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

        public DeleteResult DeleteById(int id)
        {
            var result = new DeleteResult();

            var entityResult = GetById(id);
            if (entityResult.Success)
            {
                return Delete(entityResult.Entity);
            }
            else
            {
                result.SetToFailed(entityResult.Message);
            }

            return result;

        }

        public virtual GetAllResult<TEntity> GetAll()
        {
            throw new NotImplementedException("To be implemented or disabled");
        }

        public GetSingleResult<TEntity> GetById(int id)
        {
            var result = new GetSingleResult<TEntity>();

            try
            {
                var entities = _context.Set<TEntity>()
                    .AsNoTracking()
                    .First(x => x.Id == id);
                result.SetToSucceeded(entities);
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

        public UpdateResult<TEntity> Update(TEntity entity)
        {
            var result = new UpdateResult<TEntity>();

            try
            {
                _context.Set<TEntity>().Update(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();

                result.SetToSucceeded(entity);
            }
            catch (Exception ex)
            {
                result.SetError(ex.Message);
            }

            return result;
        }

    }
}
