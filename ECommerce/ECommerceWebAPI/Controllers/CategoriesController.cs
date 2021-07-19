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
    public class CategoriesController : ControllerBase
    {
        public CategoriesController()
        {

        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            return Ok();
        }

        [Route("api/[controller]/{categoryId: int}/products")]
        [HttpGet]
        public IActionResult GetProductsByCategory(int categoryId)
        {
            return Ok();
        }
    }
}
