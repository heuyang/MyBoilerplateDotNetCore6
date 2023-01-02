using System.Data;

namespace MyBoilerplateDotNetCore6.WebApi.Models
{
    public class AppConfiguration
    {

        public DatabaseSection? Database { get; set; }

    }

    public class DatabaseSection
    {
        public DatabaseConfiguration? MainDb { get; set; }
    }

    public class DatabaseConfiguration
    {
        public string DbType { get; set; }
        public string ConnectionString { get; set; }
        public string ActionIfNotExisting { get; set; }
    }
}
