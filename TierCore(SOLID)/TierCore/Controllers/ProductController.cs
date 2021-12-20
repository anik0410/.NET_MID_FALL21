using BEL;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TierCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("api/Product/All")]
        [HttpGet]
        public List<ProductModel> GetAll()
        {
            return ProductService.GetAll();
        }
        [Route("api/Product/Names")]
        [HttpGet]
        public List<string> Names()
        {
            return ProductService.GetNames();
        }
    }
}
