namespace MyBoilerplateDotNetCore6.ViewModel.Application
{

    public class AppConfiguration
    {

        public DatabaseSection? Database { get; set; }

    }

    public class DatabaseSection
    {
        public string ConnectionString_MainDb { get; set; }
        public string ConnectionString_LogDb { get; set; }
    }

}
