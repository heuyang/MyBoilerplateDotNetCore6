namespace MyBoilerplateDotNetCore6.ViewModel.BusinessActionResult
{
    public class SimpleResult
    {
        public bool Success { get; private set; } = false;
        public string Message { get; private set; } = string.Empty;

        public void SetError(string message)
        {
            Success = false;
            Message = message;
        }

        public void SetToSucceeded()
        {
            Success = true;
            Message = string.Empty;
        }

        public void SetToFailed(string message)
        {
            Success = false;
            Message = message;
        }

    }
}
