using Common;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothe_Store.Controllers
{
    public class CustomersController:BaseController
    {
        ICustomersService service;
        public CustomersController(ICustomersService service)
        {
            this.service = service;
        }
        [Route("isExists/{name}/{password}")]
        [HttpGet]
        public bool isExists(string name,string password)
        {
            return service.IsExists(name, password);
        }

        [Route("create")]
        [HttpPut]
        public void create(Customers cust)
        {
            service.create(cust);
           // return isExists(cust.CustomerName, cust.CustomerPassword);
        }

        [Route("GetByName/{name}")]
        [HttpGet]
        public int GetByName(string name)
        {
            return service.GetByname(name);
        }
    }
}
