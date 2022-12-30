namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class CreateResult<TEntity> : BaseResult
        where TEntity : BaseEntity
    {
        public TEntity Entity { get; set; }

        public void SetToSucceeded(TEntity newEntity)
        {
            Entity = newEntity;
            SetToSucceeded();
        }

    }
}
