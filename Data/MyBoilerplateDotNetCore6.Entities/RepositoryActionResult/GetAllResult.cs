namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class GetAllResult<TEntity> : BaseResult where TEntity : BaseEntity
    {

        public IEnumerable<TEntity> Entities { get; set; }

        public void SetToSucceeded(IEnumerable<TEntity> allEntities)
        {
            Entities = allEntities;
            SetToSucceeded();
        }

    }
}
