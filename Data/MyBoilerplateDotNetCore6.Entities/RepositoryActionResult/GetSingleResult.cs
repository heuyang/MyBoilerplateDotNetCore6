namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class GetSingleResult<TEntity> : BaseResult 
        where TEntity : BaseEntity
    {

        public TEntity Entity { get; set; }

        public void SetToSucceeded(TEntity fetchedEntity)
        {
            Entity = fetchedEntity;
            SetToSucceeded();
        }

    }
}
