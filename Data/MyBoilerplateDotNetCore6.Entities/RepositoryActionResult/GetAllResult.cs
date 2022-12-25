namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class GetAllResult<T> : BaseResult where T : class
    {

        public IEnumerable<T> Results { get; set; }

    }
}
