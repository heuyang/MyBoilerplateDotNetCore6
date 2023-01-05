using Microsoft.AspNetCore.Mvc;
using MyBoilerplateDotNetCore6.ViewModel.Application;

namespace MyBoilerplateDotNetCore6.WebApi
{
    public class AppControllerBase : ControllerBase
    {

        public AppControllerBase(ILogger logger, AppConfiguration config)
        { 
            
        }

    }
}
