using MyBoilerplateDotNetCore6.Business.BusinessActionResult;

namespace MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult.GenericResult
{
    public class ResultViewModelNotFound<TViewModel> : Result<TViewModel>
        where TViewModel : IViewModel
    {

        public ResultViewModelNotFound()
        {
            SetAsFailed("No valid data found");
        }
    }
}
