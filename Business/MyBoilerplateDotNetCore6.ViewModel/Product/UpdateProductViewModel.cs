namespace MyBoilerplateDotNetCore6.ViewModel.Product
{
    public class UpdateProductViewModel : IViewModel
    {

        public int Id { get; set; }
        public string ProductShortName { get; set; }
        public string ProductFullName { get; set; }
        public string Description { get; set; }
        public decimal StandardUnitPrice { get; set; }
        public decimal StandardUnitCost { get; set; }
        public string? StandardUnitOfMeasure { get; set; }

    }
}
