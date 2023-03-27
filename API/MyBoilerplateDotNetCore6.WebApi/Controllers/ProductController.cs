using Microsoft.AspNetCore.Mvc;
using MyBoilerplateDotNetCore6.Business.Product;
using MyBoilerplateDotNetCore6.Data.Repository;
using MyBoilerplateDotNetCore6.ViewModel.Product;

namespace MyBoilerplateDotNetCore6.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private IUnitOfWork _uow;

        private IProductBusiness productBusiness;

        public ProductController(ILogger<ProductController> logger, IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;

            productBusiness = new ProductBusiness(_logger, _uow);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                // To Do: Validate request (JWT or token)
                // return Unauthorized()

                // To: Do: Validate request parameter(s)
                if (id <= 0) return BadRequest(Messages.GenericMessage_InvalidId);

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

        [HttpPost("Search")]
        public async Task<IActionResult> Search(ProductSearchConditionsViewModel filter)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductViewModel model)
        {
            try
            {
                // To Do: Validate request (JWT or token)
                // return Unauthorized()

                // To: Do: Validate request parameter(s)
                if (model == null) return BadRequest(Messages.GenericMessage_NullValueProvided);

                var result = productBusiness.CreateProduct(model);
                if (!result.Success) return BadRequest(result.Message);

                return Ok();
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

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductViewModel model)
        {
            try
            {
                // To Do: Validate request (JWT or token)
                // return Unauthorized()

                // To: Do: Validate request parameter(s)
                if (model == null) return BadRequest(Messages.GenericMessage_NullValueProvided);
                if (model.Id <= 0) return BadRequest(Messages.GenericMessage_InvalidId);

                var result = productBusiness.UpdateProduct(model);
                if (!result.Success) return BadRequest(result.Message);

                return Ok();
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

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                // To Do: Validate request (JWT or token)
                // return Unauthorized()

                // To: Do: Validate request parameter(s)
                if (id <= 0) return BadRequest(Messages.GenericMessage_InvalidId);

                var result = productBusiness.DeleteProduct(id);
                if (!result.Success) return BadRequest(result.Message);

                return Ok();
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
