using Common;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothe_Store.Controllers
{
    public class ClothesController:BaseController
    {
        IClothesService service;
        public ClothesController(IClothesService service)
        {
            this.service = service;
        }
        [Route("GetList")]
        [HttpGet]
        public List<Clothes> GetList()
        {
            return service.GetList();
        }

        [Route("Create")]
        [HttpPut]

        public List<Clothes> Create([FromBody]Clothes c)
        {
            service.create(c);
            return service.GetList();
        }

        [Route("Update")]
        [HttpPut]

        public List<Clothes> Update([FromBody]Clothes c)
        {
            service.update(c);
            return service.GetList();
        }

        [Route("DeleteById/{id}")]
        [HttpDelete]
        public List<Clothes> DeleteById(int id)
        {
           service.DeleteById(id);
            return service.GetList();
        }

        [Route("GetById/{id}")]
        [HttpGet]
        public Clothes GetById(int id)
        {
           return service.GetById(id);
        }


        [Route("GetByCategory/{categoryId}")]
        [HttpGet]

        public List<Clothes> GetByCategory(int categoryId)
        {

            return service.GetByCategory(categoryId);
        }

        [Route("CheckAmount/{id}")]
        [HttpGet]

        public int CheckAmount(int id)
        {

            return service.CheckAmount(id);
        }


    }
}
