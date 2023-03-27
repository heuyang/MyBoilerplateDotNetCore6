using System.Text;

namespace MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult.GenericResult
{
    public class ResultViewModelNotUpdated : SimpleResult
    {

        public ResultViewModelNotUpdated(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Failed to update entity.");
            if (!string.IsNullOrEmpty(message))
            {
                sb.AppendLine(message);
            }

            SetAsFailed(sb.ToString());
        }

    }
}
