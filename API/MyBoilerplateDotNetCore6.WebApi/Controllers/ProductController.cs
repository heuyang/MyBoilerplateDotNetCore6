using Microsoft.AspNetCore.Mvc;
using MyBoilerplateDotNetCore6.Business.Product;

namespace MyBoilerplateDotNetCore6.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private IProductBusiness productBusiness;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
            productBusiness = new ProductBusiness();
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                // To Do: Validate request (JWT or token)


                // To: Do: Validate request parameter(s)


                var result = productBusiness.GetProduct(id);
                if (!result.Success) return BadRequest(result.Message);
                if (result.ViewModel == null) return NotFound(Messages.GenericMessage_ObjectNotFoundById("product", id));

                return Ok(result.ViewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
#if DEBUG
                _logger.LogError(ex.StackTrace);
#endif
                return BadRequest(Messages.GenericMessage_InternalServerError);
            }

        }
    }
}
