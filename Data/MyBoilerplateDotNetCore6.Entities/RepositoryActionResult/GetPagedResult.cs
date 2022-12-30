namespace MyBoilerplateDotNetCore6.Entities.RepositoryActionResult
{
    public class GetPagedResult<TEntity, TConditions> : BaseResult
        where TEntity : class
        where TConditions : class
    {

        public IEnumerable<TEntity>? PagedEntities { get; set; }
        public TConditions? Conditions { get; set; }
        public int RecordCount { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalPages
        {
            get
            {
                if (PageSize == 0) throw new ArgumentException("PageSize not set yet.");
                if (PageSize < 0) throw new ArgumentException($"Invalid PageSize value {PageSize}. Cannot be less than zero.");
                return (RecordCount - 1) / PageSize + 1;
            }
        }

        public void SetToSucceeded(
            int recordCount,
            int pageIndex,
            int pageSize,
            TConditions appliedConditions,
            IEnumerable<TEntity> pagedEntities)
        {
            RecordCount = recordCount;
            PageIndex = pageIndex;
            PageSize = pageSize;
            Conditions = appliedConditions;
            PagedEntities = pagedEntities;
            SetToSucceeded();
        }

    }
}
