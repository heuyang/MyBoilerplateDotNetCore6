using MyBoilerplateDotNetCore6.ViewModel;
using MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult;

namespace MyBoilerplateDotNetCore6.Business.BusinessActionResult
{

    public class BaseResult<TViewModel> : BaseSimpleResult where TViewModel : IViewModel
    {

        public TViewModel? Result { get; set; }

    }
}
