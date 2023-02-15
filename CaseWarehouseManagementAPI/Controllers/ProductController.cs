using CaseWarehouseManagementAPI.Data.Repositories;
using CaseWarehouseManagementAPI.DTO;
using CaseWarehouseManagementAPI.Models;
using CaseWarehouseManagementAPI.ServiceLayer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaseWarehouseManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service; 
        }
        // GET: api/<WarehouseController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_service.GetProductsInStock()); 
        }

        // GET api/<WarehouseController>/5
        [HttpGet("{id}")]
        public ProductReadDTO GetDetailedProduct(int id)
        {
            return _service.GetProduct(id); 
        }

        // POST api/<WarehouseController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product newProduct)
        {
            if (newProduct != null)
            {
                return CreatedAtAction(
                    nameof(GetDetailedProduct), 
                    new { id = newProduct.Id },
                    newProduct);
            }
            return BadRequest(new ArgumentNullException());
        }

        // PUT api/<WarehouseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WarehouseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
