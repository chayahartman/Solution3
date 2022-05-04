using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Repositories;

namespace Services
{
    class BuyingService : IBuyingService
    {
        IClothesRepository clRepo;
        ISalesRepository saRepo;
        ISalesDetailsRepository sdRepo;
        
        public BuyingService(IClothesRepository clRepo, ISalesRepository saRepo, ISalesDetailsRepository sdRepo, IMapper mapper)
        {
            this.clRepo = clRepo;
            this.saRepo = saRepo;
            this.sdRepo = sdRepo;
           // this.mapper = mapper;
        }
        public void InsertSale(int custId, List<shooping_basket> sb)
        {
            this.saRepo.insert(custId, sb);
        }

        public void InsertSaleDetails(List<shooping_basket> sb)
        {
            this.sdRepo.insert(sb);
        }

        public void UpdateAmount(List<shooping_basket> sb)
        {
            this.clRepo.UpdateAmount(sb);
        }
    }
}
