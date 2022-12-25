namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class GetSingleResult<T> : BaseResult where T : class
    {

        public T Entity { get; set; }

    }
}
