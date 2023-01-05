using MyBoilerplateDotNetCore6.ViewModel.Application;

namespace MyBoilerplateDotNetCore6.WebApi.Helpers
{
    public static class StartupHelpers
    {

        public static bool ValidateConfiguration(ILogger logger, AppConfiguration config)
        {
            if (config.Database == null)
            {
                logger.LogError("Database configuration not found.");
                return false;
            }
            if (string.IsNullOrEmpty(config.Database.ConnectionString_MainDb))
            {
                logger.LogError("ConnectionString of MainDb not set.");
                return false;
            }
            if (string.IsNullOrEmpty(config.Database.ConnectionString_LogDb))
            {
                logger.LogError("ConnectionString of LogDb not set.");
                return false;
            }

            return true;
        }

    }
}
