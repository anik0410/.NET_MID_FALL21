using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Intro_To_Api.Controllers
{
    public class PersonController : ApiController
    {
        public List<string> GetNames()
        {
            List<string> names = new List<string>();
            names.Add("Hriday");
            names.Add("Niaz");
            return names;
        }
    }
}
