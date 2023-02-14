using CaseWarehouseManagementAPI.BusinessLogic;
using CaseWarehouseManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CaseWarehouseManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<WarehouseController>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int pageSize, [FromQuery] int pageIndex)
        {
            if (pageSize > 0 && pageIndex > 0)
            {
                
            }
            var businessLogic = new ProductBusinessLogic();
            var products = businessLogic.GetProducts(pageSize, pageIndex);
            return Ok(pageSize + " " + pageIndex); 
        }

        // GET api/<WarehouseController>/5
        [HttpGet("{id}")]
        public Product GetDetailedProduct(Guid id)
        {
            var businessLogic = new ProductBusinessLogic();
            var product = businessLogic.GetDetailedProduct(id);
            return product;
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
