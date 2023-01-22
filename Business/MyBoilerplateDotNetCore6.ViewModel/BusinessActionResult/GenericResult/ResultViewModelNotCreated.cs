using System.Text;

namespace MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult.GenericResult
{
    public class ResultViewModelNotCreated : SimpleResult
    {

        public ResultViewModelNotCreated(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Failed to create entity.");
            sb.AppendLine(message);

            SetAsFailed(sb.ToString());
        }
    }
}
