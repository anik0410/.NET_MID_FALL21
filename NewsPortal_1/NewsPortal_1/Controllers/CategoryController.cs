using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPortal_1.Controllers
{
    public class CategoryController : ApiController
    {
        [Route("api/Category/All")]
        [HttpGet]
        public List<CategoryModel> Get()
        {
            return CategoryService.Get();
        }
    }
}
