using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Common;
using Repositories;
using Repositories.DBModels;

namespace Services
{
    public class CategoriesService : ICategoriesService
    {

        ICategoriesRepository repo;
        IMapper mapper;

        public CategoriesService(ICategoriesRepository repo, IMapper mapper)
        {
            this.mapper = mapper;
            this.repo = repo;
        }
        public void Create(string name)
        {
            repo.Create(name);
        }

        public void Create(Categories c)
        {
            TblCategories tc=mapper.Map<TblCategories>(c);
            repo.Create(tc);
        }

        public Categories GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categories> GetList()
        {
            List<TblCategories> tc = repo.GetAll();
            List<Categories> c = mapper.Map<List<Categories>>(tc);
            return c;
        }

        public void Update(Categories c)
        {
            TblCategories tc = mapper.Map<TblCategories>(c);
            repo.Update(tc);
        }

        public void DeleteById(int id)
        {
            repo.DeleteById(id);
        }
    }
}
