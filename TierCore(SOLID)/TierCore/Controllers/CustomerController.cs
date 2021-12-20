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
    public class CustomerController : ControllerBase
    {
        [Route("api/Customer/list")]
        [HttpGet]
        public List<CustomerModel> Get()
        {
            return CustomerService.GetAll();
        }
    }
}
