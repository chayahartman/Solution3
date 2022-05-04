using AutoMapper;
using Common;
using Repositories.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Profiles
{
    class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<TblCategories, Categories>().ReverseMap();
        }
    }
}
