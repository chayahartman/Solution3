using Common;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Clothe_Store.Controllers.CategoriesController;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Clothe_Store.Controllers
{
    public class CategoriesController:BaseController
    {
        ICategoriesService service;
        public CategoriesController(ICategoriesService service)
        {
            this.service = service;
        }

        [Route("Create")]
        [HttpPut]
        public List<Categories> Create([FromBody]Categories c)
        {
            service.Create(c);
            return service.GetList();
        }

        [Route("Update")]
        [HttpPut]
        public List<Categories> Update([FromBody]Categories c)
        {
            service.Update(c);
            return service.GetList();
        }

        [Route("DeleteById/{id}")]
        [HttpDelete]
        public List<Categories> DeleteById(int id)
        {
            service.DeleteById(id);
            return service.GetList();
        }

        //public void Create(string name)
        //{

        //    service.Create(name);
        //}


        // GET: api/StoresWebAPI

        // [EnableCors("AllowOrigin")]
        [Route("GetList")]
        [HttpGet]

        public List<Categories> GetList()
        {

            return service.GetList();
        }

       
    }
}
