using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Common;
using Repositories;
using Repositories.DBModels;

namespace Services
{
    public class ClothesService : IClothesService
    {
        IClothesRepository repo;
        IMapper mapper;
        public ClothesService(IClothesRepository repo, IMapper mapper)
        {
            this.mapper=mapper;
            this.repo = repo;
        }

        public void create(Clothes c)
        {
            TblClothes tc = mapper.Map<TblClothes>(c);
            repo.Create(tc);
        }

        public List<Clothes> GetList()
        {
            List<TblClothes> lc = repo.GetAll();
            List<Clothes> lcm = mapper.Map<List<Clothes>>(lc);
            return lcm;
        }

        public void update(Clothes c)
        {
            TblClothes tc = mapper.Map<TblClothes>(c);
            repo.Update(tc);
        }

       public void DeleteById(int id)
        {
             repo.DeleteById(id);
            
        }

        public Clothes GetById(int id)
        {
            //TblClothes tc = mapper.Map<TblClothes>(c);
            Clothes c= mapper.Map< Clothes>(repo.GetById(id));
            return c;
        }

        public List<Clothes> GetByCategory(int id)
        {
            List<Clothes>lc=mapper.Map<List<Clothes>>(repo.GetByCategory(id));
            return lc;
        }

        public int CheckAmount(int id)
        {
            
            return repo.CheckAmount(id);
        }
    }
}
