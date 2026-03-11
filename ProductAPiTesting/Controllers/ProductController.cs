using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ProductAPiTesting.Model;
using ProductAPiTesting.Repositories;
using ProductAPiTesting.Services;

namespace ProductAPiTesting.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var res = _service.Getall();
            return Ok(res);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var prod = _service.GetById(id);
            if(prod == null)
                return NotFound();
            return Ok(prod);    
        }

        [HttpPost]
        public IActionResult AddProd(Product prod)
        {
            var res = _service.Add(prod);
            //return Ok(res);
            return CreatedAtAction(nameof(GetAll), new { id = res.Id }, res);
        }

    }
}
