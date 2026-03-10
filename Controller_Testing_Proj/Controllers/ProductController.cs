using Controller_Testing_Proj.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controller_Testing_Proj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _service;
        

        public ProductController(IProductService service)
        {
            _service = service;
            
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _service.GetProduct(id);

            if (product == null)
                return NotFound();
            return Ok(product);
        }

       
    }

}