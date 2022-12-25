namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class CreateResult : BaseResult
    {

        public void SetToSucceeded(int newEntityId)
        {
            SetToSucceeded();
            EntityId = newEntityId;
        }

    }
}
