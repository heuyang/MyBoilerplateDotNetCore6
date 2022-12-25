namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class GetPagedResult<T, TConditions> : BaseResult 
        where T : class
        where TConditions : class
    {

        public IEnumerable<T>? Results { get; set; }
        public TConditions? Conditions { get; set; }
        public int RecordCount { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int PageCount
        {
            get
            {
                if (PageSize == 0) throw new ArgumentException("PageSize not set yet.");
                if (PageSize < 0) throw new ArgumentException($"Invalid PageSize value {PageSize}. Cannot be less than zero.");
                return (RecordCount - 1) / PageSize + 1;
            }
        }

    }
}
