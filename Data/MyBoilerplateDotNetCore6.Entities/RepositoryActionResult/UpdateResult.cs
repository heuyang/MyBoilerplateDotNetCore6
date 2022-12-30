namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class UpdateResult<TEntity> : BaseResult
        where TEntity : BaseEntity
    {

        public TEntity Entity { get; set; }

        public void SetToSucceeded(TEntity updatedEntity)
        {
            Entity = updatedEntity;
            SetToSucceeded();
        }
    }
}
