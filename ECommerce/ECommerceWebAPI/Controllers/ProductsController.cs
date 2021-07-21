using ECommerce.DTOs;
using ECommerce.Services.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var products = await _productService.GetProduct(id);
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddAProduct([FromBody]ProductDTO product)
        {
            var addedProductId = await _productService.AddProduct(product);
            return CreatedAtAction("GetProduct", new { id = addedProductId });
        }
    }
}
