using Azure;
using DAL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Service;
using WebShopAPI.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IRepo _repo;

        public ProductsController(IRepo repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public IActionResult GetProducts(string search = "", int page = 1, int count = 5)
        {
            return Ok(_repo.GetAllProducts(page, count, search));
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product? product = _repo.GetProductById(id);
            if (product != null)
                return Ok(_repo.GetProductById(id));
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductModel prodmod)
        {
            try
            {
                _repo.CreateNewProduct(prodmod.name, prodmod.price, prodmod.brandId, prodmod.catId, prodmod.desc, prodmod.path);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            return Ok();
        }

        [HttpPatch]
        public IActionResult UpdateProduct(int id, [FromBody] JsonPatchDocument<Product> newProduct)
        {

            try
            {
                _repo.UpdateProduct(id, newProduct);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

            return Ok();
        }

    }
}
