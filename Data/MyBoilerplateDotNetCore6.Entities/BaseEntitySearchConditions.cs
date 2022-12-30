namespace MyBoilerplateDotNetCore6.Entities
{
    public class BaseEntitySearchConditions : ISearchConditions
    {
        public List<int>? SpecificIds { get; set; }
    }
}
