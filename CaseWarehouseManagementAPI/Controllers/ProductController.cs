using System.Reflection.Metadata;
using CaseWarehouseManagementAPI.Data.Repositories;
using CaseWarehouseManagementAPI.DTO;
using CaseWarehouseManagementAPI.Models;
using CaseWarehouseManagementAPI.ServiceLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;

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
        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_service.GetProductsInStock()); 
        }

        // GET api/Products/5
        [HttpGet("{id}")]
        public ActionResult<ProductReadDTO> GetDetailedProduct(int id) 
        {
            try
            {
                var product = _service.GetProduct(id);
                if (product == null)
                {
                    return NotFound();
                }

                return product;
            }
            catch (ArgumentNullException e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST api/Products
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductCreateDTO productCreateDto)
        {
            try
            {
                var createdProduct = _service.CreateProduct(productCreateDto);
                return CreatedAtRoute(nameof(GetDetailedProduct), new { createdProduct.Id }, createdProduct);
            }
            catch (ArgumentNullException e)
            {
                return BadRequest(e.Message);
            }

        }

        // DELETE api/<WarehouseController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            { 
                _service.SellProduct(id);
                return NoContent();
            }
            catch (ArgumentNullException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
