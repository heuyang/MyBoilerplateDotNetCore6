namespace MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult
{
    public class SimpleResult
    {
        public bool Success { get; private set; } = false;
        public string Message { get; private set; } = string.Empty;

        public void SetAsSucceeded()
        {
            Success = true;
            Message = string.Empty;
        }

        public void SetAsFailed(string message)
        {
            Success = false;
            Message = message;
        }

    }
}
