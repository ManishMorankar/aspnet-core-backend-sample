using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Backend.Api.Infrastructure;
using AspNetCore.Backend.Api.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationContext _dbContext;

        public ProductsController(ApplicationContext context)
        {
            _dbContext = context;
        }

        // GET api/products
        [HttpGet]
        public async Task<List<ProductModel>> Get()
        {
            var products = await _dbContext.Products.ToListAsync();
            return products.Select(Mappings.MapToProductModel).ToList();
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public async Task<ProductModel> Get(int id)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null) throw new ArgumentException("product id is not correct", nameof(id));
            return Mappings.MapToProductModel(product);
        }

        // POST api/products
        [HttpPost]
        public async Task Post([FromBody] ProductModel model)
        {
            var dbProduct = Mappings.MapToProductDbModel(model);
            _dbContext.Products.Add(dbProduct);
            await _dbContext.SaveChangesAsync();
        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ProductModel model)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null) throw new ArgumentException("product id is not correct", nameof(id));
            Mappings.UpdateProduct(model, product);
            await _dbContext.SaveChangesAsync();
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null) throw new ArgumentException("product id is not correct", nameof(id));
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
        }

        [HttpGet("images-list")]
        public async Task<List<string>> GetImagesList()
        {
            var images = await _dbContext.Products.Select(x => x.Img).ToListAsync();
            return images;
        }
    }
}
