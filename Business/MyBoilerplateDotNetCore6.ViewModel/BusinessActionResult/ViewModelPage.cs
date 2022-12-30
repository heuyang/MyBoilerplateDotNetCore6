namespace MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult
{
    public class ViewModelPage<TViewModel> : IViewModel
        where TViewModel : IViewModel
    {

        public List<TViewModel> ViewModels { get; set; }
        public int totalCount { get; set; }
        public int page { get; set; }
        public int totalPages { get; set; }
        public int pageSize { get; set; }

    }
}