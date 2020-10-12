using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDay1.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public string Organizationname()
        {
            return "LTI";
        }
    }
}
