using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDay1.Controllers
{
    public class CustomerController : ApiController
    {
        /* [HttpGet]
          public string GetCustomer()
          {
              return "Hello world!!";
          }*/
       static List<string> names = new List<string>() {"Sai","Ramu" };
        [HttpGet]
        public List<string> GetallCustomers()
        {
            /*names.Add("Sai");
            names.Add("Seema");
            names.Add("Ragul");*/
            return names;
        }
        
        [HttpGet]
        public string GetCustomer(int id)
        {
            return names[id];
        }
        
        
        [HttpPost]
        public void AddCustomer([FromBody] string name)
        {
            names.Add(name);
        }
    }
}
