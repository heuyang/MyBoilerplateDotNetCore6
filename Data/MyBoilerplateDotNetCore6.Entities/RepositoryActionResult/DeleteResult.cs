namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class DeleteResult : BaseResult
    {
        public int EntityId { get; set; }

        public void SetToSucceeded(int deletedEntityId)
        {
            EntityId = deletedEntityId;
            SetToSucceeded();
        }

    }
}
