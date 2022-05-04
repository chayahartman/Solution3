using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Common;
using Repositories;
using Repositories.DBModels;

namespace Services
{
    public class CustomersService : ICustomersService
    {
        ICustomersRepository repo;
        IMapper mapper;
        public CustomersService(ICustomersRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public void create(Customers c)
        {
            TblCustomers cus = mapper.Map<TblCustomers>(c);
            repo.Create(cus);
        }

        public int GetByname(string name)
        {
           return repo.getByName(name);
        }

        public bool IsExists(string name, string password)
        {
            return repo.isExists(name, password);
        }
    }
}
