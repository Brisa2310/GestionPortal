using GestionPortal.web.Data;
using GestionPortal.web.DataModels;
using GestionPortal.web.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionPortal.web.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _dbcontext;

        public ProductController(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        [Route("GetProductList")]

        public async Task<IActionResult> GetProductList()
        {
            return Ok(_dbcontext.Products.ToList());
        }

        [HttpPost]
        [Route("CreateProduct")]

        public async Task<IActionResult> CreateProduct(Product obj)
        {

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = obj.Name,
                Price = obj.Price,
                Category = obj.Category
            };

            _dbcontext.Products.Add(product);
            _dbcontext.SaveChanges();

            return Ok(product);

        }

    }
}
