namespace MyBoilerplateDotNetCore6.Entities.Product
{
    public class ProductEntity : BaseEntity
    {
        public string ProductShortName { get; set; }
        public string ProductFullName { get; set; }
        public string Description { get; set; }
        public decimal? StandardUnitPrice { get; set; }
        public decimal? StandardUnitCost { get; set; }
        public string? StandardUnitOfMeasure { get; set; }


    }
}
