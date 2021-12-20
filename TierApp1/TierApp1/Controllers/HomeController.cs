using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TierApp1.Controllers
{
    public class HomeController : ApiController
    {
        [Route("api/Customer/list")]
        [HttpGet]
        public List<CustomerModel> Get()
        {
            return CustomerService.GetAll();
        }
    }
}
