using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
   public interface IClothesService
    {
        List<Clothes> GetList();
        void update(Clothes c);
        void create(Clothes c);
        void DeleteById(int id);
        Clothes GetById(int id);
        List<Clothes> GetByCategory(int id);
        int CheckAmount(int id);
    }
}
