using AutoMapper;
using Common;
using Repositories.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Profiles
{
   public class ClothesProfile:Profile
    {
        public ClothesProfile()
        {
            CreateMap<TblClothes, Clothes>().ReverseMap();
        }
    }
}
