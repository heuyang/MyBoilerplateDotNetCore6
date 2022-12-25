namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class DeleteResult : BaseResult
    {
        public void SetToSucceeded(int deletedEntityId)
        {
            SetToSucceeded();
            EntityId = deletedEntityId;
        }

    }
}
