using Microsoft.EntityFrameworkCore;
using MyBoilerplateDotNetCore6.Data.Sqlite;
using MyBoilerplateDotNetCore6.Data.SqlServer;
using MyBoilerplateDotNetCore6.WebApi.Models;

namespace MyBoilerplateDotNetCore6.WebApi.Helpers
{
    public static class StartupHelpers
    {

        public static bool ValidateConfiguration(ILogger logger, AppConfiguration config)
        {
            if (config.Database == null)
            {
                logger.LogError("Database configuration not found");
                return false;
            }
            if (config.Database.MainDb == null)
            {
                logger.LogError("MainDb configuration not found");
                return false;
            }

            return true;
        }

        public static bool TryInitDatabase(ILogger logger, AppConfiguration config, WebApplicationBuilder builder)
        {
            switch (config.Database.MainDb.DbType)
            {
                case "SQLite":
                    builder.Services.AddDbContext<SqliteDbContext>(options =>
                        options.UseSqlite(config.Database.MainDb.ConnectionString)
                    );
                    return true;
                case "SqlServer":
                    builder.Services.AddDbContext<SqlServerDbContext>(options =>
                        options.UseSqlServer(config.Database.MainDb.ConnectionString)
                    );
                    return true;
                default:
                    logger.LogError("Unable to initiate database due to unsupported database type.");
                    return false;
            }
        }

    }
}
