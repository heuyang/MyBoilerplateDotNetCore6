using MyBoilerplateDotNetCore6.Business.BusinessActionResult;

namespace MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult.GenericResult
{
    public class ResultViewModelNotDeleted<TViewModel> : Result<TViewModel>
        where TViewModel : IViewModel
    {

        public ResultViewModelNotDeleted(int id)
        {
            SetAsFailed($"Failed to delete entity ({id}");
        }
    }

}
