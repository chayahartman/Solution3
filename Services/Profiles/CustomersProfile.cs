using AutoMapper;
using Common;
using Repositories.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Profiles
{
    class CustomersProfile:Profile
    {
        public CustomersProfile()
        {
            CreateMap<TblCustomers, Customers>().ReverseMap();
        }
    }
}
