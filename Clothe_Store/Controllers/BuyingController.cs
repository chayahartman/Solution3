using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothe_Store.Controllers
{
    public class BuyingController:BaseController
    {
        IBuyingService service;
        public BuyingController(IBuyingService service)
        {
            this.service = service;
        }
        
        [Route("UpdateAmount")]
        [HttpPut]
        public void UpdateAmount([FromBody]List<shooping_basket> sb)
        {
            service.UpdateAmount(sb);

        }

        [Route("InsertSale/{id}")]
        [HttpPut]

         public void InsertSale(int id,[FromBody]List<shooping_basket> sb)
        {
            service.InsertSale(id,sb);

        }

        [Route("InsertSaleDetails")]
        [HttpPut]
        public void InsertSaleDetails([FromBody] List<shooping_basket> sb)
        {
            service.InsertSaleDetails(sb);
        }

        
    }
}
