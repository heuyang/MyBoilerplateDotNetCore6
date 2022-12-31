using MyBoilerplateDotNetCore6.ViewModel;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;

namespace MyBoilerplateDotNetCore6.Business.BusinessActionResult
{

    public class Result<TViewModel> : SimpleResult where TViewModel : IViewModel
    {

        public TViewModel? ViewModel { get; set; }

    }
}
